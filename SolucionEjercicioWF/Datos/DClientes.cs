using SolucionEjercicioWF.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionEjercicioWF.Datos
{
    class DClientes
    {
        public bool InsertarCliente(LClientes parametros)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("InsertarCliente", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.nombre);
                cmd.Parameters.AddWithValue("@Apellidos", parametros.apellidos);
                cmd.Parameters.AddWithValue("@Direccion", parametros.direccion);
                cmd.Parameters.AddWithValue("@Usuario", parametros.usuario);
                cmd.Parameters.AddWithValue("@Contraseña", parametros.contraseña);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }

        public void ObtenerClientes(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }

        public bool EditarCliente(LClientes parametros)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("EditarCliente", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", parametros.idCliente);
                cmd.Parameters.AddWithValue("@Nombre", parametros.nombre);
                cmd.Parameters.AddWithValue("@Apellidos", parametros.apellidos);
                cmd.Parameters.AddWithValue("@Direccion", parametros.direccion);
                cmd.Parameters.AddWithValue("@Usuario", parametros.usuario);
                cmd.Parameters.AddWithValue("@Contraseña", parametros.contraseña);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }

        public bool EliminarCliente(int idCliente)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("DELETE Clientes WHERE id_cliente = '"+idCliente +"'", CONEXIONMAESTRA.conectar);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }

        public bool BuscarSiClienteExiste(ref DataTable dt, string user)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes WHERE usuario = '" + user + "'", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }
    }
}
