using CapaNegocio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Recupero : Form
    {
        CN_Usuarios usuarios = new CN_Usuarios();
        public Recupero()
        {
            InitializeComponent();
            txtNuevaContrasena.PasswordChar = '*';
            txtConfirmNuevaContrasena.PasswordChar = '*';   
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoR.Text;

            string codigo = usuarios.GenerarCodigoRecuperacion(correo);

            MessageBox.Show("El codigo es: " + codigo);
            txtCodigoI.Enabled = true;
            txtNuevaContrasena.Enabled = true;
            txtConfirmNuevaContrasena.Enabled = true;
            btnCambiarPass.Enabled = true;
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoR.Text;
            string codigo = txtCodigoI.Text;
            string nuevaContrasena = txtNuevaContrasena.Text;
            string confirmarContrasena = txtConfirmNuevaContrasena.Text;

            // Verificar que ambas contraseñas sean iguales antes de proceder
            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifica.");
                return;
            }

            // Si las contraseñas coinciden, llamamos al método para cambiar la contraseña
            if (usuarios.CambiarContrasena(correo, codigo, nuevaContrasena))
            {
                MessageBox.Show("Contraseña cambiada correctamente.");
                Login login = new Login();
                login.Show();
                this.Close();
            }
            else
            { 
                MessageBox.Show("El código ingresado no es correcto.");
            }
        }
    }
}
