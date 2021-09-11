using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Hoffman_Caero
{
    public partial class frmAplicacion : Form
    {
        public frmAplicacion()
        {
            InitializeComponent();
        }

        private void frmAplicacion_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            dgvMarcas.DataSource = negocio.listar();

            CategoriaNegocio negocio2 = new CategoriaNegocio();
            dgvCategorias.DataSource = negocio2.listar();

            ArticuloNegocio negocio3 = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio3.listar();
        }
    }
}
