using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public int IDCategoria { get; set; }
        public string Descripcion { get; set; }

        //PARA MOSTRAR ATRIBUTO EN LA TABLE EN VEZ DE MOSTRAR TODO EL OBJETO
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
