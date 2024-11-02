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
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.pcbOcultar2 = new System.Windows.Forms.PictureBox();
            this.pcbMostrar2 = new System.Windows.Forms.PictureBox();
            this.pcbOcultar = new System.Windows.Forms.PictureBox();
            this.pcbMostrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCorreoR
            // 
            this.txtCorreoR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCorreoR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCorreoR.Location = new System.Drawing.Point(74, 62);
            this.txtCorreoR.Name = "txtCorreoR";
            this.txtCorreoR.Size = new System.Drawing.Size(142, 20);
            this.txtCorreoR.TabIndex = 0;
            // 
            // lblIngreseCorreo
            // 
            this.lblIngreseCorreo.AutoSize = true;
            this.lblIngreseCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIngreseCorreo.Location = new System.Drawing.Point(101, 46);
            this.lblIngreseCorreo.Name = "lblIngreseCorreo";
            this.lblIngreseCorreo.Size = new System.Drawing.Size(89, 13);
            this.lblIngreseCorreo.TabIndex = 1;
            this.lblIngreseCorreo.Text = "Ingrese su correo";
            // 
            // btnCodigo
            // 
            this.btnCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCodigo.Location = new System.Drawing.Point(105, 101);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(75, 23);
            this.btnCodigo.TabIndex = 3;
            this.btnCodigo.Text = "Generar ";
            this.btnCodigo.UseVisualStyleBackColor = false;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtNuevaContrasena.Enabled = false;
            this.txtNuevaContrasena.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtNuevaContrasena.Location = new System.Drawing.Point(74, 210);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.Size = new System.Drawing.Size(142, 20);
            this.txtNuevaContrasena.TabIndex = 4;
            this.txtNuevaContrasena.TextChanged += new System.EventHandler(this.txtNuevaContrasena_TextChanged);
            // 
            // txtConfirmNuevaContrasena
            // 
            this.txtConfirmNuevaContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtConfirmNuevaContrasena.Enabled = false;
            this.txtConfirmNuevaContrasena.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmNuevaContrasena.Location = new System.Drawing.Point(74, 264);
            this.txtConfirmNuevaContrasena.Name = "txtConfirmNuevaContrasena";
            this.txtConfirmNuevaContrasena.Size = new System.Drawing.Size(142, 20);
            this.txtConfirmNuevaContrasena.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(71, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese su contraseña nueva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(91, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Confirme contraseña";
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCambiarPass.Enabled = false;
            this.btnCambiarPass.Location = new System.Drawing.Point(104, 290);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarPass.TabIndex = 8;
            this.btnCambiarPass.Text = "Cambiar";
            this.btnCambiarPass.UseVisualStyleBackColor = false;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // txtCodigoI
            // 
            this.txtCodigoI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCodigoI.Enabled = false;
            this.txtCodigoI.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigoI.Location = new System.Drawing.Point(74, 163);
            this.txtCodigoI.Name = "txtCodigoI";
            this.txtCodigoI.Size = new System.Drawing.Size(142, 20);
            this.txtCodigoI.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(102, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingrese el codigo";
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.AutoSize = true;
            this.lblErrorPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblErrorPass.Location = new System.Drawing.Point(33, 233);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(35, 13);
            this.lblErrorPass.TabIndex = 11;
            this.lblErrorPass.Text = "label4";
            this.lblErrorPass.Visible = false;
            // 
            // pcbOcultar2
            // 
            this.pcbOcultar2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbOcultar2.Image = global::Presentacion.Properties.Resources.eyeslash;
            this.pcbOcultar2.Location = new System.Drawing.Point(222, 264);
            this.pcbOcultar2.Name = "pcbOcultar2";
            this.pcbOcultar2.Size = new System.Drawing.Size(24, 20);
            this.pcbOcultar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOcultar2.TabIndex = 12;
            this.pcbOcultar2.TabStop = false;
            this.pcbOcultar2.Click += new System.EventHandler(this.pcbOcultar2_Click);
            // 
            // pcbMostrar2
            // 
            this.pcbMostrar2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbMostrar2.Image = global::Presentacion.Properties.Resources.eye_icon_md;
            this.pcbMostrar2.Location = new System.Drawing.Point(222, 264);
            this.pcbMostrar2.Name = "pcbMostrar2";
            this.pcbMostrar2.Size = new System.Drawing.Size(26, 20);
            this.pcbMostrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMostrar2.TabIndex = 13;
            this.pcbMostrar2.TabStop = false;
            this.pcbMostrar2.Click += new System.EventHandler(this.pcbMostrar2_Click);
            // 
            // pcbOcultar
            // 
            this.pcbOcultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbOcultar.Image = global::Presentacion.Properties.Resources.eyeslash;
            this.pcbOcultar.Location = new System.Drawing.Point(224, 210);
            this.pcbOcultar.Name = "pcbOcultar";
            this.pcbOcultar.Size = new System.Drawing.Size(24, 20);
            this.pcbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOcultar.TabIndex = 14;
            this.pcbOcultar.TabStop = false;
            this.pcbOcultar.Click += new System.EventHandler(this.pcbOcultar_Click);
            // 
            // pcbMostrar
            // 
            this.pcbMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbMostrar.Image = global::Presentacion.Properties.Resources.eye_icon_md;
            this.pcbMostrar.Location = new System.Drawing.Point(222, 210);
            this.pcbMostrar.Name = "pcbMostrar";
            this.pcbMostrar.Size = new System.Drawing.Size(26, 23);
            this.pcbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMostrar.TabIndex = 15;
            this.pcbMostrar.TabStop = false;
            this.pcbMostrar.Click += new System.EventHandler(this.pcbMostrar_Click);
            // 
            // Recupero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(293, 334);
            this.Controls.Add(this.pcbMostrar);
            this.Controls.Add(this.pcbOcultar);
            this.Controls.Add(this.pcbMostrar2);
            this.Controls.Add(this.pcbOcultar2);
            this.Controls.Add(this.lblErrorPass);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar)).EndInit();
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
        private System.Windows.Forms.Label lblErrorPass;
        private System.Windows.Forms.PictureBox pcbOcultar2;
        private System.Windows.Forms.PictureBox pcbMostrar2;
        private System.Windows.Forms.PictureBox pcbOcultar;
        private System.Windows.Forms.PictureBox pcbMostrar;
    }
}