using Microsoft.EntityFrameworkCore;
using Store.Application.Contracts;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Infraestructure.Persistence.Repositories
{
    internal class RepositoryProducts(ApplicationDbContext context) : IRepositoryProducts
    {
        public async Task Add(Product product)
        {
            context.Add(product);
            await context.SaveChangesAsync();
        }

        public async Task<bool> Exists(string name)
        {
            return await context.Products.AnyAsync(p => p.Name == name);
        }
    }
}
