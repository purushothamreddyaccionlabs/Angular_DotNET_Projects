using MiddlewareExample.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MyMiddleware>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Middleware 1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("From middleware 1");
    await next(context);
});

// Middleware 2
app.UseMiddleware<MyMiddleware>();

// Middleware 3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("From middleware 3");
});





