using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.ValueObject;
    public class InventoryQuantity
    {
        public int Value { get; private set; }

        public InventoryQuantity(int value)
        {
            Value = value;
        }

        public static InventoryQuantity Create(int value)
        {
            if(value < 0) {  throw new ArgumentOutOfRangeException("El inventario no puede ser negativo"); }

            return new InventoryQuantity(value);
        }
    }

