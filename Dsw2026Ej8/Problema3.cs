using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
           
            int valorCopia = originalValue;
           
            valorCopia++;
            
            Product productoCopia = product;

            productoCopia.ModificarDescripcion("Copia Modificada");

            return $"{originalValue}-{valorCopia}-{product.Descripcion}";
        }
    }
}
