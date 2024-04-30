using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Products_API.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using LoginReturnType = System.Threading.Tasks.Task<Microsoft.AspNetCore.Http.HttpResults.Results<Microsoft.AspNetCore.Http.HttpResults.Ok<Products_API.Dtos.Token>, Microsoft.AspNetCore.Http.HttpResults.UnauthorizedHttpResult>>;
using RegisterReturnType = System.Threading.Tasks.Task<Microsoft.AspNetCore.Http.HttpResults.Results<Microsoft.AspNetCore.Http.HttpResults.Created<Microsoft.AspNetCore.Identity.IdentityUser>, Microsoft.AspNetCore.Http.HttpResults.BadRequest<System.Collections.Generic.IEnumerable<Microsoft.AspNetCore.Identity.IdentityError>>>>;

namespace Products_API.Endpoints;

public static class AccountEndpoints
{
    // implement authentication endpoints here
    public static void MapAccountEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Account")
            .WithTags("Account");

        group.MapPost("/Register", async RegisterReturnType (RegisterUser registerUser, UserManager<IdentityUser> userManager) =>
        {
            var user = new IdentityUser
            {
                UserName = registerUser.Email,
                Email = registerUser.Email
            };

            var result = await userManager.CreateAsync(user, registerUser.Password);
            if (!result.Succeeded)
            {
                return TypedResults.BadRequest(result.Errors);
            }

            var claims = new List<Claim>
            {
                new (ClaimTypes.Name, user.UserName),
                new (ClaimTypes.Email, user.Email),
                new (ClaimTypes.NameIdentifier, user.Id)
            };
            await userManager.AddClaimsAsync(user, claims);
            return TypedResults.Created($"/api/Account/{user.Id}", user);
        })
            .WithName("RegisterUser")
            .WithOpenApi();

        group.MapPost("/Login", async LoginReturnType (LoginUser loginUser,
            UserManager<IdentityUser> userManager,
            IConfiguration configuration) =>
        {
            var user = await userManager.FindByEmailAsync(loginUser.Email);
            if (user == null)
            {
                return TypedResults.Unauthorized();
            }

            var passwordValid = await userManager.CheckPasswordAsync(user, loginUser.Password);
            if (!passwordValid)
            {
                return TypedResults.Unauthorized();
            }

            var claims = await userManager.GetClaimsAsync(user);
            var key = configuration["SecretKey"]!;
            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
                SecurityAlgorithms.HmacSha256);

            var exp = DateTime.Now.AddDays(30);

            var token = new JwtSecurityToken(
                claims: claims,
                signingCredentials: signingCredentials,
                expires: exp);

            var tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
            return TypedResults.Ok(new Token(tokenValue, exp));
        })
            .WithName("LoginUser")
            .WithOpenApi();
    }
}
