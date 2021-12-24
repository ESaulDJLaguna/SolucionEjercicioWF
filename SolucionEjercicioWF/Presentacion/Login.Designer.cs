
namespace SolucionEjercicioWF.Presentacion
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnBodega = new System.Windows.Forms.Button();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.BtnSucursal = new System.Windows.Forms.Button();
            this.BtnUsuario = new System.Windows.Forms.Button();
            this.PanelLoginUsr = new System.Windows.Forms.Panel();
            this.BtnIniciarSesionUsr = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.PanelLoginSucursal = new System.Windows.Forms.Panel();
            this.CbxSucursales = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAccederTienda = new System.Windows.Forms.Button();
            this.PanelBotones.SuspendLayout();
            this.PanelLoginUsr.SuspendLayout();
            this.PanelLoginSucursal.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(1190, 88);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "¿Quién está Iniciando Sesión?";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnBodega
            // 
            this.BtnBodega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnBodega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBodega.FlatAppearance.BorderSize = 0;
            this.BtnBodega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBodega.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnBodega.Location = new System.Drawing.Point(15, 323);
            this.BtnBodega.Name = "BtnBodega";
            this.BtnBodega.Size = new System.Drawing.Size(368, 53);
            this.BtnBodega.TabIndex = 3;
            this.BtnBodega.Text = "Accede a la Bodega";
            this.BtnBodega.UseVisualStyleBackColor = false;
            this.BtnBodega.Click += new System.EventHandler(this.BtnBodega_Click);
            // 
            // PanelBotones
            // 
            this.PanelBotones.Controls.Add(this.BtnSucursal);
            this.PanelBotones.Controls.Add(this.BtnBodega);
            this.PanelBotones.Controls.Add(this.BtnUsuario);
            this.PanelBotones.Location = new System.Drawing.Point(395, 122);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(400, 394);
            this.PanelBotones.TabIndex = 4;
            // 
            // BtnSucursal
            // 
            this.BtnSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnSucursal.BackgroundImage = global::SolucionEjercicioWF.Properties.Resources.azul;
            this.BtnSucursal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSucursal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSucursal.FlatAppearance.BorderSize = 0;
            this.BtnSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSucursal.Location = new System.Drawing.Point(15, 49);
            this.BtnSucursal.Name = "BtnSucursal";
            this.BtnSucursal.Size = new System.Drawing.Size(368, 86);
            this.BtnSucursal.TabIndex = 1;
            this.BtnSucursal.Text = "Sucursal";
            this.BtnSucursal.UseVisualStyleBackColor = false;
            this.BtnSucursal.Click += new System.EventHandler(this.BtnSucursal_Click);
            // 
            // BtnUsuario
            // 
            this.BtnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BtnUsuario.BackgroundImage = global::SolucionEjercicioWF.Properties.Resources.naranja;
            this.BtnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsuario.FlatAppearance.BorderSize = 0;
            this.BtnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuario.Location = new System.Drawing.Point(15, 174);
            this.BtnUsuario.Name = "BtnUsuario";
            this.BtnUsuario.Size = new System.Drawing.Size(368, 86);
            this.BtnUsuario.TabIndex = 2;
            this.BtnUsuario.Text = "Usuario";
            this.BtnUsuario.UseVisualStyleBackColor = false;
            this.BtnUsuario.Click += new System.EventHandler(this.BtnUsuario_Click);
            // 
            // PanelLoginUsr
            // 
            this.PanelLoginUsr.Controls.Add(this.BtnIniciarSesionUsr);
            this.PanelLoginUsr.Controls.Add(this.panel2);
            this.PanelLoginUsr.Controls.Add(this.TxtContraseña);
            this.PanelLoginUsr.Controls.Add(this.LblContraseña);
            this.PanelLoginUsr.Controls.Add(this.panel1);
            this.PanelLoginUsr.Controls.Add(this.TxtUser);
            this.PanelLoginUsr.Controls.Add(this.LblUser);
            this.PanelLoginUsr.Location = new System.Drawing.Point(13, 119);
            this.PanelLoginUsr.Name = "PanelLoginUsr";
            this.PanelLoginUsr.Size = new System.Drawing.Size(281, 74);
            this.PanelLoginUsr.TabIndex = 5;
            this.PanelLoginUsr.Visible = false;
            // 
            // BtnIniciarSesionUsr
            // 
            this.BtnIniciarSesionUsr.BackColor = System.Drawing.Color.Black;
            this.BtnIniciarSesionUsr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciarSesionUsr.FlatAppearance.BorderSize = 0;
            this.BtnIniciarSesionUsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciarSesionUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesionUsr.Image = global::SolucionEjercicioWF.Properties.Resources.iniciar_sesion;
            this.BtnIniciarSesionUsr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIniciarSesionUsr.Location = new System.Drawing.Point(456, 343);
            this.BtnIniciarSesionUsr.Name = "BtnIniciarSesionUsr";
            this.BtnIniciarSesionUsr.Size = new System.Drawing.Size(284, 74);
            this.BtnIniciarSesionUsr.TabIndex = 6;
            this.BtnIniciarSesionUsr.Text = "Iniciar Sesión";
            this.BtnIniciarSesionUsr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnIniciarSesionUsr.UseVisualStyleBackColor = false;
            this.BtnIniciarSesionUsr.Click += new System.EventHandler(this.BtnIniciarSesionUsr_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(391, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 2);
            this.panel2.TabIndex = 5;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.White;
            this.TxtContraseña.Location = new System.Drawing.Point(391, 238);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(408, 28);
            this.TxtContraseña.TabIndex = 4;
            this.TxtContraseña.UseSystemPasswordChar = true;
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.Location = new System.Drawing.Point(506, 179);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(178, 36);
            this.LblContraseña.TabIndex = 3;
            this.LblContraseña.Text = "Contraseña";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(391, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 2);
            this.panel1.TabIndex = 2;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.White;
            this.TxtUser.Location = new System.Drawing.Point(391, 120);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(408, 28);
            this.TxtUser.TabIndex = 1;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(450, 61);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(290, 36);
            this.LblUser.TabIndex = 0;
            this.LblUser.Text = "Nombre de Usuario";
            // 
            // BtnVolver
            // 
            this.BtnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVolver.BackgroundImage = global::SolucionEjercicioWF.Properties.Resources.volver;
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Location = new System.Drawing.Point(1098, 451);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(80, 80);
            this.BtnVolver.TabIndex = 8;
            this.BtnVolver.UseVisualStyleBackColor = true;
            this.BtnVolver.Visible = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // PanelLoginSucursal
            // 
            this.PanelLoginSucursal.Controls.Add(this.BtnAccederTienda);
            this.PanelLoginSucursal.Controls.Add(this.label1);
            this.PanelLoginSucursal.Controls.Add(this.CbxSucursales);
            this.PanelLoginSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.PanelLoginSucursal.Location = new System.Drawing.Point(13, 239);
            this.PanelLoginSucursal.Name = "PanelLoginSucursal";
            this.PanelLoginSucursal.Size = new System.Drawing.Size(281, 86);
            this.PanelLoginSucursal.TabIndex = 9;
            this.PanelLoginSucursal.Visible = false;
            // 
            // CbxSucursales
            // 
            this.CbxSucursales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CbxSucursales.FormattingEnabled = true;
            this.CbxSucursales.Location = new System.Drawing.Point(382, 141);
            this.CbxSucursales.Name = "CbxSucursales";
            this.CbxSucursales.Size = new System.Drawing.Size(426, 33);
            this.CbxSucursales.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige una Sucursal";
            // 
            // BtnAccederTienda
            // 
            this.BtnAccederTienda.BackColor = System.Drawing.Color.Black;
            this.BtnAccederTienda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAccederTienda.FlatAppearance.BorderSize = 0;
            this.BtnAccederTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccederTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccederTienda.Image = global::SolucionEjercicioWF.Properties.Resources.iniciar_sesion;
            this.BtnAccederTienda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAccederTienda.Location = new System.Drawing.Point(453, 269);
            this.BtnAccederTienda.Name = "BtnAccederTienda";
            this.BtnAccederTienda.Size = new System.Drawing.Size(284, 74);
            this.BtnAccederTienda.TabIndex = 7;
            this.BtnAccederTienda.Text = "Acceder";
            this.BtnAccederTienda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAccederTienda.UseVisualStyleBackColor = false;
            this.BtnAccederTienda.Click += new System.EventHandler(this.BtnAccederTienda_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1190, 543);
            this.Controls.Add(this.PanelLoginSucursal);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.PanelLoginUsr);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.LblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanelBotones.ResumeLayout(false);
            this.PanelLoginUsr.ResumeLayout(false);
            this.PanelLoginUsr.PerformLayout();
            this.PanelLoginSucursal.ResumeLayout(false);
            this.PanelLoginSucursal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnUsuario;
        private System.Windows.Forms.Button BtnBodega;
        private System.Windows.Forms.Button BtnSucursal;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Panel PanelLoginUsr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Label LblContraseña;
        private System.Windows.Forms.Button BtnIniciarSesionUsr;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Panel PanelLoginSucursal;
        private System.Windows.Forms.ComboBox CbxSucursales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAccederTienda;
    }
}