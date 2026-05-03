using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema2
    {
        public string CrearResumenVenta(long productCode,string productDescription,int quantity,decimal unitPrice)
        {
            decimal totalCalculado = 0;
            if(quantity > 0)
            {
                totalCalculado = quantity * unitPrice;
            }

            var miResumen = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = totalCalculado
            };
            return $"{miResumen.Code}-{miResumen.Description}-{miResumen.Total}";
        }
    }
}
