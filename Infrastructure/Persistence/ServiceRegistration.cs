using Application.Abstract;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<ISpotRepository, SpotRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();

        }

    }
}
