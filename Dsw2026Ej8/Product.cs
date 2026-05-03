using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{

        public class Product
        {
            public string Descripcion { get; set; }

            public void ModificarDescripcion(string nuevaDesc)
            {
                Descripcion = nuevaDesc;
            }
        }
    }

