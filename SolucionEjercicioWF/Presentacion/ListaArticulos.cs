using SolucionEjercicioWF.Datos;
using SolucionEjercicioWF.Logica;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SolucionEjercicioWF.Presentacion
{
    public partial class ListaArticulos : UserControl
    {
        public ListaArticulos()
        {
            InitializeComponent();
        }

        bool imagenSeleccionada = false;

        private void BtnGuardarArticulo_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(TxtCodArticulo.Text))
            {
                if(!string.IsNullOrEmpty(TxtPrecioArticulo.Text))
                {
                    if(!string.IsNullOrEmpty(TxtStockArticulo.Text))
                    {
                        if(!string.IsNullOrEmpty(TxtDescrArticulo.Text))
                        {
                            if(imagenSeleccionada)
                            {
                                GuardaArticuloEnBD();
                            }
                            else
                            {
                                MessageBox.Show("Debe elegir una imagen.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("La descripción del artículo no puede estar vacío.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Stock no puede estar vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("El Precio del artículo no puede estar vacío.");
                }
            }
            else
            {
                MessageBox.Show("El Código del Artículo no puede estar vacío.");
            }
        }

        private void LimpiarArticulo()
        {
            TxtCodArticulo.Clear();
            TxtDescrArticulo.Clear();
            TxtPrecioArticulo.Clear();
            TxtStockArticulo.Clear();
            ImagenProducto.Image = Properties.Resources.foto__1_;
        }

        private void GuardaArticuloEnBD()
        {
            LArticulos parametros = new LArticulos();
            DArticulos funcion = new DArticulos();
            parametros.codigo = TxtCodArticulo.Text;
            parametros.descripcion = TxtDescrArticulo.Text;
            parametros.precio = Convert.ToDecimal(TxtPrecioArticulo.Text);
            parametros.stock = Convert.ToInt32(TxtStockArticulo.Text);
            MemoryStream ms = new MemoryStream();
            ImagenProducto.Image.Save(ms, ImagenProducto.Image.RawFormat);
            parametros.imagen = ms.GetBuffer();
            if(funcion.InsertarArticulo(parametros))
            {
                MessageBox.Show("El artículo se guardó correctamente.");
                LimpiarArticulo();
                PanelNewArticulo.Visible = false;
                //flowLayoutPanel1.Visible = true;
                timer1.Start();
            }
        }

        private void BtnAddArticulo_Click(object sender, EventArgs e)
        {
            LimpiarArticulo();
            TxtCodArticulo.Enabled = true;
            //flowLayoutPanel1.Visible = false;
            PanelNewArticulo.Visible = true;
            BtnGuardarArticulo.Visible = true;
            BtnEditarArticulo.Visible = false;
        }

        private void ImagenProducto_Click(object sender, EventArgs e)
        {
            openFileDlg.InitialDirectory = "";
            openFileDlg.Filter = "Imágenes|*.jpg;*.png";
            openFileDlg.FilterIndex = 2;
            openFileDlg.Title = "Cargador de imágenes";
            openFileDlg.FileName = "";
            if(openFileDlg.ShowDialog() == DialogResult.OK)
            {
                ImagenProducto.BackgroundImage = null;
                ImagenProducto.Image = new Bitmap(openFileDlg.FileName);
                imagenSeleccionada = true;
            }
            else
            {
                imagenSeleccionada = false;
            }
        }

        private void TxtPrecioArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bases.Decimales(TxtPrecioArticulo, e);
        }

        private void TxtStockArticulo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnCancelarArticulo_Click(object sender, EventArgs e)
        {
            LimpiarArticulo();
            PanelNewArticulo.Visible = false;
            //flowLayoutPanel1.Visible = true;
        }

        private void DibujarArticulos()
        {
            DataTable dt = new DataTable();
            DArticulos funcion = new DArticulos();
            funcion.ObtenerArticulosDeBD(ref dt);
            foreach(DataRow fila in dt.Rows)
            {
                Panel panel = new Panel();
                PictureBox imagen = new PictureBox();
                Label codigo = new Label();
                Label precio = new Label();
                Label stock = new Label();
                Label descripcion = new Label();
                Button editar = new Button();
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

                stock.Text = fila["stock"].ToString() + " pz";
                stock.Location = new Point(109, 60);

                descripcion.Text = fila["descripcion"].ToString();
                descripcion.Location = new Point(7, 113);
                descripcion.Size = new Size(186, 50);

                editar.Size = new Size(75, 23);
                editar.FlatStyle = FlatStyle.Flat;
                editar.Location = new Point(7, 172);
                editar.Text = "Editar";
                editar.BackColor = Color.Black;
                editar.TextAlign = ContentAlignment.MiddleCenter;
                editar.Tag = fila["codigo"].ToString();
                editar.Cursor = Cursors.Hand;
                editar.Click += EditarArticulo_Click;

                eliminar.Size = new Size(75, 23);
                eliminar.FlatStyle = FlatStyle.Flat;
                eliminar.Location = new Point(118, 172);
                eliminar.Text = "Eliminar";
                eliminar.BackColor = Color.Black;
                eliminar.TextAlign = ContentAlignment.MiddleCenter;
                eliminar.Tag = fila["codigo"].ToString();
                eliminar.Cursor = Cursors.Hand;
                eliminar.Click += EliminarArticulo_Click;

                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Size = new Size(200, 200);
                panel.Font = new Font("Microsoft Sans Serif", 8);
                panel.Controls.Add(imagen);
                panel.Controls.Add(codigo);
                panel.Controls.Add(precio);
                panel.Controls.Add(stock);
                panel.Controls.Add(descripcion);
                panel.Controls.Add(editar);
                panel.Controls.Add(eliminar);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void EliminarArticulo_Click(object sender, EventArgs e)
        {
            string codigoRecuperado = ((Button)sender).Tag.ToString();
            DataTable dt = new DataTable();
            DArticulos funcion = new DArticulos();
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar este artículo?", "Eliminación de artículo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                if (funcion.EliminarArticuloSeleccionado(ref dt, codigoRecuperado))
                {
                    MessageBox.Show("Artículo eliminado correctamente");
                    timer1.Start();
                }
            }
        }

        private void EditarArticulo_Click(object sender, EventArgs e)
        {
            string codigoRecuperado = ((Button)sender).Tag.ToString();
            DataTable dt = new DataTable();
            DArticulos funcion = new DArticulos();
            funcion.ObtenerInfoArticuloSeleccionado(ref dt, codigoRecuperado);
            foreach (DataRow item in dt.Rows)
            {
                byte[] bi = (Byte[])item["imagen"];
                MemoryStream ms = new MemoryStream(bi);
                ImagenProducto.Image = Image.FromStream(ms);
                TxtCodArticulo.Text = item["codigo"].ToString();
                TxtPrecioArticulo.Text = item["precio"].ToString();
                TxtStockArticulo.Text = item["stock"].ToString();
                TxtDescrArticulo.Text = item["descripcion"].ToString();
            }
            TxtCodArticulo.Enabled = false;
            PanelNewArticulo.Visible = true;
            BtnGuardarArticulo.Visible = false;
            BtnEditarArticulo.Visible = true;
            BtnEditarArticulo.Location = new Point(BtnGuardarArticulo.Location.X, BtnGuardarArticulo.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DibujarArticulos();
            timer1.Stop();
        }

        private void BtnEditarArticulo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCodArticulo.Text))
            {
                if (!string.IsNullOrEmpty(TxtPrecioArticulo.Text))
                {
                    if (!string.IsNullOrEmpty(TxtStockArticulo.Text))
                    {
                        if (!string.IsNullOrEmpty(TxtDescrArticulo.Text))
                        {
                            EditarArticuloEnBD();
                            LimpiarArticulo();
                            PanelNewArticulo.Visible = false;
                            //flowLayoutPanel1.Visible = true;
                            timer1.Start();

                        }
                        else
                        {
                            MessageBox.Show("La descripción del artículo no puede estar vacío.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Stock no puede estar vacío.");
                    }
                }
                else
                {
                    MessageBox.Show("El Precio del artículo no puede estar vacío.");
                }
            }
            else
            {
                MessageBox.Show("El Código del Artículo no puede estar vacío.");
            }
        }

        private void EditarArticuloEnBD()
        {
            LArticulos parametros = new LArticulos();
            DArticulos funcion = new DArticulos();
            parametros.codigo = TxtCodArticulo.Text;
            parametros.descripcion = TxtDescrArticulo.Text;
            parametros.precio = Convert.ToDecimal(TxtPrecioArticulo.Text);
            parametros.stock = Convert.ToInt32(TxtStockArticulo.Text);
            MemoryStream ms = new MemoryStream();
            ImagenProducto.Image.Save(ms, ImagenProducto.Image.RawFormat);
            parametros.imagen = ms.GetBuffer();
            if (funcion.EditarArticulo(parametros))
            {
                MessageBox.Show("El artículo se editó correctamente.");
            }
        }
    }
}
