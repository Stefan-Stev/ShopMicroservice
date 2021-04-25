using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
   public static class PersistenceDI
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ShopContext>(options => options.UseSqlite(configuration.GetConnectionString("HotDiggetyDog")));

            services.AddScoped<IApplicationContext>(provider => provider.GetService<ShopContext>());
        }
    }
}
