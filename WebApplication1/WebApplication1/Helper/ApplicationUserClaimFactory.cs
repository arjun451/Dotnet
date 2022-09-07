using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using WebApplication1.Models;

namespace WebApplication1.Helper
{
    public class ApplicationUserClaimFactory:UserClaimsPrincipalFactory<ApplicationUser,IdentityRole>
    {
        public ApplicationUserClaimFactory(UserManager<ApplicationUser> userManager,RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> options):base(userManager, roleManager, options)
        {

        }


       protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("UserFirstName", user.FirstName ?? ""));
            identity.AddClaim(new Claim("UserFirstName", user.FirstName ?? ""));
            identity.AddClaim(new Claim("UserId", user.UserName ?? ""));
            return identity;
        }
    }
}
