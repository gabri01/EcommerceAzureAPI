namespace API.ProgramConfigurations
{
    public static class CorsConfigurations
    {
        public static IServiceCollection MyCorsService(this IServiceCollection Services)
        {
            Services.AddCors
            (
                policyBuilder => policyBuilder.AddDefaultPolicy
                (
                    policy => policy
                                .WithOrigins("*")
                                .AllowAnyHeader()
                                .AllowAnyHeader()
                )
            );

            return Services;
        }

        public static WebApplication MyCorsApp(this WebApplication App)
        {
            App.UseCors
            (
                x => x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true)
                    .AllowCredentials()
            );

            return App;
        }
    }
}
