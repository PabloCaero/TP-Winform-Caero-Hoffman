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
    public partial class frmBuscarArticulo : Form
    {
        private List<Articulo> buscaArticulo;
        public frmBuscarArticulo()
        {
            InitializeComponent();
        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.Codigo = txtBuscarCodigo.Text;
                buscaArticulo = negocio.buscarCodigo(articulo);
                dgvBuscarArticulo.DataSource = buscaArticulo;
                dgvBuscarArticulo.Columns["IDArticulo"].Visible = false;
                dgvBuscarArticulo.Columns["Marca"].Visible = false;
                dgvBuscarArticulo.Columns["Categoria"].Visible = false;
                dgvBuscarArticulo.Columns["Descripcion"].Visible = false;
                dgvBuscarArticulo.Columns["ImagenURL"].Visible = false;//PARA OCULTAR LA URL 
                cargarImagen(buscaArticulo[0].ImagenURL);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Articulo Inexistente");
            }
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.Nombre = txtBuscarNombre.Text;
                buscaArticulo = negocio.buscarNombre(articulo);
                dgvBuscarArticulo.DataSource = buscaArticulo;
                dgvBuscarArticulo.Columns["Marca"].Visible = false;
                dgvBuscarArticulo.Columns["Categoria"].Visible = false;
                dgvBuscarArticulo.Columns["Descripcion"].Visible = false;
                dgvBuscarArticulo.Columns["ImagenURL"].Visible = false;//PARA OCULTAR LA URL 
                cargarImagen(buscaArticulo[0].ImagenURL);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Articulo Inexistente");
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxBuscarArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxBuscarArticulo.Load("https://i2.wp.com/learn.onemonth.com/wp-content/uploads/2017/08/1-10.png?w=845&ssl=1");
            }
        }
    }
}
