var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var logger = app.Services.GetRequiredService<ILogger<Program>>();

logger.LogWarning("jantest log Application Starting Up");

app.MapGet("/foo", (string x) =>
{
    logger.LogWarning($"Hello world jantest log {x}");
    return $"Hello World3: {x}";
});

app.UseDefaultFiles();
app.UseRouting();
app.MapStaticAssets();

app.Run();

