using BlogWebY.Data.Context;
using BlogWebY.Data.Repositories.Abstraction;
using BlogWebY.Data.Repositories.Concretes;
using BlogWebY.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlogWebY.Data.Extension
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
