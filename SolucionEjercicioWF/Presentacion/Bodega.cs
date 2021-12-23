using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolucionEjercicioWF.Presentacion;

namespace SolucionEjercicioWF
{
    public partial class Form1 : Form
    {
        public Form1()
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
    }
}
