using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hoffman_Caero
{
    class Articulo
    {
        public int IDArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IDMarca { get; set; } 
        public int IDCategoria { get; set; } 
        public string ImagenURL { get; set; }
        public float Precio { get; set; }

    }
}
