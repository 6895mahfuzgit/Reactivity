using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reactivity.Application.Interfaces;
using Reactivity.Application.Services;
using Reactivity.Domain.Interfaces;
using Reactivity.Infra.Data.Context;
using Reactivity.Infra.Data.Query.Activies;
using Reactivity.Infra.Data.Repository;

namespace Reactivity.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {

            //Application
            services.AddTransient<IValueService, ValueService>();
            services.AddTransient<IActivityService, ActivityService>();


            //Data
            services.AddTransient<IValueRepository, ValueRepository>();


            services.AddDbContext<ReactivlyDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ReactivlyConnection")));


            services.AddMediatR(typeof(List.Handler).Assembly);

        }
    }
}
