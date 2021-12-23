
namespace SolucionEjercicioWF.Presentacion
{
    partial class ListaArticulos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAddArticulo = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelNewArticulo = new System.Windows.Forms.Panel();
            this.BtnEditarArticulo = new System.Windows.Forms.Button();
            this.BtnCancelarArticulo = new System.Windows.Forms.Button();
            this.BtnGuardarArticulo = new System.Windows.Forms.Button();
            this.TxtDescrArticulo = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtStockArticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPrecioArticulo = new System.Windows.Forms.TextBox();
            this.ImagenProducto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCodArticulo = new System.Windows.Forms.TextBox();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelNewArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenProducto)).BeginInit();
            this.PanelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 88);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnAddArticulo);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1055, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 88);
            this.panel2.TabIndex = 1;
            // 
            // BtnAddArticulo
            // 
            this.BtnAddArticulo.BackgroundImage = global::SolucionEjercicioWF.Properties.Resources.agregar_archivo;
            this.BtnAddArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddArticulo.FlatAppearance.BorderSize = 0;
            this.BtnAddArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddArticulo.Location = new System.Drawing.Point(0, 5);
            this.BtnAddArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddArticulo.Name = "BtnAddArticulo";
            this.BtnAddArticulo.Size = new System.Drawing.Size(113, 78);
            this.BtnAddArticulo.TabIndex = 3;
            this.BtnAddArticulo.UseVisualStyleBackColor = true;
            this.BtnAddArticulo.Click += new System.EventHandler(this.BtnAddArticulo_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 83);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(113, 5);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(113, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 83);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 5);
            this.panel3.TabIndex = 0;
            // 
            // PanelNewArticulo
            // 
            this.PanelNewArticulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelNewArticulo.Controls.Add(this.BtnEditarArticulo);
            this.PanelNewArticulo.Controls.Add(this.BtnCancelarArticulo);
            this.PanelNewArticulo.Controls.Add(this.BtnGuardarArticulo);
            this.PanelNewArticulo.Controls.Add(this.TxtDescrArticulo);
            this.PanelNewArticulo.Controls.Add(this.label4);
            this.PanelNewArticulo.Controls.Add(this.label3);
            this.PanelNewArticulo.Controls.Add(this.TxtStockArticulo);
            this.PanelNewArticulo.Controls.Add(this.label2);
            this.PanelNewArticulo.Controls.Add(this.TxtPrecioArticulo);
            this.PanelNewArticulo.Controls.Add(this.ImagenProducto);
            this.PanelNewArticulo.Controls.Add(this.label1);
            this.PanelNewArticulo.Controls.Add(this.TxtCodArticulo);
            this.PanelNewArticulo.Location = new System.Drawing.Point(308, 88);
            this.PanelNewArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelNewArticulo.Name = "PanelNewArticulo";
            this.PanelNewArticulo.Size = new System.Drawing.Size(557, 324);
            this.PanelNewArticulo.TabIndex = 1;
            this.PanelNewArticulo.Visible = false;
            // 
            // BtnEditarArticulo
            // 
            this.BtnEditarArticulo.BackColor = System.Drawing.Color.Black;
            this.BtnEditarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarArticulo.FlatAppearance.BorderSize = 0;
            this.BtnEditarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarArticulo.Location = new System.Drawing.Point(209, 253);
            this.BtnEditarArticulo.Name = "BtnEditarArticulo";
            this.BtnEditarArticulo.Size = new System.Drawing.Size(137, 52);
            this.BtnEditarArticulo.TabIndex = 13;
            this.BtnEditarArticulo.Text = "Editar";
            this.BtnEditarArticulo.UseVisualStyleBackColor = false;
            this.BtnEditarArticulo.Click += new System.EventHandler(this.BtnEditarArticulo_Click);
            // 
            // BtnCancelarArticulo
            // 
            this.BtnCancelarArticulo.BackColor = System.Drawing.Color.Black;
            this.BtnCancelarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarArticulo.FlatAppearance.BorderSize = 0;
            this.BtnCancelarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarArticulo.Location = new System.Drawing.Point(369, 253);
            this.BtnCancelarArticulo.Name = "BtnCancelarArticulo";
            this.BtnCancelarArticulo.Size = new System.Drawing.Size(137, 52);
            this.BtnCancelarArticulo.TabIndex = 12;
            this.BtnCancelarArticulo.Text = "Cancelar";
            this.BtnCancelarArticulo.UseVisualStyleBackColor = false;
            this.BtnCancelarArticulo.Click += new System.EventHandler(this.BtnCancelarArticulo_Click);
            // 
            // BtnGuardarArticulo
            // 
            this.BtnGuardarArticulo.BackColor = System.Drawing.Color.Black;
            this.BtnGuardarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarArticulo.FlatAppearance.BorderSize = 0;
            this.BtnGuardarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarArticulo.Location = new System.Drawing.Point(46, 253);
            this.BtnGuardarArticulo.Name = "BtnGuardarArticulo";
            this.BtnGuardarArticulo.Size = new System.Drawing.Size(137, 52);
            this.BtnGuardarArticulo.TabIndex = 10;
            this.BtnGuardarArticulo.Text = "Guardar";
            this.BtnGuardarArticulo.UseVisualStyleBackColor = false;
            this.BtnGuardarArticulo.Click += new System.EventHandler(this.BtnGuardarArticulo_Click);
            // 
            // TxtDescrArticulo
            // 
            this.TxtDescrArticulo.Location = new System.Drawing.Point(288, 133);
            this.TxtDescrArticulo.Name = "TxtDescrArticulo";
            this.TxtDescrArticulo.Size = new System.Drawing.Size(249, 95);
            this.TxtDescrArticulo.TabIndex = 9;
            this.TxtDescrArticulo.Text = "";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(178, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(178, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock:";
            // 
            // TxtStockArticulo
            // 
            this.TxtStockArticulo.Location = new System.Drawing.Point(288, 92);
            this.TxtStockArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtStockArticulo.Name = "TxtStockArticulo";
            this.TxtStockArticulo.Size = new System.Drawing.Size(84, 26);
            this.TxtStockArticulo.TabIndex = 5;
            this.TxtStockArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockArticulo_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(178, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio:";
            // 
            // TxtPrecioArticulo
            // 
            this.TxtPrecioArticulo.Location = new System.Drawing.Point(288, 53);
            this.TxtPrecioArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPrecioArticulo.Name = "TxtPrecioArticulo";
            this.TxtPrecioArticulo.Size = new System.Drawing.Size(139, 26);
            this.TxtPrecioArticulo.TabIndex = 3;
            this.TxtPrecioArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioArticulo_KeyPress);
            // 
            // ImagenProducto
            // 
            this.ImagenProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImagenProducto.Image = global::SolucionEjercicioWF.Properties.Resources.foto__1_;
            this.ImagenProducto.Location = new System.Drawing.Point(21, 13);
            this.ImagenProducto.Name = "ImagenProducto";
            this.ImagenProducto.Size = new System.Drawing.Size(151, 215);
            this.ImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagenProducto.TabIndex = 2;
            this.ImagenProducto.TabStop = false;
            this.ImagenProducto.Click += new System.EventHandler(this.ImagenProducto_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(178, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // TxtCodArticulo
            // 
            this.TxtCodArticulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodArticulo.Location = new System.Drawing.Point(288, 13);
            this.TxtCodArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodArticulo.Name = "TxtCodArticulo";
            this.TxtCodArticulo.Size = new System.Drawing.Size(183, 26);
            this.TxtCodArticulo.TabIndex = 0;
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Controls.Add(this.PanelNewArticulo);
            this.PanelGeneral.Controls.Add(this.flowLayoutPanel1);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 88);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(1173, 500);
            this.PanelGeneral.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1173, 500);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListaArticulos";
            this.Size = new System.Drawing.Size(1173, 588);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelNewArticulo.ResumeLayout(false);
            this.PanelNewArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenProducto)).EndInit();
            this.PanelGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAddArticulo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelNewArticulo;
        private System.Windows.Forms.TextBox TxtCodArticulo;
        private System.Windows.Forms.PictureBox ImagenProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGuardarArticulo;
        private System.Windows.Forms.RichTextBox TxtDescrArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtStockArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPrecioArticulo;
        private System.Windows.Forms.Button BtnCancelarArticulo;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnEditarArticulo;
        private System.Windows.Forms.Timer timer1;
    }
}
