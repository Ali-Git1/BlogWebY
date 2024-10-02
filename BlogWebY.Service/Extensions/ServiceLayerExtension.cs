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
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Service.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
