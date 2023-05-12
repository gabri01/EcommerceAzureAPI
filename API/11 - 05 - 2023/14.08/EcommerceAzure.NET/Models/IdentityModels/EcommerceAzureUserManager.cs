using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Models.IdentityModels
{
    public class EcommerceAzureUserManager : UserManager<EcommerceAzureIdentityUser>
    {
        public EcommerceAzureUserManager(IUserStore<EcommerceAzureIdentityUser> store,
                                         IOptions<IdentityOptions> optionsAccessor,
                                         IPasswordHasher<EcommerceAzureIdentityUser> passwordHasher,
                                         IEnumerable<IUserValidator<EcommerceAzureIdentityUser>> userValidators,
                                         IEnumerable<IPasswordValidator<EcommerceAzureIdentityUser>> passwordValidators,
                                         ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors,
                                         IServiceProvider services,
                                         ILogger<UserManager<EcommerceAzureIdentityUser>> logger)
                                         : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        { }

        //public override bool SupportsUserSecurityStamp => false;
    }
}
