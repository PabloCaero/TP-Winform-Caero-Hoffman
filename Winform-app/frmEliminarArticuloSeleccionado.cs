using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Winform_app
{
    public partial class frmEliminarArticuloSeleccionado : Form
    {
        private Articulo articulo = null;
        public frmEliminarArticuloSeleccionado(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                //IMPORTANTE PARA MODIFICAR
             
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
               
                negocio.eliminar(articulo);//DESARROLLAR ESTA FUNCIONALIDAD
                MessageBox.Show("Eliminado correctamente");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmEliminarArticuloSeleccionado_Load(object sender, EventArgs e)
        {
  
            try
            {
      
                if (articulo != null)
                {
                    //CON ESTO PRESELECCIONA
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
          
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
    }
}
