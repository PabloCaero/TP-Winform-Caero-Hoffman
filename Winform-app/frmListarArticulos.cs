using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Winform_app
{
    public partial class frmListarArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public frmListarArticulos()
        {
            InitializeComponent();
        }

        private void frmListarArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dvgArticulos.DataSource = listaArticulo;
            dvgArticulos.Columns["ImagenURL"].Visible=false;//PARA OCULTAR LA URL 
            cargarImagen(listaArticulo[0].ImagenURL);

        }

        private void dvgArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado =(Articulo)dvgArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenURL);
        }

        private void cargarImagen(string imagen)
        {
           
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxArticulo.Load("https://i2.wp.com/learn.onemonth.com/wp-content/uploads/2017/08/1-10.png?w=845&ssl=1"); 
            }
        }
    }
}
