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
    public partial class FrmDetalleDeArticulo : Form
    {
        private List<Articulo> listarDetalle;
        public FrmDetalleDeArticulo()
        {
            InitializeComponent();
        }

        private void FrmDetalleDeArticulo_Load_1(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listarDetalle = negocio.listar();
            dgvDetalleArticulo.DataSource = listarDetalle;
        }
    }
}