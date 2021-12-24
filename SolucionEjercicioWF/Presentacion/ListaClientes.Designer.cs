
namespace SolucionEjercicioWF.Presentacion
{
    partial class ListaClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.DgvListadoClientes = new System.Windows.Forms.DataGridView();
            this.PanelNewCliente = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsr = new System.Windows.Forms.TextBox();
            this.BtnCancelarCliente = new System.Windows.Forms.Button();
            this.BtnEditarCliente = new System.Windows.Forms.Button();
            this.BtnGuardarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnAddCliente = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoClientes)).BeginInit();
            this.PanelNewCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 88);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnAddCliente);
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
            this.PanelPrincipal.Controls.Add(this.PanelNewCliente);
            this.PanelPrincipal.Controls.Add(this.DgvListadoClientes);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 88);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1173, 500);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // DgvListadoClientes
            // 
            this.DgvListadoClientes.AllowUserToAddRows = false;
            this.DgvListadoClientes.AllowUserToDeleteRows = false;
            this.DgvListadoClientes.AllowUserToResizeRows = false;
            this.DgvListadoClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.DgvListadoClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvListadoClientes.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvListadoClientes.Location = new System.Drawing.Point(0, 0);
            this.DgvListadoClientes.Name = "DgvListadoClientes";
            this.DgvListadoClientes.ReadOnly = true;
            this.DgvListadoClientes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvListadoClientes.RowTemplate.Height = 40;
            this.DgvListadoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListadoClientes.Size = new System.Drawing.Size(1173, 500);
            this.DgvListadoClientes.TabIndex = 3;
            this.DgvListadoClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListadoClientes_CellClick);
            // 
            // PanelNewCliente
            // 
            this.PanelNewCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelNewCliente.Controls.Add(this.label4);
            this.PanelNewCliente.Controls.Add(this.TxtDireccion);
            this.PanelNewCliente.Controls.Add(this.BtnEditarCliente);
            this.PanelNewCliente.Controls.Add(this.BtnCancelarCliente);
            this.PanelNewCliente.Controls.Add(this.BtnGuardarCliente);
            this.PanelNewCliente.Controls.Add(this.label3);
            this.PanelNewCliente.Controls.Add(this.TxtApellidos);
            this.PanelNewCliente.Controls.Add(this.label2);
            this.PanelNewCliente.Controls.Add(this.TxtNombres);
            this.PanelNewCliente.Controls.Add(this.label1);
            this.PanelNewCliente.Controls.Add(this.TxtUsr);
            this.PanelNewCliente.Location = new System.Drawing.Point(329, 96);
            this.PanelNewCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelNewCliente.Name = "PanelNewCliente";
            this.PanelNewCliente.Size = new System.Drawing.Size(557, 324);
            this.PanelNewCliente.TabIndex = 2;
            this.PanelNewCliente.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(61, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellidos:";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(171, 93);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(321, 26);
            this.TxtApellidos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(61, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombres:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(171, 54);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(321, 26);
            this.TxtNombres.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(61, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // TxtUsr
            // 
            this.TxtUsr.Location = new System.Drawing.Point(171, 14);
            this.TxtUsr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUsr.Name = "TxtUsr";
            this.TxtUsr.Size = new System.Drawing.Size(321, 26);
            this.TxtUsr.TabIndex = 0;
            // 
            // BtnCancelarCliente
            // 
            this.BtnCancelarCliente.BackColor = System.Drawing.Color.Black;
            this.BtnCancelarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarCliente.FlatAppearance.BorderSize = 0;
            this.BtnCancelarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelarCliente.Location = new System.Drawing.Point(369, 253);
            this.BtnCancelarCliente.Name = "BtnCancelarCliente";
            this.BtnCancelarCliente.Size = new System.Drawing.Size(137, 52);
            this.BtnCancelarCliente.TabIndex = 12;
            this.BtnCancelarCliente.Text = "Cancelar";
            this.BtnCancelarCliente.UseVisualStyleBackColor = false;
            this.BtnCancelarCliente.Click += new System.EventHandler(this.BtnCancelarCliente_Click);
            // 
            // BtnEditarCliente
            // 
            this.BtnEditarCliente.BackColor = System.Drawing.Color.Black;
            this.BtnEditarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditarCliente.FlatAppearance.BorderSize = 0;
            this.BtnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarCliente.Location = new System.Drawing.Point(209, 253);
            this.BtnEditarCliente.Name = "BtnEditarCliente";
            this.BtnEditarCliente.Size = new System.Drawing.Size(137, 52);
            this.BtnEditarCliente.TabIndex = 13;
            this.BtnEditarCliente.Text = "Editar";
            this.BtnEditarCliente.UseVisualStyleBackColor = false;
            this.BtnEditarCliente.Click += new System.EventHandler(this.BtnEditarCliente_Click);
            // 
            // BtnGuardarCliente
            // 
            this.BtnGuardarCliente.BackColor = System.Drawing.Color.Black;
            this.BtnGuardarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarCliente.FlatAppearance.BorderSize = 0;
            this.BtnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCliente.Location = new System.Drawing.Point(46, 253);
            this.BtnGuardarCliente.Name = "BtnGuardarCliente";
            this.BtnGuardarCliente.Size = new System.Drawing.Size(137, 52);
            this.BtnGuardarCliente.TabIndex = 10;
            this.BtnGuardarCliente.Text = "Guardar";
            this.BtnGuardarCliente.UseVisualStyleBackColor = false;
            this.BtnGuardarCliente.Click += new System.EventHandler(this.BtnGuardarCliente_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(61, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dirección:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(171, 133);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(321, 79);
            this.TxtDireccion.TabIndex = 14;
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
            // BtnAddCliente
            // 
            this.BtnAddCliente.BackgroundImage = global::SolucionEjercicioWF.Properties.Resources.agregar_archivo;
            this.BtnAddCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAddCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddCliente.FlatAppearance.BorderSize = 0;
            this.BtnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddCliente.Location = new System.Drawing.Point(0, 8);
            this.BtnAddCliente.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnAddCliente.Name = "BtnAddCliente";
            this.BtnAddCliente.Size = new System.Drawing.Size(110, 72);
            this.BtnAddCliente.TabIndex = 3;
            this.BtnAddCliente.UseVisualStyleBackColor = true;
            this.BtnAddCliente.Click += new System.EventHandler(this.BtnAddCliente_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListaClientes";
            this.Size = new System.Drawing.Size(1173, 588);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PanelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListadoClientes)).EndInit();
            this.PanelNewCliente.ResumeLayout(false);
            this.PanelNewCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnAddCliente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.DataGridView DgvListadoClientes;
        private System.Windows.Forms.Panel PanelNewCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Button BtnEditarCliente;
        private System.Windows.Forms.Button BtnCancelarCliente;
        private System.Windows.Forms.Button BtnGuardarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUsr;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Timer timer1;
    }
}
