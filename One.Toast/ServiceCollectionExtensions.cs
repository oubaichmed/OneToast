using Microsoft.Extensions.DependencyInjection;
using One.Toast.Services;

namespace One.Toast;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddOneToast(this IServiceCollection services)
    {
        return services.AddScoped<IToastService, ToastService>();
    }
}
