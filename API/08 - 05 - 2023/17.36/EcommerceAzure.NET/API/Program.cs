using BusinessLogic;
using DataAccessLogic;
using DBContext;
using Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models.CustomIdentityUser;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddTransient<EcommerceAzureContext>(Provider => new EcommerceAzureContext(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["EcommerceAzure"]));
builder.Services.AddTransient<IDAL, DALClass>();
builder.Services.AddTransient<IBusiness, BusinessClass>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<Serilog.ILogger>(Log.Logger);

Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).Enrich.FromLogContext().CreateLogger();
builder.Logging.ClearProviders();

builder.Services.AddTransient<EcommerceAzureContext>(Provider => new EcommerceAzureContext(new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                                                                                                     .Build()
                                                                                                                     .GetSection("ConnectionStrings")["EcommerceAzure"]));

builder.Services.AddDbContext<EcommerceAzureContext>(Options => Options.UseSqlServer(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["EcommerceAzure"]));

builder.Services.AddIdentity<EcommerceAzureUser, EcommerceAzureRole>()
                    .AddEntityFrameworkStores<EcommerceAzureContext>()
                    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
