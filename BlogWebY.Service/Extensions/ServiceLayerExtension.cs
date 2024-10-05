﻿using BlogWebY.Service.FluentValidations;
using BlogWebY.Service.Services.Abstractions;
using BlogWebY.Service.Services.Concrete;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;

namespace BlogWebY.Service.Extensions
{
    public static class ServiceLayerExtension
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddAutoMapper(assembly);

            services.AddControllersWithViews()
                .AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
                opt.DisableDataAnnotationsValidation = true;
                opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
            });

            return services;
        }
    }
}
