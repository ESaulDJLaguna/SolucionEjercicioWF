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
    public partial class ListaTiendas : UserControl
    {
        public ListaTiendas()
        {
            InitializeComponent();
        }

        int idTienda;

        private void BtnAddTienda_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false, true, true, false);
        }

        private void VisibilidadPaneles(bool dgv, bool panelNCliente, bool btnGuardar = false, bool btnEdit = false)
        {
            LimpiarTienda();
            DgvListadoTiendas.Visible = dgv;
            PanelNewTienda.Visible = panelNCliente;
            BtnGuardarTienda.Visible = btnGuardar;
            BtnEditarTienda.Visible = btnEdit;
        }

        private void LimpiarTienda()
        {
            TxtSucursal.Clear();
            TxtDireccion.Clear();
        }

        private void BtnGuardarTienda_Click(object sender, EventArgs e)
        {
            if (ValidaInfoTienda())
            {
                GuardaTiendaEnBD();
            }
        }

        private bool ValidaInfoTienda()
        {
            if (!string.IsNullOrEmpty(TxtSucursal.Text))
            {
                if (!string.IsNullOrEmpty(TxtDireccion.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("La Dirección de la sucursal es requerida.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El nombre de la sucursal es obligatorio.");
                return false;
            }
        }

        private void GuardaTiendaEnBD()
        {
            LTiendas parametros = new LTiendas();
            DTiendas funcion = new DTiendas();
            parametros.sucursal = TxtSucursal.Text;
            parametros.direccion = TxtDireccion.Text;
            if (funcion.InsertarTienda(parametros))
            {
                MessageBox.Show("La tienda se guardó correctamente.");
                VisibilidadPaneles(true, false);
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarTiendas();
            timer1.Stop();
        }

        private void MostrarTiendas()
        {
            DataTable dt = new DataTable();
            DTiendas funcion = new DTiendas();
            funcion.ObtenerTiendas(ref dt);
            DgvListadoTiendas.DataSource = dt;
            Bases.DiseñoDtv(ref DgvListadoTiendas);
            DgvListadoTiendas.Columns["id_sucursal"].Visible = false;
        }

        private void BtnCancelarTienda_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(true, false);
        }

        private void DgvListadoTiendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CapturarIdTienda();
            if (e.ColumnIndex == DgvListadoTiendas.Columns["Editar"].Index)
            {
                VisibilidadPaneles(false, true, false, true);
                BtnEditarTienda.Location = new Point(BtnGuardarTienda.Location.X, BtnGuardarTienda.Location.Y);
                TxtSucursal.Text = DgvListadoTiendas.SelectedCells[3].Value.ToString();
                TxtDireccion.Text = DgvListadoTiendas.SelectedCells[4].Value.ToString();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar esta sucursal?", "Eliminación de Tienda", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    EliminarTiendaEnBD();
                }
            }
        }

        private void CapturarIdTienda()
        {
            idTienda = Convert.ToInt32(DgvListadoTiendas.SelectedCells[2].Value);
        }

        private void EliminarTiendaEnBD()
        {
            DTiendas funcion = new DTiendas();
            if (funcion.EliminarTienda(idTienda))
            {
                MessageBox.Show("La tienda se eliminó correctamente.");
                timer1.Start();
            }
        }

        private void BtnEditarTienda_Click(object sender, EventArgs e)
        {
            EditarInfoTienda();
            VisibilidadPaneles(true, false);
            timer1.Start();
        }

        private void EditarInfoTienda()
        {
            if (ValidaInfoTienda())
            {
                EditaTiendaEnBD();
            }
        }
        private void EditaTiendaEnBD()
        {
            LTiendas parametros = new LTiendas();
            DTiendas funcion = new DTiendas();
            parametros.idSucursal = idTienda;
            parametros.sucursal = TxtSucursal.Text;
            parametros.direccion = TxtDireccion.Text;
            if (funcion.EditarTienda(parametros))
            {
                MessageBox.Show("La tienda se editó correctamente.");
                VisibilidadPaneles(true, false);
            }
        }
    }
}
