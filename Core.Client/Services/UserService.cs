using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Core.Client.Services;

public class UserService
{
    private readonly AuthenticationStateProvider _authenticationStateProvider;

    public UserService(AuthenticationStateProvider authenticationStateProvider)
    {
        _authenticationStateProvider = authenticationStateProvider;
    }

    public async Task<ClaimsPrincipal?> GetCurrentUser()
    {
        AuthenticationState authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        ClaimsPrincipal user = authState.User;
        if (user?.Identity?.IsAuthenticated == true)
        {
            return user;
        }

        return null;
    }
}
