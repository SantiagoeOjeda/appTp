using CapaDatos;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class CrearUsuario : Form
    {
        CN_Usuarios usuario = new CN_Usuarios();
        public CrearUsuario()
        { 
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            cmbRol.Items.Clear();
            cmbRol.Items.Add("admin");
            cmbRol.Items.Add("user");
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPass.PasswordChar = '*';
            txtConfirmPass.PasswordChar = '*';
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtFullname.Text) || String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtConfirmPass.Text) && String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(cmbRol.Text))
                {
                    MessageBox.Show("Los campos estan vacios");
                    return;
                }
                if (txtPass.Text != txtConfirmPass.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                ValidarCorreo validarCorreo = new ValidarCorreo();
                validarCorreo.Correo = txtEmail.Text;
                if (!validarCorreo.Valid())
                {
                    MessageBox.Show("El correo ingresado no es válido.");
                    return;
                }

                // Validación de contraseña
                ValidarPass validarPass = new ValidarPass();
                validarPass.Contrasena = txtPass.Text;
                if (!validarPass.Valid())
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres, una mayúscula y un número.");
                    return;
                }

                else
                {
                    PasarDatos();
                    usuario.CargarUsuarios();

                    MessageBox.Show("Usuario registrado correctamente");
                    HomeAdmin admin = new HomeAdmin();
                    admin.Show();
                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos por: \n" + ex.Message);
            }
        }

        private void PasarDatos()
        {
            usuario.Apellido = txtFullname.Text;
            usuario.Nombre = txtName.Text;
            usuario.Correo = txtEmail.Text;
            usuario.Contrasena = txtPass.Text;
            usuario.ConfirmContrasena = txtConfirmPass.Text;
            usuario.Rol = cmbRol.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidarCorreo val = new ValidarCorreo();
            val.Correo = txtEmail.Text;
            if (val.Valid() != true)
            {
                txtEmail.ForeColor = Color.Red;
                lblError.Visible = true;
                lblError.Text = "El mail no es valido";
                lblError.ForeColor = Color.Red;
            }
            else
            {
                txtEmail.ForeColor = Color.White;
                lblError.Visible = false;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            ValidarPass val = new ValidarPass();
            val.Contrasena = txtPass.Text;
            if (val.Valid() != true)
            {
                txtPass.ForeColor = Color.Red;
                lblErrorPass.Visible = true;
                lblErrorPass.Text = "Minimo 8 caracteres, 1 mayuscula y 1 numero";
                lblErrorPass.ForeColor = Color.Red;
            }
            else
            {
                txtPass.ForeColor = Color.White;
                lblErrorPass.Visible = false;
            }
        }

        private void pcbMostrar_Click(object sender, EventArgs e)
        {
            pcbOcultar.BringToFront();

            txtPass.PasswordChar = '\0';
        }

        private void pcbOcultar_Click(object sender, EventArgs e)
        {
            pcbMostrar.BringToFront();

            txtPass.PasswordChar = '*';
        }

        private void pcbOcultar2_Click(object sender, EventArgs e)
        {
            pcbMostrar2.BringToFront();

            txtConfirmPass.PasswordChar = '*';
        }

        private void pcbMostrar2_Click(object sender, EventArgs e)
        {
            pcbOcultar2.BringToFront();

            txtConfirmPass.PasswordChar = '\0';
        }
    }
}
