using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clases
{
     class Articulo
    {
        public int id;

        public string Codigo;

        public string Nombre;

        public string descipcion;

        public Marca idMarca; // toma del objeto Marca(clase)

        public Categoria idCategoria; // toma del objeto Categoria (clase)

        public decimal Precio;
    }
}
