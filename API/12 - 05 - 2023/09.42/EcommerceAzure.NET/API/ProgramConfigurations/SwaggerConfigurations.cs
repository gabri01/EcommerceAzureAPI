using Microsoft.OpenApi.Models;

namespace API.ProgramConfigurations
{
    public static class SwaggerConfigurations
    {
        public static WebApplication MyConfigureSwagger(this WebApplication App)
        {
            if (App.Environment.IsDevelopment())
            {
                App.UseSwagger();
                App.UseSwaggerUI();
            }

            return App;
        }

        public static IServiceCollection MyConfigureSwaggerJWT(this IServiceCollection Services)
        {
            Services.AddSwaggerGen(option =>
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

            return Services;
        }
    }
}
