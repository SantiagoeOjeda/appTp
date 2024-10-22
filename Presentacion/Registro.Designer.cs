namespace Presentacion
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraeña = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreoR = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtContraseñaConfirm = new System.Windows.Forms.TextBox();
            this.lblErrorCorreo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(104, 277);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarse.TabIndex = 0;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(119, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(119, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(122, 123);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo";
            // 
            // lblContraeña
            // 
            this.lblContraeña.AutoSize = true;
            this.lblContraeña.Location = new System.Drawing.Point(111, 181);
            this.lblContraeña.Name = "lblContraeña";
            this.lblContraeña.Size = new System.Drawing.Size(61, 13);
            this.lblContraeña.TabIndex = 4;
            this.lblContraeña.Text = "Contraseña";
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(87, 235);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(108, 13);
            this.lblConfirmPass.TabIndex = 5;
            this.lblConfirmPass.Text = "Confirmar Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(68, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(68, 86);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(146, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtCorreoR
            // 
            this.txtCorreoR.Location = new System.Drawing.Point(68, 139);
            this.txtCorreoR.Name = "txtCorreoR";
            this.txtCorreoR.Size = new System.Drawing.Size(146, 20);
            this.txtCorreoR.TabIndex = 8;
            this.txtCorreoR.TextChanged += new System.EventHandler(this.txtCorreoR_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(68, 197);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(146, 20);
            this.txtContraseña.TabIndex = 9;
            // 
            // txtContraseñaConfirm
            // 
            this.txtContraseñaConfirm.Location = new System.Drawing.Point(68, 251);
            this.txtContraseñaConfirm.Name = "txtContraseñaConfirm";
            this.txtContraseñaConfirm.Size = new System.Drawing.Size(146, 20);
            this.txtContraseñaConfirm.TabIndex = 10;
            // 
            // lblErrorCorreo
            // 
            this.lblErrorCorreo.AutoSize = true;
            this.lblErrorCorreo.Location = new System.Drawing.Point(87, 162);
            this.lblErrorCorreo.Name = "lblErrorCorreo";
            this.lblErrorCorreo.Size = new System.Drawing.Size(35, 13);
            this.lblErrorCorreo.TabIndex = 11;
            this.lblErrorCorreo.Text = "label1";
            this.lblErrorCorreo.Visible = false;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(276, 341);
            this.Controls.Add(this.lblErrorCorreo);
            this.Controls.Add(this.txtContraseñaConfirm);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreoR);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblContraeña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnRegistrarse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraeña;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCorreoR;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtContraseñaConfirm;
        private System.Windows.Forms.Label lblErrorCorreo;
    }
}