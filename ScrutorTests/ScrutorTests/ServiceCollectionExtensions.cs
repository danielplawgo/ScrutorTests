﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using ScrutorTests.Repositories;

namespace ScrutorTests
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.Scan(s => s.FromAssemblyOf<IRepository>()
                .AddClasses(c => c.AssignableTo<IRepository>().WithoutAttribute<DecoratorAttribute>())
                    .AsImplementedInterfaces()
                    .WithScopedLifetime());

            //services.AddScoped<IProductRepository, ProductRepository>();

            services.TryDecorate<IProductRepository, ProductRepositoryLoggerDecorator>();

            return services;
        }
    }
}
