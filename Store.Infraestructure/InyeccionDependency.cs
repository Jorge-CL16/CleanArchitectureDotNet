using Microsoft.Extensions.DependencyInjection;
using Store.Infraestructure.Persistence;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Store.Application.Contracts;
using Store.Infraestructure.Persistence.Repositories;

namespace Store.Infraestructure;

public static class InyeccionDependency
{
    public static IServiceCollection AddInfraestrcuture(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer("name=DefaultConnection"));


        services.AddScoped<IRepositoryProducts, RepositoryProducts>();

        return services;
    }
}
