using Microsoft.EntityFrameworkCore;
using Polly;
using Polly.Fallback;
using Products_API;
using Products_API.Data;
using Products_API.Endpoints;
using Products_API.Middlewares;
using Products_API.Services;

var builder = WebApplication.CreateBuilder(args);

var logger = LoggerFactory
    .Create(config =>
    {
        config.AddConsole();
    })
    .CreateLogger("Program");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(Constants.Policies.AllowAll, b =>
    {
        b.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin();
    });
});
builder.Services.AddHttpClient<IUnsplashService, UnsplashService>(client =>
{
    var unsplashApiKey = builder.Configuration.GetValue<string>(
        Constants.ConfigurationKeys.UnsplashApiKey);
    client.DefaultRequestHeaders.Add(Constants.Headers.Authorization,
        string.Format(Constants.Headers.UnsplashAuthValue, unsplashApiKey));

    string baseUri = builder.Configuration.GetValue<string>(
        Constants.Endpoints.UnsplashBaseUri)!;
    client.BaseAddress = new Uri(baseUri);
});

var connectionString = builder.Configuration.GetConnectionString(
    Constants.ConnectionStrings.ShopDb);
builder.Services.AddDbContext<ShopContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<EnsurePrdouctsHavePhotos>();

builder.Services.AddResiliencePipeline<string, string>(Constants.Policies.UnsplashFallback,
    pipelineBuilder =>
    {
        pipelineBuilder.AddFallback(new FallbackStrategyOptions<string>
        {
            FallbackAction = _ => Outcome.FromResultAsValueTask(string.Empty),
            OnFallback = args =>
            {
                logger.LogError(args.Outcome.Exception?.Message);
                return ValueTask.CompletedTask;
            }
        });
    });

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseCors(Constants.Policies.AllowAll);
app.UseHttpsRedirection();
app.UseMiddleware<EnsurePrdouctsHavePhotos>();
app.MapProductEndpoints();
app.MapCategoryEndpoints();

app.Run();