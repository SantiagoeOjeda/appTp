namespace Presentacion
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrorPass = new System.Windows.Forms.Label();
            this.pcbOcultar = new System.Windows.Forms.PictureBox();
            this.pcbMostrar = new System.Windows.Forms.PictureBox();
            this.pcbOcultar2 = new System.Windows.Forms.PictureBox();
            this.pcbMostrar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtName.Location = new System.Drawing.Point(94, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtFullname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFullname.Location = new System.Drawing.Point(94, 92);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(121, 20);
            this.txtFullname.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(94, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPass.Location = new System.Drawing.Point(94, 194);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(121, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtConfirmPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPass.Location = new System.Drawing.Point(94, 249);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(121, 20);
            this.txtConfirmPass.TabIndex = 4;
            // 
            // cmbRol
            // 
            this.cmbRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cmbRol.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(94, 292);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(132, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(132, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(135, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(124, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(100, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(143, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rol";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargar.Location = new System.Drawing.Point(94, 328);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(114, 23);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Enabled = false;
            this.lblError.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblError.Location = new System.Drawing.Point(101, 162);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(35, 13);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "label7";
            this.lblError.Visible = false;
            // 
            // lblErrorPass
            // 
            this.lblErrorPass.AutoSize = true;
            this.lblErrorPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblErrorPass.Location = new System.Drawing.Point(49, 215);
            this.lblErrorPass.Name = "lblErrorPass";
            this.lblErrorPass.Size = new System.Drawing.Size(35, 13);
            this.lblErrorPass.TabIndex = 14;
            this.lblErrorPass.Text = "label7";
            this.lblErrorPass.Visible = false;
            // 
            // pcbOcultar
            // 
            this.pcbOcultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbOcultar.Image = global::Presentacion.Properties.Resources.eyeslash;
            this.pcbOcultar.Location = new System.Drawing.Point(221, 194);
            this.pcbOcultar.Name = "pcbOcultar";
            this.pcbOcultar.Size = new System.Drawing.Size(20, 20);
            this.pcbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOcultar.TabIndex = 15;
            this.pcbOcultar.TabStop = false;
            this.pcbOcultar.Click += new System.EventHandler(this.pcbOcultar_Click);
            // 
            // pcbMostrar
            // 
            this.pcbMostrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbMostrar.Image = global::Presentacion.Properties.Resources.eye_icon_md;
            this.pcbMostrar.Location = new System.Drawing.Point(221, 196);
            this.pcbMostrar.Name = "pcbMostrar";
            this.pcbMostrar.Size = new System.Drawing.Size(20, 18);
            this.pcbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMostrar.TabIndex = 16;
            this.pcbMostrar.TabStop = false;
            this.pcbMostrar.Click += new System.EventHandler(this.pcbMostrar_Click);
            // 
            // pcbOcultar2
            // 
            this.pcbOcultar2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbOcultar2.Image = global::Presentacion.Properties.Resources.eyeslash;
            this.pcbOcultar2.Location = new System.Drawing.Point(221, 249);
            this.pcbOcultar2.Name = "pcbOcultar2";
            this.pcbOcultar2.Size = new System.Drawing.Size(20, 20);
            this.pcbOcultar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOcultar2.TabIndex = 17;
            this.pcbOcultar2.TabStop = false;
            this.pcbOcultar2.Click += new System.EventHandler(this.pcbOcultar2_Click);
            // 
            // pcbMostrar2
            // 
            this.pcbMostrar2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pcbMostrar2.Image = global::Presentacion.Properties.Resources.eye_icon_md;
            this.pcbMostrar2.Location = new System.Drawing.Point(221, 251);
            this.pcbMostrar2.Name = "pcbMostrar2";
            this.pcbMostrar2.Size = new System.Drawing.Size(20, 18);
            this.pcbMostrar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMostrar2.TabIndex = 18;
            this.pcbMostrar2.TabStop = false;
            this.pcbMostrar2.Click += new System.EventHandler(this.pcbMostrar2_Click);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(309, 374);
            this.Controls.Add(this.pcbMostrar2);
            this.Controls.Add(this.pcbOcultar2);
            this.Controls.Add(this.pcbMostrar);
            this.Controls.Add(this.pcbOcultar);
            this.Controls.Add(this.lblErrorPass);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creacion de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOcultar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMostrar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblErrorPass;
        private System.Windows.Forms.PictureBox pcbOcultar;
        private System.Windows.Forms.PictureBox pcbMostrar;
        private System.Windows.Forms.PictureBox pcbOcultar2;
        private System.Windows.Forms.PictureBox pcbMostrar2;
    }
}