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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtCorreoL = new System.Windows.Forms.TextBox();
            this.txtContraseñaL = new System.Windows.Forms.TextBox();
            this.lnkRecupero = new System.Windows.Forms.LinkLabel();
            this.btnRegistroL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(117, 200);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(135, 69);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(124, 121);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtCorreoL
            // 
            this.txtCorreoL.Location = new System.Drawing.Point(97, 85);
            this.txtCorreoL.Name = "txtCorreoL";
            this.txtCorreoL.Size = new System.Drawing.Size(115, 20);
            this.txtCorreoL.TabIndex = 3;
            // 
            // txtContraseñaL
            // 
            this.txtContraseñaL.Location = new System.Drawing.Point(97, 137);
            this.txtContraseñaL.Name = "txtContraseñaL";
            this.txtContraseñaL.Size = new System.Drawing.Size(115, 20);
            this.txtContraseñaL.TabIndex = 4;
            // 
            // lnkRecupero
            // 
            this.lnkRecupero.AutoSize = true;
            this.lnkRecupero.Location = new System.Drawing.Point(95, 171);
            this.lnkRecupero.Name = "lnkRecupero";
            this.lnkRecupero.Size = new System.Drawing.Size(119, 13);
            this.lnkRecupero.TabIndex = 5;
            this.lnkRecupero.TabStop = true;
            this.lnkRecupero.Text = "¿Olvido su contraseña?";
            this.lnkRecupero.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecupero_LinkClicked);
            // 
            // btnRegistroL
            // 
            this.btnRegistroL.Location = new System.Drawing.Point(117, 242);
            this.btnRegistroL.Name = "btnRegistroL";
            this.btnRegistroL.Size = new System.Drawing.Size(75, 23);
            this.btnRegistroL.TabIndex = 6;
            this.btnRegistroL.Text = "Registrate";
            this.btnRegistroL.UseVisualStyleBackColor = true;
            this.btnRegistroL.Click += new System.EventHandler(this.btnRegistroL_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(316, 362);
            this.Controls.Add(this.btnRegistroL);
            this.Controls.Add(this.lnkRecupero);
            this.Controls.Add(this.txtContraseñaL);
            this.Controls.Add(this.txtCorreoL);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.btnIngresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtCorreoL;
        private System.Windows.Forms.TextBox txtContraseñaL;
        private System.Windows.Forms.LinkLabel lnkRecupero;
        private System.Windows.Forms.Button btnRegistroL;
    }
}

