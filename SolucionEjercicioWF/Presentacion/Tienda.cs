using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionEjercicioWF.Presentacion
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
        }

        public static int idSucursal;
        public static string nombreTienda;

        private void Tienda_Load(object sender, EventArgs e)
        {
            idSucursal = Convert.ToInt32(Login.tiendaActual.Rows[0]["id_sucursal"].ToString());
            nombreTienda = Login.tiendaActual.Rows[0]["sucursal"].ToString();
            LblSucursal.Text = $"Administración para la sucursal {nombreTienda}";
        }

        private void BtnArticulosTienda_Click(object sender, EventArgs e)
        {
            PanelGeneral.Controls.Clear();
            ListaArticulosTienda control = new ListaArticulosTienda();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            PanelGeneral.Controls.Add(control);
        }

        private void BtnCerrarSesionTienda_Click(object sender, EventArgs e)
        {
            Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void BtnPedirABodega_Click(object sender, EventArgs e)
        {
            PanelGeneral.Controls.Clear();
            VerCarritoTienda control = new VerCarritoTienda();
            control.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(control);
        }
    }
}
