using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BML
{
    public class Producto
    {
        public int idProducto { get; set; }

        public string descripcion { get; set; }

        public int idCategoria { get; set; }

        public decimal precioUnitario { get; set; }

        public int stock { get; set; }

        public string codigo { get; set; }

        public int idMarca { get; set; }

        public bool activo { get; set; }

        public Producto() { }


    }
}
