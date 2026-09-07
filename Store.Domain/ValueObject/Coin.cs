using Store.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.ValueObject
{
    public class Coin
    {
        public decimal Amount { get; private set; }
        public string Currency { get; private set; } = default!;

        private Coin(decimal amount, string currency)
        {
            Amount = amount;    
            Currency = currency;
        }

        public static Coin Create(decimal amount, string currency = "USD")
        {
            if(amount < 0)
            {
                throw new BusinessRuleException("El monto no puede ser negativo");
            }

            if (string.IsNullOrEmpty(currency))
            {
                throw new BusinessRuleException("La moneda es requerida");
            }

            return new Coin(amount, currency);
        }
    }
}
