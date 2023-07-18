var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//enable routing
app.UseRouting();

//creating endpoints
app.UseEndpoints(endpoints =>
{
    //add your endpoints here
    /*endpoints.MapGet("map1", async(context) => {
        await context.Response.WriteAsync("In Map 1");
    });

    endpoints.MapPost("map2", async (context) => {
        await context.Response.WriteAsync("In Map 2");
    });*/

    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        context.Response.WriteAsync("In Files");
    });

    // Eg: products/details
    endpoints.Map("products/details/{id:int?}", async context =>
    {
        if (context.Request.RouteValues.ContainsKey("id"))
        {
            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            await context.Response.WriteAsync($"Product details - {id}");
        }
        else
        {
            await context.Response.WriteAsync($"Product details - id is not supplied");
        }
    });
});


app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at {context.Request.Path}");
});

app.Run();
