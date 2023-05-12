using API.ProgramConfigurations;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.MyAddDependencyInjection();
builder.Services.MyAddIdentityConfigurations();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<Serilog.ILogger>(Log.Logger);
Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).Enrich.FromLogContext().CreateLogger();
builder.Logging.ClearProviders();
builder.Services.MyAuthenticationJWT();
builder.Services.MyConfigureSwaggerJWT();
builder.Services.MyCorsService();

var app = builder.Build();
app.MyConfigureSwagger();
app.MyCorsApp();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
