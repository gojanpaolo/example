var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var logger = app.Services.GetRequiredService<ILogger<Program>>();

logger.LogWarning("jantest log Application Starting Up");

app.MapGet("/", (string x) =>
{
    logger.LogWarning($"Hello world jantest log {x}");
    return $"Hello World4: {x}";
});

app.Run();




