using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Infraestructure.Persistence;

internal class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected ApplicationDbContext()
    {
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

    public DbSet<Product> Products { get; set; }
}
