var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Urls.Add("http://localhost:5000");

app.UseStaticFiles();
app.MapGet("/", async context =>
{
    context.Response.Redirect("/index.html");

});

app.Run();
