using Microsoft.Extensions.DependencyInjection;
using Reactivity.Infra.Data.Context;

namespace Reactivity.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<ReactivlyDBContext>();
        }
    }
}
