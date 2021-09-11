using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Caero_Hoffman
{
    class Articulo
    {
        public int IDArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        //public int IDMarca { get; set; } //TIENE QUE SER ASOCIACION
       // public int IDCategoria { get; set; } //TIENE QUE SER ASOCIACION
        public string ImagenURL { get; set; }
        public float Precio { get; set; }
    }
}
