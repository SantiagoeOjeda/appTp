using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Registro : Form
    {
        CN_Usuarios usuario = new CN_Usuarios();
        public Registro()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
            txtContraseñaConfirm.PasswordChar = '*';
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de campos vacíos
                if (String.IsNullOrEmpty(txtApellido.Text) ||
                    String.IsNullOrEmpty(txtCorreoR.Text) ||
                    String.IsNullOrEmpty(txtContraseña.Text) ||
                    String.IsNullOrEmpty(txtContraseñaConfirm.Text) ||
                    String.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Los campos están vacíos");
                    return;
                }

                // Validación de coincidencia de contraseñas
                if (txtContraseña.Text != txtContraseñaConfirm.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                // Validación de correo
                ValidarCorreo validarCorreo = new ValidarCorreo();
                validarCorreo.Correo = txtCorreoR.Text;
                if (!validarCorreo.Valid())
                {
                    MessageBox.Show("El correo ingresado no es válido.");
                    return;
                }

                // Validación de contraseña
                ValidarPass validarPass = new ValidarPass();
                validarPass.Contrasena = txtContraseña.Text;
                if (!validarPass.Valid())
                {
                    MessageBox.Show("La contraseña debe tener al menos 8 caracteres, una mayúscula y un número.");
                    return;
                }

                // Si todas las validaciones son exitosas, proceder con el registro
                PasarDatos();
                usuario.RegistrarUsuarios();

                MessageBox.Show("Usuario registrado correctamente");

                // Mostrar la pantalla de Login
                Login login = new Login();
                login.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los datos por: \n" + ex.Message);
            }
        }
        private void PasarDatos()
        {
            usuario.Apellido = txtApellido.Text;
            usuario.Nombre = txtNombre.Text;
            usuario.Correo = txtCorreoR.Text;
            usuario.Contrasena = txtContraseña.Text;
            usuario.ConfirmContrasena = txtContraseñaConfirm.Text;
        }

        private void txtCorreoR_TextChanged(object sender, EventArgs e)
        {
            ValidarCorreo val = new ValidarCorreo();
            val.Correo = txtCorreoR.Text;
            if (val.Valid() != true)
            {
                txtCorreoR.ForeColor = Color.Red;
                lblErrorCorreo.Visible = true;
                lblErrorCorreo.Text = "El mail no es valido";
                lblErrorCorreo.ForeColor = Color.Red;
            }
            else
            {
                txtCorreoR.ForeColor = Color.White;
                lblErrorCorreo.Visible = false;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarPass val = new ValidarPass();
            val.Contrasena = txtContraseña.Text;
            if (val.Valid() != true)
            {
                txtContraseña.ForeColor = Color.Red;
                lblErrorPass.Visible = true;
                lblErrorPass.Text = "Minimo 8 caracteres, 1 mayuscula y 1 numero";
                lblErrorPass.ForeColor = Color.Red;
            }
            else
            {
                txtContraseña.ForeColor= Color.White;
                lblErrorPass.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pcbOcultar.BringToFront();

            txtContraseña.PasswordChar = '\0';
        }

        private void pcbOcultar_Click(object sender, EventArgs e)
        {
            pcbMostrar.BringToFront();

            txtContraseña.PasswordChar = '*';
        }

        private void pcbMostrar21_Click(object sender, EventArgs e)
        {
            pcbOcultar2.BringToFront();

            txtContraseñaConfirm.PasswordChar = '\0';
        }

        private void pcbOcultar2_Click(object sender, EventArgs e)
        {
            pcbMostrar21.BringToFront();

            txtContraseñaConfirm.PasswordChar = '*';
        }
    }
}
