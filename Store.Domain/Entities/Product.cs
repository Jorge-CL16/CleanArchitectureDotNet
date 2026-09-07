using Store.Domain.Exceptions;
using Store.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; } = Guid.CreateVersion7();

        public string Name { get; private set; } = default!;

        public string? Description { get; private set; }

        public Coin Price { get; private set; } = Coin.Create(0);

        public InventoryQuantity InventoryQuantity { get; private set; } = InventoryQuantity.Create(0);

        public bool Active { get; private set; } = true;

        public static Product Create(string name, string? description, Coin price, InventoryQuantity inventoryQuantity)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new BusinessRuleException("El nombre del producto es requerido");
            }

            if(name.Trim().Length > 200)
            {
                throw new BusinessRuleException("La longitud máxima del nombre es de 200 caracteres");
            }

            return new Product
            {
                Name = name,
                Description = description,
                Price = price,
                InventoryQuantity = inventoryQuantity
            };
        }

    }
}