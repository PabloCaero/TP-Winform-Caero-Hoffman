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
    public partial class FrmAltaArticulo : Form
    {
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo arti = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                arti.Codigo = txtCodigo.Text;
                arti.Nombre = txtNombre.Text;
                arti.Descripcion = txtDesc.Text;
                arti.ImagenURL = txtUrlImg.Text;
                arti.Marca =(Marca)cboMarca.SelectedItem;
                arti.Categoria = (Categoria)cboCategoria.SelectedItem;


                negocio.agregar(arti);
                MessageBox.Show("Agregado correctamente");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       private void FrmAltaArticulo_Load(object sender, EventArgs e)
       {
            MarcaNegocio marcanegocio = new MarcaNegocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcanegocio.listar();
                cboCategoria.DataSource = categorianegocio.listar();

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
       }

        private void txtUrlImg_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImg.Text);
        }
        private void cargarImagen(string imagen)
        {

            try
            {
                pictureBoxURL.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxURL.Load("https://i2.wp.com/learn.onemonth.com/wp-content/uploads/2017/08/1-10.png?w=845&ssl=1");
            }

        }
    }
}
