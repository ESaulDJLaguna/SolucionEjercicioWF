
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAddCliente = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 88);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1173, 500);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // ListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListaClientes";
            this.Size = new System.Drawing.Size(1173, 588);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
    }
}
