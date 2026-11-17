var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { message = "Myapp API is running." }));
app.MapGet("/api/health", () => Results.Ok(new { status = "Healthy" }));

app.Run();
// made some changes