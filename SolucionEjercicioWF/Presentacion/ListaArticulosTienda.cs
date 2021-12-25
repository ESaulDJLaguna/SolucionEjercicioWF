using SolucionEjercicioWF.Datos;
using SolucionEjercicioWF.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionEjercicioWF.Presentacion
{
    public partial class ListaArticulosTienda : UserControl
    {
        public ListaArticulosTienda()
        {
            InitializeComponent();
        }

        int cantidadArticulosSeleccionados;
        int articulosTotal;
        public static List<Carrito> carrito = new List<Carrito>();

        private void DibujarArticulos()
        {
            DataTable dt = new DataTable();
            DArticulos funcion = new DArticulos();
            funcion.ObtenerArticulosDeBD(ref dt);
            foreach (DataRow fila in dt.Rows)
            {
                Panel panel = new Panel();
                PictureBox imagen = new PictureBox();
                Label codigo = new Label();
                Label precio = new Label();
                Label stock = new Label();
                Label descripcion = new Label();
                Button add = new Button();
                TextBox cantidad = new TextBox();
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

                stock.Text = fila["stock"].ToString() + " pz";
                stock.Location = new Point(109, 60);

                descripcion.Text = fila["descripcion"].ToString();
                descripcion.Location = new Point(7, 113);
                descripcion.Size = new Size(186, 50);

                add.Size = new Size(75, 23);
                add.FlatStyle = FlatStyle.Flat;
                add.Location = new Point(7, 172);
                add.Text = "Añadir";
                add.BackColor = Color.Black;
                add.TextAlign = ContentAlignment.MiddleCenter;
                add.Tag = fila["codigo"].ToString();
                add.Cursor = Cursors.Hand;
                add.Click += Add_Click;

                cantidad.Size = new Size(75, 23);
                cantidad.Location = new Point(118, 172);
                cantidad.Text = "0";
                cantidad.KeyPress += Cantidad_KeyPress;
                cantidad.TextChanged += Cantidad_TextChanged;

                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Size = new Size(200, 200);
                panel.Font = new Font("Microsoft Sans Serif", 8);
                panel.Controls.Add(imagen);
                panel.Controls.Add(codigo);
                panel.Controls.Add(precio);
                panel.Controls.Add(stock);
                panel.Controls.Add(descripcion);
                panel.Controls.Add(add);
                panel.Controls.Add(cantidad);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {
            cantidadArticulosSeleccionados = Convert.ToInt32(((TextBox)sender).Text);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            string codigoRecuperado = ((Button)sender).Tag.ToString();
            int articulosAnteriores = 0;

            if (cantidadArticulosSeleccionados == 0)
            {
                MessageBox.Show("Elige al menos un artículo de este tipo");
            }
            else
            {
                //TODO... AGREGAR AL CARRITO DE COMPRAS
                articulosTotal = ObtenArticulosTotal(codigoRecuperado);
                articulosAnteriores += sumaSiYaExisteArticuloEnCarrito(codigoRecuperado);
                //MessageBox.Show($"Agregados antes: {cantidadArticulosSeleccionados}");
                if (cantidadArticulosSeleccionados + articulosAnteriores > articulosTotal)
                {
                    MessageBox.Show($"No puedes elegir más de {articulosTotal} artículos");
                }
                else
                {
                    AgregaAlCarrito(codigoRecuperado, cantidadArticulosSeleccionados);
                    //EditaStockArticulo(codigoRecuperado, nuevoStock);
                    //RecorreCarrito();
                    //MessageBox.Show($"Nuevo Stock: {nuevoStock}");
                }
                timer1.Start();
            }
        }

        private int sumaSiYaExisteArticuloEnCarrito(string codigo)
        {
            for (int i = 0; i < carrito.Count; i++)
            {
                if (carrito[i].codigoArticulo == codigo)
                {
                    return carrito[i].cantidad;
                }
            }
            return 0;
        }

        private void AgregaAlCarrito(string codigo, int cantidad)
        {
            int articuloExistente = 0;
            for (int i = 0; i < carrito.Count; i++)
            {
                if (carrito[i].codigoArticulo == codigo)
                {
                    carrito[i].cantidad += cantidad;
                    articuloExistente++;
                    //MessageBox.Show($"Incrementa viejo");

                }
            }
            if (articuloExistente == 0)
            {
                carrito.Add(new Carrito(codigo, cantidad));
                //MessageBox.Show($"Agregado nuevo");
            }
            MessageBox.Show("Producto Agregado correctamente.");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            cantidadArticulosSeleccionados = 0;
            articulosTotal = 0;
            flowLayoutPanel1.Controls.Clear();
            DibujarArticulos();
            timer1.Stop();
        }


        private int ObtenArticulosTotal(string codArticulo)
        {
            DataTable dt = new DataTable();
            DArticulos funcion = new DArticulos();
            funcion.ObtenerInfoArticuloSeleccionado(ref dt, codArticulo);
            return Convert.ToInt32(dt.Rows[0]["stock"].ToString());
        }
    }
}
