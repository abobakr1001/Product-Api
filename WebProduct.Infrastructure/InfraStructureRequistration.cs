using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebProduct.Core.Interface;
using WebProduct.Infrastructure.Data;
using WebProduct.Infrastructure.Repository;

namespace WebProduct.Infrastructure
{
    public static class InfraStructureRequistration
    {
        public static IServiceCollection InfraStructureConfigration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            //services.AddScoped<IcategoryRepository, CategoryRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();


            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefualtConnection"))
            );

            return services;
        }
    }
}
