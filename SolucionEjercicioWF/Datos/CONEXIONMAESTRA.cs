using System;
using System.Data;
using System.Data.SqlClient;


namespace SolucionEjercicioWF.Datos
{
    public class CONEXIONMAESTRA
    {
        public static string conexion =
            "Data source=.;" +
            "Initial Catalog=SolucionEjercicioWF;" +
            "Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void Abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }

        public static void Cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
