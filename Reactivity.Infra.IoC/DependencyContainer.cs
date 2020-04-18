using Microsoft.Extensions.DependencyInjection;
using Reactivity.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

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
