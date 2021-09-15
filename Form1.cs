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


namespace TP_Hoffman_Caero
{
    public partial class frmAplicacion : Form
    {
        private List<Articulo> listaArticulo; //ES UN ATRIBUTO PRIVADO
        private List<Marca> listaMarca;
        private List<Categoria> listaCategoria;
        public frmAplicacion()
        {
            InitializeComponent();
        }

        private void frmAplicacion_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            cargarImagenArticulo(listaArticulo[0].ImagenURL);

            CategoriaNegocio negocio2 = new CategoriaNegocio();
            listaCategoria = negocio2.listar();
            dgvCategorias.DataSource = listaCategoria;

            MarcaNegocio negocio3 = new MarcaNegocio();
            listaMarca = negocio3.listar();
            dgvMarcas.DataSource = listaMarca;


        }

        private void cargarImagenArticulo(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }

            catch (Exception)
            {
                pbxArticulo.Load("https://i2.wp.com/learn.onemonth.com/wp-content/uploads/2017/08/1-10.png?w=845&ssl=1");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionados = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; //PARA SELECCION DE UN OBJETO EN UNA LISTA
            cargarImagenArticulo(seleccionados.ImagenURL);
        }
    }
}
