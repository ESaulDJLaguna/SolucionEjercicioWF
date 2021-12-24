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
    public partial class ListaClientes : UserControl
    {
        public ListaClientes()
        {
            InitializeComponent();
        }

        int idCliente;

        private void BtnAddCliente_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(false, true, true, false);
        }

        private void VisibilidadPaneles(bool dgv, bool panelNCliente, bool btnGuardar = false, bool btnEdit = false)
        {
            LimpiarCliente();
            DgvListadoClientes.Visible = dgv;
            PanelNewCliente.Visible = panelNCliente;
            BtnGuardarCliente.Visible = btnGuardar;
            BtnEditarCliente.Visible = btnEdit;
        }

        private void LimpiarCliente()
        {
            TxtUsr.Clear();
            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtDireccion.Clear();
        }

        private void BtnGuardarCliente_Click(object sender, EventArgs e)
        {
            if(ValidaInfoCliente())
            {
                GuardaClienteEnBD();
            }    
        }

        private bool ValidaInfoCliente()
        {
            if (!string.IsNullOrEmpty(TxtUsr.Text))
            {
                if (!string.IsNullOrEmpty(TxtNombres.Text))
                {
                    if (!string.IsNullOrEmpty(TxtApellidos.Text))
                    {
                        if (!string.IsNullOrEmpty(TxtDireccion.Text))
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("La dirección del usuario es requerida.");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Los apellidos del usuario son obligatorios.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("El nombre del cliente es requerido.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El nombre de usuario es necesario.");
                return false;
            }
        }

        private void GuardaClienteEnBD()
        {
            LClientes parametros = new LClientes();
            DClientes funcion = new DClientes();
            parametros.nombre = TxtNombres.Text;
            parametros.apellidos = TxtApellidos.Text;
            parametros.direccion = TxtDireccion.Text;
            parametros.usuario = TxtUsr.Text;
            parametros.contraseña = "1";
            if (funcion.InsertarCliente(parametros))
            {
                MessageBox.Show("El cliente se guardó correctamente.");
                VisibilidadPaneles(true, false);
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarClientes();
            timer1.Stop();
        }

        private void MostrarClientes()
        {
            DataTable dt = new DataTable();
            DClientes funcion = new DClientes();
            funcion.ObtenerClientes(ref dt);
            DgvListadoClientes.DataSource = dt;
            Bases.DiseñoDtv(ref DgvListadoClientes);
            DgvListadoClientes.Columns[2].Visible = false;
            DgvListadoClientes.Columns[7].Visible = false;
        }

        private void BtnCancelarCliente_Click(object sender, EventArgs e)
        {
            VisibilidadPaneles(true, false);
        }

        private void DgvListadoClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CapturarIdCliente();
            if (e.ColumnIndex == DgvListadoClientes.Columns["Editar"].Index)
            {
                VisibilidadPaneles(false, true, false, true);
                BtnEditarCliente.Location = new Point(BtnGuardarCliente.Location.X, BtnGuardarCliente.Location.Y);
                TxtNombres.Text = DgvListadoClientes.SelectedCells[3].Value.ToString();
                TxtApellidos.Text = DgvListadoClientes.SelectedCells[4].Value.ToString();
                TxtDireccion.Text = DgvListadoClientes.SelectedCells[5].Value.ToString();
                TxtUsr.Text = DgvListadoClientes.SelectedCells[6].Value.ToString();
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar este cliente?", "Eliminación de cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    EliminarClienteEnBD();
                }
            }
        }

        private void CapturarIdCliente()
        {
            idCliente = Convert.ToInt32(DgvListadoClientes.SelectedCells[2].Value);
        }

        private void EliminarClienteEnBD()
        {
            DClientes funcion = new DClientes();
            if (funcion.EliminarCliente(idCliente))
            {
                MessageBox.Show("El cliente se eliminó correctamente.");
                timer1.Start();
            }
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            EditarInfoCliente();
            VisibilidadPaneles(true,false);
            timer1.Start();
        }

        private void EditarInfoCliente()
        {
            if(ValidaInfoCliente())
            {
                EditaClienteEnBD();
            }
        }
        private void EditaClienteEnBD()
        {
            LClientes parametros = new LClientes();
            DClientes funcion = new DClientes();
            parametros.idCliente = idCliente;
            parametros.nombre = TxtNombres.Text;
            parametros.apellidos = TxtApellidos.Text;
            parametros.direccion = TxtDireccion.Text;
            parametros.usuario = TxtUsr.Text;
            if (funcion.EditarCliente(parametros))
            {
                MessageBox.Show("El cliente se editó correctamente.");
                VisibilidadPaneles(true, false);
            }
        }
    }
}
