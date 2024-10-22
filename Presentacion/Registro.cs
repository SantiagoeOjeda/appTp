using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Registro : Form
    {
        CN_Usuarios Usuario = new CN_Usuarios();
        public Registro()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '*';
            txtContraseñaConfirm.PasswordChar = '*';
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContraseña.Text != txtContraseñaConfirm.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                if (txtCorreoR.Text == "santi@gmail.com")
                {
                    Usuario.Rol = "admin";
                }
                else
                {
                    Usuario.Rol = "user";
                }

                PasarDatos();
                Usuario.RegistrarUsuarios();

                MessageBox.Show("Usuario registrado correctamente");
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
            Usuario.Apellido = txtApellido.Text;
            Usuario.Nombre = txtNombre.Text;
            Usuario.Correo = txtCorreoR.Text;
            Usuario.Contrasena = txtContraseña.Text;
            Usuario.ConfirmContrasena = txtContraseñaConfirm.Text;
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
                txtCorreoR.ForeColor = Color.Black;
                lblErrorCorreo.Visible = false;
            }
        }
    }
}
