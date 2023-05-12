using DBContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Models.CustomIdentityUser;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
