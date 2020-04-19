using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reactivity.Application.Interfaces;
using Reactivity.Application.Services;
using Reactivity.Domain.Interfaces;
using Reactivity.Infra.Data.Context;
using Reactivity.Infra.Data.Repository;

namespace Reactivity.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {

            //Application
            services.AddTransient<IValueService, ValueService>();

            //Data
            services.AddTransient<IValueRepository, ValueRepository>();
            //    services.AddDbContext<ReactivlyDBContext>();

            services.AddDbContext<ReactivlyDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ReactivlyConnection")));

        }
    }
}
