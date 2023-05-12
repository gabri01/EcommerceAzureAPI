using DBContext;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Models.IdentityModels;
using System.Text;

namespace API.ProgramConfigurations
{
    public static class IdentityConfigurations
    {
        public static IServiceCollection MyAuthenticationJWT(this IServiceCollection Services)
        {
            Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
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

            return Services;
        }

        public static IServiceCollection MyAddIdentityConfigurations(this IServiceCollection Services)
        {
            Services.AddDbContext<EcommerceAzureContext>(Options => Options.UseSqlServer(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["EcommerceAzure"]));

            Services.AddIdentityCore<EcommerceAzureIdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                        .AddRoles<EcommerceAzureRole>()
                        .AddEntityFrameworkStores<EcommerceAzureContext>()
                        .AddUserManager<EcommerceAzureUserManager>()
                        .AddDefaultTokenProviders();

            return Services;
        }
    }
}
