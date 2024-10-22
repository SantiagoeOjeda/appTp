namespace Presentacion
{
    partial class HomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.chbEdicion = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtNombreA = new System.Windows.Forms.TextBox();
            this.txtApellidoA = new System.Windows.Forms.TextBox();
            this.txtCorreoA = new System.Windows.Forms.TextBox();
            this.txtContraseñaA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.ColumnHeadersVisible = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 144);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(490, 150);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // chbEdicion
            // 
            this.chbEdicion.AutoSize = true;
            this.chbEdicion.Location = new System.Drawing.Point(17, 309);
            this.chbEdicion.Name = "chbEdicion";
            this.chbEdicion.Size = new System.Drawing.Size(102, 17);
            this.chbEdicion.TabIndex = 1;
            this.chbEdicion.Text = "Habilitar Edicion";
            this.chbEdicion.UseVisualStyleBackColor = true;
            this.chbEdicion.CheckedChanged += new System.EventHandler(this.chbEdicion_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(396, 309);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(12, 9);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(56, 13);
            this.lblUsuarios.TabIndex = 3;
            this.lblUsuarios.Text = "Usuarios";
            // 
            // cmbRol
            // 
            this.cmbRol.Enabled = false;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(380, 56);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(106, 21);
            this.cmbRol.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rol";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(380, 99);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(106, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtNombreA
            // 
            this.txtNombreA.Enabled = false;
            this.txtNombreA.Location = new System.Drawing.Point(29, 57);
            this.txtNombreA.Name = "txtNombreA";
            this.txtNombreA.Size = new System.Drawing.Size(100, 20);
            this.txtNombreA.TabIndex = 15;
            // 
            // txtApellidoA
            // 
            this.txtApellidoA.Enabled = false;
            this.txtApellidoA.Location = new System.Drawing.Point(202, 57);
            this.txtApellidoA.Name = "txtApellidoA";
            this.txtApellidoA.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoA.TabIndex = 16;
            // 
            // txtCorreoA
            // 
            this.txtCorreoA.Enabled = false;
            this.txtCorreoA.Location = new System.Drawing.Point(202, 99);
            this.txtCorreoA.Name = "txtCorreoA";
            this.txtCorreoA.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoA.TabIndex = 17;
            // 
            // txtContraseñaA
            // 
            this.txtContraseñaA.Enabled = false;
            this.txtContraseñaA.Location = new System.Drawing.Point(29, 100);
            this.txtContraseñaA.Name = "txtContraseñaA";
            this.txtContraseñaA.Size = new System.Drawing.Size(100, 20);
            this.txtContraseñaA.TabIndex = 18;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(514, 354);
            this.Controls.Add(this.txtContraseñaA);
            this.Controls.Add(this.txtCorreoA);
            this.Controls.Add(this.txtApellidoA);
            this.Controls.Add(this.txtNombreA);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblUsuarios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.chbEdicion);
            this.Controls.Add(this.dgvUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeAdmin";
            this.Text = "Panel De Administrador";
            this.Load += new System.EventHandler(this.HomeAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.CheckBox chbEdicion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtNombreA;
        private System.Windows.Forms.TextBox txtApellidoA;
        private System.Windows.Forms.TextBox txtCorreoA;
        private System.Windows.Forms.TextBox txtContraseñaA;
    }
}