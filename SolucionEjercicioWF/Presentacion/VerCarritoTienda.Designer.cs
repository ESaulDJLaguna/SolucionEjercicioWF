
namespace SolucionEjercicioWF.Presentacion
{
    partial class VerCarritoTienda
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelDatosCompra = new System.Windows.Forms.Panel();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.LblTotalPagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelDatosCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(697, 546);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // PanelDatosCompra
            // 
            this.PanelDatosCompra.Controls.Add(this.BtnPagar);
            this.PanelDatosCompra.Controls.Add(this.LblTotalPagar);
            this.PanelDatosCompra.Controls.Add(this.label1);
            this.PanelDatosCompra.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelDatosCompra.Location = new System.Drawing.Point(697, 0);
            this.PanelDatosCompra.Name = "PanelDatosCompra";
            this.PanelDatosCompra.Size = new System.Drawing.Size(180, 546);
            this.PanelDatosCompra.TabIndex = 2;
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackColor = System.Drawing.Color.Black;
            this.BtnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPagar.FlatAppearance.BorderSize = 0;
            this.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagar.Image = global::SolucionEjercicioWF.Properties.Resources.metodo_de_pago;
            this.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPagar.Location = new System.Drawing.Point(29, 262);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(129, 42);
            this.BtnPagar.TabIndex = 2;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPagar.UseVisualStyleBackColor = false;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click_1);
            // 
            // LblTotalPagar
            // 
            this.LblTotalPagar.AutoSize = true;
            this.LblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPagar.Location = new System.Drawing.Point(77, 174);
            this.LblTotalPagar.Name = "LblTotalPagar";
            this.LblTotalPagar.Size = new System.Drawing.Size(27, 29);
            this.LblTotalPagar.TabIndex = 1;
            this.LblTotalPagar.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total a Pagar";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // VerCarritoTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.PanelDatosCompra);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "VerCarritoTienda";
            this.Size = new System.Drawing.Size(877, 546);
            this.PanelDatosCompra.ResumeLayout(false);
            this.PanelDatosCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PanelDatosCompra;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Label LblTotalPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
