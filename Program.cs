var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var logger = app.Services.GetRequiredService<ILogger<Program>>();

logger.LogWarning("jantest log Application Starting Up");

app.MapGet("/", () =>
{
    logger.LogWarning("Hello world jantest log");
    return "Hello World!";
});

app.Run();

