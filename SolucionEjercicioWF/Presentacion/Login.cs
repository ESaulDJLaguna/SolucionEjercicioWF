using SolucionEjercicioWF.Datos;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static DataTable userActual = new DataTable();
        public static DataTable tiendaActual = new DataTable();

        private void BtnBodega_Click(object sender, EventArgs e)
        {
            Dispose();
            Bodega frm = new Bodega();
            frm.ShowDialog();
        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            LimpiarTxtBox();
            VisibilidadPaneles(false, true, true, false);
            PanelLoginUsr.Dock = DockStyle.Fill;
            BtnVolver.BringToFront();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            LimpiarTxtBox();
            VisibilidadPaneles(true, false, false, false);
        }

        private void VisibilidadPaneles(bool panelBtns, bool panelLogUsr, bool btnVolver, bool panelLogSuc)
        {
            PanelBotones.Visible = panelBtns;
            PanelLoginUsr.Visible = panelLogUsr;
            BtnVolver.Visible = btnVolver;
            PanelLoginSucursal.Visible = panelLogSuc;
        }

        private void LimpiarTxtBox()
        {
            TxtUser.Clear();
            TxtContraseña.Clear();
            CbxSucursales.Text = "";
        }

        private void BtnIniciarSesionUsr_Click(object sender, EventArgs e)
        {
            if(ComprobarDatosInicioSesion())
            {
                DClientes funcion = new DClientes();
                userActual.Clear();
                funcion.BuscarSiClienteExiste(ref userActual, TxtUser.Text);
                if(UsuarioExiste())
                {
                    string passwrd = (userActual.Rows[0]["contraseña"].ToString());
                    if(passwrd == TxtContraseña.Text)
                    {
                        LimpiarTxtBox();
                        Dispose();
                        Cliente frm = new Cliente();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña NO es correcta");
                    }
                }
                else
                {
                    MessageBox.Show("Este usuario no está registrado");
                }
            }
        }
        private bool UsuarioExiste()
        {
            if (userActual.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ComprobarDatosInicioSesion()
        {
            if(!string.IsNullOrEmpty(TxtUser.Text))
            {
                if(!string.IsNullOrEmpty(TxtContraseña.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("La contraseña es obligatoria.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario es obligatorio.");
                return false;
            }
        }

        private void BtnSucursal_Click(object sender, EventArgs e)
        {
            LimpiarTxtBox();
            VisibilidadPaneles(false, false, true, true);
            PanelLoginSucursal.Dock = DockStyle.Fill;
            BtnVolver.BringToFront();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DTiendas funcion = new DTiendas();
            tiendaActual.Clear();
            funcion.ObtenerTiendas(ref tiendaActual);
            for (int i = 0; i < tiendaActual.Rows.Count; i++)
            {
                CbxSucursales.Items.Add(tiendaActual.Rows[i]["sucursal"]);
            }
        }

        private void BtnAccederTienda_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(CbxSucursales.Text))
            {
                LimpiarTxtBox();
                Dispose();
                Tienda frm = new Tienda();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Elige alguna de las tiendas");
            }
        }
    }
}
