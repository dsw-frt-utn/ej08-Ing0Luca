using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Amount;
        }
    }
}
