using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Imagenes
    {

        public int id { get; set; }
        public Articulo idArticulo { get; set; } //Llama al objeto Articulo
        public string ImagenURL { get; set; }

    }
}
