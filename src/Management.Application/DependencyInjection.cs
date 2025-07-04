﻿using Management.Application.MappersV2;
using Microsoft.Extensions.DependencyInjection;

namespace Management.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services) =>
        services
            .AddConfiguredMediator()
            .AddScoped<OrderMapper>();
    
    private static IServiceCollection AddConfiguredMediator(this IServiceCollection services) =>
        services.AddMediator(opts =>
        {
            opts.ServiceLifetime = ServiceLifetime.Transient;
            opts.Assemblies = [typeof(ApplicationAssembly)];
            opts.Namespace = "Mediator.SourceGenerator";
            opts.GenerateTypesAsInternal = true;
        });
}
