using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Application.UseCase.Products.Commands.CreateProducts;

public record CommandCreateProduct(
    string Name,
    string? Description,
    decimal Price,
    string Currency,
    int BeginningInventory

 );
    

