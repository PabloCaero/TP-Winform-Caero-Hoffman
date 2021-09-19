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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

      private void btnListarArt_Click(object sender, EventArgs e)
      {
          frmListarArticulos art = new frmListarArticulos();
           art.ShowDialog();
        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
          
        }

        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            frmBuscarArticulo buscar = new frmBuscarArticulo();
            buscar.ShowDialog();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            frmModificarArticulo modificar = new frmModificarArticulo();
            modificar.ShowDialog();
        }

        private void btnEliminarArt_Click(object sender, EventArgs e)
        {
            frmEliminarArticulo eliminar = new frmEliminarArticulo();
            eliminar.ShowDialog();
        }

        private void btnVerDetalleArt_Click(object sender, EventArgs e)
        {
            FrmDetalleDeArticulo detalle = new FrmDetalleDeArticulo();
            detalle.ShowDialog();
        }
    }
}
