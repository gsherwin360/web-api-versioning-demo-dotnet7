using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using WebApiVersioningDemo;

namespace Microsoft.Extensions.DependencyInjection;

/// <summary>
/// This class is responsible for configuring API versioning services to the Dependency Injection container.
/// </summary>
[ExcludeFromCodeCoverage]
public static class VersioningServices
{
    public static IServiceCollection AddApiVersioning(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        if (configuration is null)
        {
            throw new ArgumentNullException(nameof(configuration));
        }

        // Register AppVersionInfo with configuration-based initialization
        services.AddSingleton(new AppVersionInfo(
            configuration.GetValue(
                "ReleaseNumber",
                $"NotSet-{DateTime.UtcNow.ToString("yyyyMMddHHmmssfff", CultureInfo.InvariantCulture)}")));

        return services;
    }
}