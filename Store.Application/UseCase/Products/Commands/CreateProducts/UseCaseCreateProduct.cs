using Store.Application.Contracts;
using Store.Domain.Entities;
using Store.Domain.Exceptions;
using Store.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Application.UseCase.Products.Commands.CreateProducts;
    public class UseCaseCreateProduct(IRepositoryProducts repositoryProducts)
    {      
        public async Task<Guid> Handle(CommandCreateProduct command)
        {

        var exists = await repositoryProducts.Exists(command.Name);

        if (exists)
        {
            throw new BusinessRuleException($"Ya existe un producto con el nombre: {command.Name}");
        }
            
            var money = Coin.Create(command.Price, command.Currency);
            var inventory = InventoryQuantity.Create(command.BeginningInventory);

            var product = Product.Create(
                name: command.Name,
                description: command.Description,
                price: money,
                inventoryQuantity: inventory
             );

            await repositoryProducts.Add( product );
            return product.Id;

        }
    }

