using BusinessLogic;
using DataAccessLogic;
using DBContext;
using Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Models.IdentityModels;
using Serilog;
using System.Text;

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

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                                .Build()
                                                .GetSection("JWTConfigurations")["Issuer"],
        ValidAudience = new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                                  .Build()
                                                  .GetSection("JWTConfigurations")["Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                                                                                     .Build()
                                                                                                     .GetSection("JWTConfigurations")["Key"])),
        ClockSkew = TimeSpan.Zero
    };
});

builder.Services.AddDbContext<EcommerceAzureContext>(Options => Options.UseSqlServer(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["EcommerceAzure"]));

//builder.Services.AddIdentity<EcommerceAzureUser, EcommerceAzureRole>()
//                    .AddEntityFrameworkStores<EcommerceAzureContext>()
//                    .AddDefaultTokenProviders();
builder.Services.AddIdentityCore<EcommerceAzureIdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddRoles<EcommerceAzureRole>()
        .AddEntityFrameworkStores<EcommerceAzureContext>()
        .AddUserManager<EcommerceAzureUserManager>()
        .AddDefaultTokenProviders();

builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "EcommerceAzure.API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme. " +
                      "\r\n\r\n Enter 'Bearer' [space] and then your token in the text " +
                      "input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}

        }
    });
});

builder.Services.AddCors
(
    policyBuilder => policyBuilder.AddDefaultPolicy
    (
        policy => policy
            .WithOrigins("*")
            .AllowAnyHeader()
            .AllowAnyHeader()
    )
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors
(
    x => x
        .AllowAnyMethod()
        .AllowAnyHeader()
        .SetIsOriginAllowed(origin => true)
        .AllowCredentials()
);

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
