using SolucionEjercicioWF.Datos;
using SolucionEjercicioWF.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionEjercicioWF.Presentacion
{
    public partial class VerCarritoTienda : UserControl
    {
        public VerCarritoTienda()
        {
            InitializeComponent();
        }

        List<Carrito> c = ListaArticulosTienda.carrito;
        decimal totalPagar = 0;
        int idSucursal = Tienda.idSucursal;

        private void DibujarCarrito()
        {
            DataTable dt = new DataTable();
            DArticulos funcion = new DArticulos();
            funcion.ObtenerArticulosDeBD(ref dt);

            foreach (DataRow fila in dt.Rows)
            {
                foreach (Carrito producto in c)
                {
                    if (fila["codigo"].ToString() == producto.codigoArticulo)
                    {
                        Panel panel = new Panel();
                        PictureBox imagen = new PictureBox();
                        Label codigo = new Label();
                        Label precio = new Label();
                        Label cantidad = new Label();
                        Button eliminar = new Button();
                        byte[] bi = (Byte[])fila["imagen"];
                        MemoryStream ms = new MemoryStream(bi);

                        imagen.Image = Image.FromStream(ms);
                        imagen.SizeMode = PictureBoxSizeMode.Zoom;
                        imagen.Size = new Size(100, 100);
                        imagen.Location = new Point(3, 5);

                        codigo.Text = fila["codigo"].ToString();
                        codigo.Location = new Point(109, 5);

                        precio.Text = "$" + fila["precio"].ToString();
                        precio.Location = new Point(109, 36);

                        cantidad.Text = $"Agregados: {producto.cantidad.ToString()}";
                        cantidad.Location = new Point(109, 60);

                        decimal precioProductoActual = Convert.ToDecimal(fila["precio"].ToString());
                        int cantidadProductosActual = producto.cantidad;
                        totalPagar += (precioProductoActual * cantidadProductosActual);

                        eliminar.Size = new Size(75, 23);
                        eliminar.FlatStyle = FlatStyle.Flat;
                        eliminar.Location = new Point(62, 115);
                        eliminar.Text = "Eliminar";
                        eliminar.BackColor = Color.Black;
                        eliminar.TextAlign = ContentAlignment.MiddleCenter;
                        eliminar.Tag = fila["codigo"].ToString();
                        eliminar.Cursor = Cursors.Hand;
                        eliminar.Click += Eliminar_Click;


                        panel.BorderStyle = BorderStyle.FixedSingle;
                        panel.Size = new Size(250, 150);
                        panel.Font = new Font("Microsoft Sans Serif", 8);
                        panel.Controls.Add(imagen);
                        panel.Controls.Add(codigo);
                        panel.Controls.Add(precio);
                        panel.Controls.Add(cantidad);
                        panel.Controls.Add(eliminar);

                        flowLayoutPanel1.Controls.Add(panel);
                    }
                }
                LblTotalPagar.Text = totalPagar.ToString();
            }
            LblTotalPagar.Text = totalPagar.ToString();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string productoEliminar = ((Button)sender).Tag.ToString();
            Carrito eliminar = null;

            foreach (Carrito producto in c)
            {
                if (producto.codigoArticulo == productoEliminar)
                {
                    eliminar = producto;
                    decimal precio = ObtenerPrecioArticuloActua(producto.codigoArticulo);
                    decimal descontar = producto.cantidad * precio;
                    totalPagar -= descontar;
                }
            }
            c.Remove(eliminar);
            timer1.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            totalPagar = 0;
            DibujarCarrito();
            timer1.Stop();
        }

        private void BtnPagar_Click_1(object sender, EventArgs e)
        {
            if(totalPagar != 0)
            {
                int articulosTotal;
                foreach (Carrito item in c)
                {
                    GuardaCompraEnBD(item.codigoArticulo, idSucursal, item.cantidad);
                    articulosTotal = ObtenArticulosTotal(item.codigoArticulo);
                    ActualizaStockEnBD(item.codigoArticulo, articulosTotal - item.cantidad);
                }
                MessageBox.Show("Pago Exitoso");
                c.Clear();
                timer1.Start();
            }
        }

        private void GuardaCompraEnBD(string codArticulo, int idSucursal, int cantidad)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand("HacerPedidoABodega", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idArticulo", codArticulo);
                cmd.Parameters.AddWithValue("@idTienda", idSucursal);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }

        private int ObtenArticulosTotal(string codArticulo)
        {
            DataTable dt = new DataTable();
            DArticulos funcion = new DArticulos();
            funcion.ObtenerInfoArticuloSeleccionado(ref dt, codArticulo);
            return Convert.ToInt32(dt.Rows[0]["stock"].ToString());
        }

        private decimal ObtenerPrecioArticuloActua(string codArticulo)
        {
            DataTable dt = new DataTable();
            DArticulos funcion = new DArticulos();
            funcion.ObtenerInfoArticuloSeleccionado(ref dt, codArticulo);
            return Convert.ToDecimal(dt.Rows[0]["precio"].ToString());
        }

        private void ActualizaStockEnBD(string codArticulo, int nuevoStock)
        {
            try
            {
                CONEXIONMAESTRA.Abrir();
                SqlCommand cmd = new SqlCommand($"UPDATE Articulos SET stock = {nuevoStock} WHERE codigo = '{codArticulo}'", CONEXIONMAESTRA.conectar);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }
    }
}
