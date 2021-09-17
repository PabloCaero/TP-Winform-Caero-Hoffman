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
    public partial class frmModificarArticuloSeleccionado : Form
    {
        //EL ATRIBUTO ARTICULO INICIALIZA EN NULO
        //PASAJE DE PARAMETRO ENTRE VENTANAS
        private Articulo articulo = null;
        public frmModificarArticuloSeleccionado(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                //IMPORTANTE PARA MODIFICAR
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDesc.Text;
                articulo.ImagenURL = txtUrlImg.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

               
                negocio.modificar(articulo);
                MessageBox.Show("Modificado correctamente");
                
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmModificarArticuloSeleccionado_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcanegocio = new MarcaNegocio();
            CategoriaNegocio categorianegocio = new CategoriaNegocio();

            try
            {
                //MODIFICACION CON COMBO BOX
                cboMarca.DataSource = marcanegocio.listar();
                cboMarca.ValueMember = "IDMarca";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categorianegocio.listar();
                cboCategoria.ValueMember = "IDCategoria";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    //CON ESTO PRESELECCIONA
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDesc.Text = articulo.Descripcion;
                    txtUrlImg.Text = articulo.ImagenURL;
                    txtPrecio.Text = articulo.Precio.ToString();
                    

                    //MANEJO CON COMBO BOX MODIFICAR
                    cboMarca.SelectedValue = articulo.Marca.IDMarca;
                    cboCategoria.SelectedValue = articulo.Categoria.IDCategoria;
                    cargarImagen(articulo.ImagenURL);
                }
            }
            catch (Exception ex)
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
