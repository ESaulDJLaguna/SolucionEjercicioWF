
namespace SolucionEjercicioWF.Presentacion
{
    partial class ListaTiendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAddTienda = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.PanelNewTienda = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.BtnEditarTienda = new System.Windows.Forms.Button();
            this.BtnCancelarTienda = new System.Windows.Forms.Button();
            this.BtnGuardarTienda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSucursal = new System.Windows.Forms.TextBox();
            this.DgvListadoTiendas = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            this.PanelNewTienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoTiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::SolucionEjercicioWF.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::SolucionEjercicioWF.Properties.Resources.Eliminar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 88);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnAddTienda);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1055, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 88);
            this.panel2.TabIndex = 1;
            // 
            // BtnAddTienda
            // 
            this.BtnAddTienda.BackgroundImage = global::SolucionEjercicioWF.Properties.Resources.agregar_archivo;
            this.BtnAddTienda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddTienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddTienda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddTienda.FlatAppearance.BorderSize = 0;
            this.BtnAddTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddTienda.Location = new System.Drawing.Point(0, 8);
            this.BtnAddTienda.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnAddTienda.Name = "BtnAddTienda";
            this.BtnAddTienda.Size = new System.Drawing.Size(110, 72);
            this.BtnAddTienda.TabIndex = 3;
            this.BtnAddTienda.UseVisualStyleBackColor = true;
            this.BtnAddTienda.Click += new System.EventHandler(this.BtnAddTienda_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 80);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(110, 8);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(110, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 80);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 8);
            this.panel3.TabIndex = 0;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Controls.Add(this.PanelNewTienda);
            this.PanelPrincipal.Controls.Add(this.DgvListadoTiendas);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 88);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1173, 500);
            this.PanelPrincipal.TabIndex = 3;
            // 
            // PanelNewTienda
            // 
            this.PanelNewTienda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelNewTienda.Controls.Add(this.label4);
            this.PanelNewTienda.Controls.Add(this.TxtDireccion);
            this.PanelNewTienda.Controls.Add(this.BtnEditarTienda);
            this.PanelNewTienda.Controls.Add(this.BtnCancelarTienda);
            this.PanelNewTienda.Controls.Add(this.BtnGuardarTienda);
            this.PanelNewTienda.Controls.Add(this.label1);
            this.PanelNewTienda.Controls.Add(this.TxtSucursal);
            this.PanelNewTienda.Location = new System.Drawing.Point(308, 123);
            this.PanelNewTienda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelNewTienda.Name = "PanelNewTienda";
            this.PanelNewTienda.Size = new System.Drawing.Size(557, 254);
            this.PanelNewTienda.TabIndex = 2;
            this.PanelNewTienda.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(61, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dirección:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(171, 69);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(321, 79);
            this.TxtDireccion.TabIndex = 14;
            // 
            // BtnEditarTienda
            // 
            this.BtnEditarTienda.BackColor = System.Drawing.Color.Black;
            this.BtnEditarTienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarTienda.FlatAppearance.BorderSize = 0;
            this.BtnEditarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarTienda.Location = new System.Drawing.Point(209, 171);
            this.BtnEditarTienda.Name = "BtnEditarTienda";
            this.BtnEditarTienda.Size = new System.Drawing.Size(137, 52);
            this.BtnEditarTienda.TabIndex = 13;
            this.BtnEditarTienda.Text = "Editar";
            this.BtnEditarTienda.UseVisualStyleBackColor = false;
            this.BtnEditarTienda.Click += new System.EventHandler(this.BtnEditarTienda_Click);
            // 
            // BtnCancelarTienda
            // 
            this.BtnCancelarTienda.BackColor = System.Drawing.Color.Black;
            this.BtnCancelarTienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarTienda.FlatAppearance.BorderSize = 0;
            this.BtnCancelarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarTienda.Location = new System.Drawing.Point(369, 171);
            this.BtnCancelarTienda.Name = "BtnCancelarTienda";
            this.BtnCancelarTienda.Size = new System.Drawing.Size(137, 52);
            this.BtnCancelarTienda.TabIndex = 12;
            this.BtnCancelarTienda.Text = "Cancelar";
            this.BtnCancelarTienda.UseVisualStyleBackColor = false;
            this.BtnCancelarTienda.Click += new System.EventHandler(this.BtnCancelarTienda_Click);
            // 
            // BtnGuardarTienda
            // 
            this.BtnGuardarTienda.BackColor = System.Drawing.Color.Black;
            this.BtnGuardarTienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarTienda.FlatAppearance.BorderSize = 0;
            this.BtnGuardarTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarTienda.Location = new System.Drawing.Point(46, 171);
            this.BtnGuardarTienda.Name = "BtnGuardarTienda";
            this.BtnGuardarTienda.Size = new System.Drawing.Size(137, 52);
            this.BtnGuardarTienda.TabIndex = 10;
            this.BtnGuardarTienda.Text = "Guardar";
            this.BtnGuardarTienda.UseVisualStyleBackColor = false;
            this.BtnGuardarTienda.Click += new System.EventHandler(this.BtnGuardarTienda_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sucursal:";
            // 
            // TxtSucursal
            // 
            this.TxtSucursal.Location = new System.Drawing.Point(171, 14);
            this.TxtSucursal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSucursal.Name = "TxtSucursal";
            this.TxtSucursal.Size = new System.Drawing.Size(321, 26);
            this.TxtSucursal.TabIndex = 0;
            // 
            // DgvListadoTiendas
            // 
            this.DgvListadoTiendas.AllowUserToAddRows = false;
            this.DgvListadoTiendas.AllowUserToDeleteRows = false;
            this.DgvListadoTiendas.AllowUserToResizeRows = false;
            this.DgvListadoTiendas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.DgvListadoTiendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListadoTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoTiendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListadoTiendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListadoTiendas.Location = new System.Drawing.Point(0, 0);
            this.DgvListadoTiendas.Name = "DgvListadoTiendas";
            this.DgvListadoTiendas.ReadOnly = true;
            this.DgvListadoTiendas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListadoTiendas.RowTemplate.Height = 40;
            this.DgvListadoTiendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoTiendas.Size = new System.Drawing.Size(1173, 500);
            this.DgvListadoTiendas.TabIndex = 3;
            this.DgvListadoTiendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoTiendas_CellClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::SolucionEjercicioWF.Properties.Resources.editar;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::SolucionEjercicioWF.Properties.Resources.Eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ListaTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListaTiendas";
            this.Size = new System.Drawing.Size(1173, 588);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            this.PanelNewTienda.ResumeLayout(false);
            this.PanelNewTienda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoTiendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAddTienda;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel PanelNewTienda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Button BtnEditarTienda;
        private System.Windows.Forms.Button BtnCancelarTienda;
        private System.Windows.Forms.Button BtnGuardarTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSucursal;
        private System.Windows.Forms.DataGridView DgvListadoTiendas;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.Timer timer1;
    }
}
