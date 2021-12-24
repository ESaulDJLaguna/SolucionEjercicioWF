using System;
using System.Windows.Forms;

namespace SolucionEjercicioWF.Presentacion
{
    public partial class Bodega : Form
    {
        public Bodega()
        {
            InitializeComponent();
        }
        
        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            PanelGeneral.Controls.Clear();
            ListaArticulos control = new ListaArticulos();
            control.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(control);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            PanelGeneral.Controls.Clear();
            ListaClientes control = new ListaClientes();
            control.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(control);
        }

        private void BtnTiendas_Click(object sender, EventArgs e)
        {
            PanelGeneral.Controls.Clear();
            ListaTiendas control = new ListaTiendas();
            control.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(control);
        }

        private void BtnCerrarSesionBodega_Click(object sender, EventArgs e)
        {
            Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }
    }
}
