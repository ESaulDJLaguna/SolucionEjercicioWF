
namespace SolucionEjercicioWF.Presentacion
{
    partial class Bodega
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bodega));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnTiendas = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnArticulos = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1190, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "BODEGA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnTiendas);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.BtnClientes);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.BtnArticulos);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 470);
            this.panel2.TabIndex = 1;
            // 
            // BtnTiendas
            // 
            this.BtnTiendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTiendas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTiendas.FlatAppearance.BorderSize = 0;
            this.BtnTiendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTiendas.Image = global::SolucionEjercicioWF.Properties.Resources.tienda;
            this.BtnTiendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTiendas.Location = new System.Drawing.Point(10, 182);
            this.BtnTiendas.Name = "BtnTiendas";
            this.BtnTiendas.Size = new System.Drawing.Size(226, 76);
            this.BtnTiendas.TabIndex = 6;
            this.BtnTiendas.Text = "Lista de Tiendas";
            this.BtnTiendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTiendas.UseVisualStyleBackColor = true;
            this.BtnTiendas.Click += new System.EventHandler(this.BtnTiendas_Click);
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(10, 172);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(226, 10);
            this.panel13.TabIndex = 5;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Image = global::SolucionEjercicioWF.Properties.Resources.objetivo;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(10, 96);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(226, 76);
            this.BtnClientes.TabIndex = 4;
            this.BtnClientes.Text = "Lista de Clientes";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 10);
            this.panel6.TabIndex = 3;
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnArticulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnArticulos.FlatAppearance.BorderSize = 0;
            this.BtnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArticulos.Image = ((System.Drawing.Image)(resources.GetObject("BtnArticulos.Image")));
            this.BtnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnArticulos.Location = new System.Drawing.Point(10, 10);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Size = new System.Drawing.Size(226, 76);
            this.BtnArticulos.TabIndex = 0;
            this.BtnArticulos.Text = "Lista de Artículos";
            this.BtnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnArticulos.UseVisualStyleBackColor = true;
            this.BtnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(236, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 460);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 460);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 10);
            this.panel3.TabIndex = 0;
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(246, 73);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(944, 470);
            this.PanelGeneral.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1190, 543);
            this.Controls.Add(this.PanelGeneral);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnArticulos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnTiendas;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel PanelGeneral;
    }
}

