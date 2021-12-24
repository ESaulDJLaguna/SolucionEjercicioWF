using SolucionEjercicioWF.Datos;
using SolucionEjercicioWF.Logica;
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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        public static int idClienteActual;

        private void Cliente_Load(object sender, EventArgs e)
        {
            string usuario = Login.userActual.Rows[0]["usuario"].ToString();
            idClienteActual = Convert.ToInt32(Login.userActual.Rows[0]["id_cliente"].ToString());
            LblBienvenida.Text = $"Bienvenido {usuario}";
            MuestraPanelCambiarContraseña();
        }

        private void MuestraPanelCambiarContraseña()
        {
            if (Login.userActual.Rows[0]["contraseña"].ToString() == "1")
            {
                PanelCambiaContraseña.Visible = true;
                PanelCambiaContraseña.Dock = DockStyle.Fill;
            }
            else
            {
                PanelCambiaContraseña.Visible = false;
                BtnArticulosCliente.Enabled = true;
                BtnCarrito.Enabled = true;
                BtnCerrarSesionCliente.Enabled = true;
            }
        }

        private void BtnActualizarPsswrd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtNewPssrd1.Text) && TxtNewPssrd1.Text.Length > 5)
            {
                if(!string.IsNullOrEmpty(TxtNewPssrd2.Text) && TxtNewPssrd2.Text.Length > 5)
                {
                    if(TxtNewPssrd1.Text == TxtNewPssrd2.Text)
                    {
                        EditaContraseñaEnBD();
                    }
                    else
                    {
                        MessageBox.Show("Las Contraseñas no coinciden");
                    }
                }
                else
                {
                    MessageBox.Show("La segunda contraseña es obligatoria y debe ser de al menos 6 caracteres");
                }
            }
            else
            {
                MessageBox.Show("La nueva contraseña es obligatoria y debe ser de al menos 6 caracteres");
            }
        }

        private void EditaContraseñaEnBD()
        {
            DClientes funcion = new DClientes();
            LClientes parametros = new LClientes();
            parametros.idCliente = Convert.ToInt32(Login.userActual.Rows[0]["id_cliente"]);
            parametros.nombre = Login.userActual.Rows[0]["nombre"].ToString();
            parametros.apellidos = Login.userActual.Rows[0]["apellidos"].ToString();
            parametros.direccion = Login.userActual.Rows[0]["direccion"].ToString();
            parametros.usuario = Login.userActual.Rows[0]["usuario"].ToString();
            parametros.contraseña = TxtNewPssrd1.Text;
            if (funcion.EditarCliente(parametros))
            {
                MessageBox.Show("Contraseña modificada correctamente");
                PanelCambiaContraseña.Visible = false;
                BtnArticulosCliente.Enabled = true;
                BtnCarrito.Enabled = true;
            }
        }

        private void BtnArticulosCliente_Click(object sender, EventArgs e)
        {
            PanelGeneral.Controls.Clear();
            ListaArticulosCliente control = new ListaArticulosCliente();
            control.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(control);
        }

        private void BtnCarrito_Click(object sender, EventArgs e)
        {
            PanelGeneral.Controls.Clear();
            VerCarritoCliente control = new VerCarritoCliente();
            control.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(control);
        }

        private void BtnCerrarSesionCliente_Click(object sender, EventArgs e)
        {
            Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }
    }
}
