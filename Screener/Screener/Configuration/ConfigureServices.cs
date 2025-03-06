using Game.Services;

namespace Screener.Configuration;

public static class ConfigureServices
{
    public static IServiceCollection AddScreenerServices(this IServiceCollection services)
    {
        services.AddSingleton<GameService>();

        return services;
    }
}
