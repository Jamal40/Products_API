using Microsoft.EntityFrameworkCore;
using Polly;
using Polly.Fallback;
using Products_API;
using Products_API.Data;
using Products_API.Endpoints;
using Products_API.Middlewares;
using Products_API.Services;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

var logger = LoggerFactory
    .Create(config =>
    {
        config.AddConsole();
    })
    .CreateLogger("Program");

#region Defualt

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion

#region Add Cors

builder.Services.AddCors(options =>
{
    options.AddPolicy(Constants.Policies.AllowAll, b =>
    {
        b.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});

#endregion

#region Http Services

builder.Services.AddHttpClient<IUnsplashService, UnsplashService>(client =>
{
    var unsplashApiKey = builder.Configuration.GetValue<string>(
        Constants.ConfigurationKeys.UnsplashApiKey);
    client.DefaultRequestHeaders.Add(Constants.Headers.Authorization,
        string.Format(Constants.Headers.UnsplashAuthValue, unsplashApiKey));

    string baseUri = builder.Configuration.GetValue<string>(
        Constants.Endpoints.UnsplashBaseUri)!;
    client.BaseAddress = new Uri(baseUri);
})
    .AddTransientHttpErrorPolicy(
        p => p.WaitAndRetryAsync(
            retryCount: 2,
            sleepDurationProvider: _ => TimeSpan.FromSeconds(3),
            onRetry: (ressponse, time) => logger.LogCritical("Code: {0}, Content: {1}, Message: {2}",
                ressponse?.Result?.StatusCode,
                ressponse?.Result?.Content.ReadAsStringAsync().Result,
                ressponse?.Exception?.Message))
    )
    .AddTransientHttpErrorPolicy(p => p.CircuitBreakerAsync(3, TimeSpan.FromSeconds(10)));

#endregion

#region Db Context

var connectionString = builder.Configuration.GetConnectionString(
    Constants.ConnectionStrings.ShopDb);
builder.Services.AddDbContext<ShopContext>(options =>
    options.UseSqlServer(connectionString));

#endregion

#region Middlewares

builder.Services.AddScoped<EnsurePrdouctsHavePhotos>();

#endregion

var app = builder.Build();

#region Middlewares Pipeline

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(Constants.Policies.AllowAll);
app.UseHttpsRedirection();
app.UseMiddleware<EnsurePrdouctsHavePhotos>();
app.MapProductEndpoints();
app.MapCategoryEndpoints();

#endregion

app.Run();