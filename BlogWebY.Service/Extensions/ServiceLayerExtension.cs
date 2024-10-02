using BlogWebY.Data.Context;
using BlogWebY.Data.Repositories.Abstraction;
using BlogWebY.Data.Repositories.Concretes;
using BlogWebY.Data.UnitOfWorks;
using BlogWebY.Service.Services.Abstractions;
using BlogWebY.Service.Services.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Service.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();

            services.AddAutoMapper(assembly);
            return services;
        }
    }
}
