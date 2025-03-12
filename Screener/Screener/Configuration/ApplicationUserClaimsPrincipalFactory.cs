using Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Screener.Data;
using System.Security.Claims;

namespace Screener.Configuration;

public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser>
{
    public ApplicationUserClaimsPrincipalFactory(UserManager<ApplicationUser> userManager, IOptions<IdentityOptions> optionsAccessor)
        : base(userManager, optionsAccessor)
    {
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
    {
        ClaimsIdentity claims = await base.GenerateClaimsAsync(user);
        claims.AddClaim(new Claim(UserClaims.Id, user.Id));
        claims.AddClaim(new Claim(UserClaims.PhoneNumber, user.PhoneNumber));
        return claims;
    }

}
