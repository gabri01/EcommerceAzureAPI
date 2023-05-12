using DBContext;
using Interfaces;
using DataAccessLogic;
using BusinessLogic;

namespace API.ProgramConfigurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection MyAddDependencyInjection(this IServiceCollection Services)
        {
            Services.AddTransient<EcommerceAzureContext>(Provider => new EcommerceAzureContext(new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                                                                                                         .Build()
                                                                                                                         .GetSection("ConnectionStrings")["EcommerceAzure"])); ;
            

            Services.AddTransient<EcommerceAzureContext>(Provider => new EcommerceAzureContext(new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                                                                                                         .Build()
                                                                                                                         .GetSection("ConnectionStrings")["EcommerceAzure"]));
            Services.AddTransient<IDAL, DALClass>();
            Services.AddTransient<IBusiness, BusinessClass>();

            return Services;
        }
    }
}
