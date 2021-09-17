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
            FrmAltaArticulo alta = new FrmAltaArticulo();
            alta.ShowDialog();
          
        }

        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            frmBuscarArticulo buscar = new frmBuscarArticulo();
            buscar.ShowDialog();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
           
        }
    }
}
