using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using StickyNoteClone.Models;
using System.Security.Claims;

namespace StickyNoteClone.Factory
{
    //Use for custom claims
    public class CustomClaimsFactory : UserClaimsPrincipalFactory<User>
    {
        public CustomClaimsFactory(UserManager<User> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("firstname", user.FirstName));
            identity.AddClaim(new Claim("lastname", user.LastName));

            return identity;

            //register this class in the service collection:
            //services.AddScoped<IUserClaimsPrincipalFactory<User>, CustomClaimsFactory>();
        }
    }
}
