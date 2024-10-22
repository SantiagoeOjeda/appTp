namespace Presentacion
{
    partial class Recupero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recupero));
            this.txtCorreoR = new System.Windows.Forms.TextBox();
            this.lblIngreseCorreo = new System.Windows.Forms.Label();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.txtConfirmNuevaContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.txtCodigoI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCorreoR
            // 
            this.txtCorreoR.Location = new System.Drawing.Point(74, 62);
            this.txtCorreoR.Name = "txtCorreoR";
            this.txtCorreoR.Size = new System.Drawing.Size(142, 20);
            this.txtCorreoR.TabIndex = 0;
            // 
            // lblIngreseCorreo
            // 
            this.lblIngreseCorreo.AutoSize = true;
            this.lblIngreseCorreo.Location = new System.Drawing.Point(101, 46);
            this.lblIngreseCorreo.Name = "lblIngreseCorreo";
            this.lblIngreseCorreo.Size = new System.Drawing.Size(89, 13);
            this.lblIngreseCorreo.TabIndex = 1;
            this.lblIngreseCorreo.Text = "Ingrese su correo";
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(105, 101);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(75, 23);
            this.btnCodigo.TabIndex = 3;
            this.btnCodigo.Text = "Generar codigo";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Enabled = false;
            this.txtNuevaContrasena.Location = new System.Drawing.Point(74, 202);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.Size = new System.Drawing.Size(142, 20);
            this.txtNuevaContrasena.TabIndex = 4;
            // 
            // txtConfirmNuevaContrasena
            // 
            this.txtConfirmNuevaContrasena.Enabled = false;
            this.txtConfirmNuevaContrasena.Location = new System.Drawing.Point(74, 241);
            this.txtConfirmNuevaContrasena.Name = "txtConfirmNuevaContrasena";
            this.txtConfirmNuevaContrasena.Size = new System.Drawing.Size(142, 20);
            this.txtConfirmNuevaContrasena.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese su contraseña nueva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Confirme contraseña";
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.Enabled = false;
            this.btnCambiarPass.Location = new System.Drawing.Point(104, 267);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarPass.TabIndex = 8;
            this.btnCambiarPass.Text = "Cambiar";
            this.btnCambiarPass.UseVisualStyleBackColor = true;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // txtCodigoI
            // 
            this.txtCodigoI.Enabled = false;
            this.txtCodigoI.Location = new System.Drawing.Point(74, 163);
            this.txtCodigoI.Name = "txtCodigoI";
            this.txtCodigoI.Size = new System.Drawing.Size(142, 20);
            this.txtCodigoI.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingrese el codigo";
            // 
            // Recupero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(293, 334);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoI);
            this.Controls.Add(this.btnCambiarPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmNuevaContrasena);
            this.Controls.Add(this.txtNuevaContrasena);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.lblIngreseCorreo);
            this.Controls.Add(this.txtCorreoR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recupero";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCorreoR;
        private System.Windows.Forms.Label lblIngreseCorreo;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.TextBox txtConfirmNuevaContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambiarPass;
        private System.Windows.Forms.TextBox txtCodigoI;
        private System.Windows.Forms.Label label3;
    }
}