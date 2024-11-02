namespace Presentacion
{
    partial class Login
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
            System.Windows.Forms.LinkLabel lnkRecupero;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtCorreoL = new System.Windows.Forms.TextBox();
            this.txtContraseñaL = new System.Windows.Forms.TextBox();
            this.btnRegistroL = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcboxMostrar = new System.Windows.Forms.PictureBox();
            this.pcboxOcultar = new System.Windows.Forms.PictureBox();
            lnkRecupero = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIngresar.Location = new System.Drawing.Point(100, 270);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(115, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCorreo.Location = new System.Drawing.Point(138, 147);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblContraseña.Location = new System.Drawing.Point(127, 195);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtCorreoL
            // 
            this.txtCorreoL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCorreoL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCorreoL.Location = new System.Drawing.Point(100, 163);
            this.txtCorreoL.Name = "txtCorreoL";
            this.txtCorreoL.Size = new System.Drawing.Size(115, 20);
            this.txtCorreoL.TabIndex = 3;
            // 
            // txtContraseñaL
            // 
            this.txtContraseñaL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtContraseñaL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtContraseñaL.Location = new System.Drawing.Point(100, 211);
            this.txtContraseñaL.Name = "txtContraseñaL";
            this.txtContraseñaL.Size = new System.Drawing.Size(115, 20);
            this.txtContraseñaL.TabIndex = 4;
            // 
            // lnkRecupero
            // 
            lnkRecupero.AutoSize = true;
            lnkRecupero.ForeColor = System.Drawing.SystemColors.ControlText;
            lnkRecupero.LinkColor = System.Drawing.Color.Cornsilk;
            lnkRecupero.Location = new System.Drawing.Point(98, 244);
            lnkRecupero.Name = "lnkRecupero";
            lnkRecupero.Size = new System.Drawing.Size(119, 13);
            lnkRecupero.TabIndex = 5;
            lnkRecupero.TabStop = true;
            lnkRecupero.Text = "¿Olvido su contraseña?";
            lnkRecupero.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecupero_LinkClicked);
            // 
            // btnRegistroL
            // 
            this.btnRegistroL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistroL.Location = new System.Drawing.Point(100, 299);
            this.btnRegistroL.Name = "btnRegistroL";
            this.btnRegistroL.Size = new System.Drawing.Size(115, 23);
            this.btnRegistroL.TabIndex = 6;
            this.btnRegistroL.Text = "Registrate";
            this.btnRegistroL.UseVisualStyleBackColor = false;
            this.btnRegistroL.Click += new System.EventHandler(this.btnRegistroL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.FixPaginaPrincipal;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pcboxMostrar
            // 
            this.pcboxMostrar.BackColor = System.Drawing.Color.Gainsboro;
            this.pcboxMostrar.Image = global::Presentacion.Properties.Resources.eye_icon_md;
            this.pcboxMostrar.Location = new System.Drawing.Point(211, 211);
            this.pcboxMostrar.Name = "pcboxMostrar";
            this.pcboxMostrar.Size = new System.Drawing.Size(21, 20);
            this.pcboxMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcboxMostrar.TabIndex = 8;
            this.pcboxMostrar.TabStop = false;
            this.pcboxMostrar.Click += new System.EventHandler(this.pcboxMostrar_Click_1);
            // 
            // pcboxOcultar
            // 
            this.pcboxOcultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcboxOcultar.Image = global::Presentacion.Properties.Resources.eyeslash;
            this.pcboxOcultar.Location = new System.Drawing.Point(211, 211);
            this.pcboxOcultar.Name = "pcboxOcultar";
            this.pcboxOcultar.Size = new System.Drawing.Size(21, 20);
            this.pcboxOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcboxOcultar.TabIndex = 7;
            this.pcboxOcultar.TabStop = false;
            this.pcboxOcultar.Click += new System.EventHandler(this.pcboxOcultar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(316, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcboxMostrar);
            this.Controls.Add(this.pcboxOcultar);
            this.Controls.Add(this.btnRegistroL);
            this.Controls.Add(lnkRecupero);
            this.Controls.Add(this.txtContraseñaL);
            this.Controls.Add(this.txtCorreoL);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.btnIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxOcultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtCorreoL;
        private System.Windows.Forms.TextBox txtContraseñaL;
        private System.Windows.Forms.Button btnRegistroL;
        private System.Windows.Forms.PictureBox pcboxOcultar;
        private System.Windows.Forms.PictureBox pcboxMostrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

