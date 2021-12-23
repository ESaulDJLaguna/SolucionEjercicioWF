using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolucionEjercicioWF.Logica;
using System.Data;
using System.Windows.Forms;

namespace SolucionEjercicioWF.Datos
{
    class DArticulos
    {
        public bool InsertarArticulo(LArticulos parametros)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("InsertarArticulo", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", parametros.codigo);
                cmd.Parameters.AddWithValue("@Descripcion", parametros.descripcion);
                cmd.Parameters.AddWithValue("@Precio", parametros.precio);
                cmd.Parameters.AddWithValue("@Imagen", parametros.imagen);
                cmd.Parameters.AddWithValue("@Stock", parametros.stock);
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

        public void ObtenerArticulosDeBD(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Articulos", CONEXIONMAESTRA.conectar);
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
        public void ObtenerInfoArticuloSeleccionado(ref DataTable dt, string codigo)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Articulos WHERE codigo = '"+codigo+"'", CONEXIONMAESTRA.conectar);
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
        public bool EliminarArticuloSeleccionado(ref DataTable dt, string codigo)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlDataAdapter da = new SqlDataAdapter("DELETE FROM Articulos WHERE codigo = '" + codigo + "'", CONEXIONMAESTRA.conectar);
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
        public bool EditarArticulo(LArticulos parametros)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("EditarArticulo", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", parametros.codigo);
                cmd.Parameters.AddWithValue("@Descripcion", parametros.descripcion);
                cmd.Parameters.AddWithValue("@Precio", parametros.precio);
                cmd.Parameters.AddWithValue("@Imagen", parametros.imagen);
                cmd.Parameters.AddWithValue("@Stock", parametros.stock);
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
    }
}
