using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Application.Contracts;

public interface IRepositoryProducts
{
    Task Add(Product product);
    Task<bool> Exists(string name);
    
}
