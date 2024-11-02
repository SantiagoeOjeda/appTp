using CapaNegocio;
using System;
using System.Drawing;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoR.Text;

            if (String.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Debe ingresar el correo");
            }
            else
            {
                try
                {
                    if (!usuarios.ExisteCorreo(correo))
                    {
                        MessageBox.Show("El correo ingresado no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string codigo = usuarios.GenerarCodigoRecuperacion(correo);
                    MessageBox.Show("El código es: " + codigo);

                    // Habilitar los campos para ingresar el código y la nueva contraseña
                    txtCodigoI.Enabled = true;
                    txtNuevaContrasena.Enabled = true;
                    txtConfirmNuevaContrasena.Enabled = true;
                    btnCambiarPass.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el código de recuperación: " + ex.Message);
                }
            }
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoR.Text;
            string codigo = txtCodigoI.Text;
            string nuevaContrasena = txtNuevaContrasena.Text;
            string confirmarContrasena = txtConfirmNuevaContrasena.Text;

            if (String.IsNullOrEmpty(codigo) || String.IsNullOrEmpty(nuevaContrasena) || String.IsNullOrEmpty(confirmarContrasena))
            {
                MessageBox.Show("Complete todos los campos para cambiar su contraseña");
                return;
            }
            else if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifica.");
                return;
            }
            ValidarCorreo validarCorreo = new ValidarCorreo();
            validarCorreo.Correo = txtCorreoR.Text;
            if (!validarCorreo.Valid())
            {
                MessageBox.Show("El correo ingresado no es válido.");
                return;
            }

            // Validación de contraseña
            ValidarPass validarPass = new ValidarPass();
            validarPass.Contrasena = txtNuevaContrasena.Text;
            if (!validarPass.Valid())
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, una mayúscula y un número.");
                return;
            }

            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la contraseña: " + ex.Message);
            }
        }

        private void txtNuevaContrasena_TextChanged(object sender, EventArgs e)
        {
            ValidarPass val = new ValidarPass();
            val.Contrasena = txtNuevaContrasena.Text;
            if (val.Valid() != true)
            {
                txtNuevaContrasena.ForeColor = Color.Red;
                lblErrorPass.Visible = true;
                lblErrorPass.Text = "Minimo 8 caracteres, 1 mayuscula y 1 numero";
                lblErrorPass.ForeColor = Color.Red;
            }
            else
            {
                txtNuevaContrasena.ForeColor = Color.Black;
                lblErrorPass.Visible = false;
            }
        }

        private void pcbMostrar_Click(object sender, EventArgs e)
        {
            pcbOcultar.BringToFront();

            txtNuevaContrasena.PasswordChar = '\0';
        }

        private void pcbOcultar_Click(object sender, EventArgs e)
        {
            pcbMostrar.BringToFront();

            txtNuevaContrasena.PasswordChar = '*';
        }

        private void pcbOcultar2_Click(object sender, EventArgs e)
        {
            pcbMostrar2.BringToFront();

            txtConfirmNuevaContrasena.PasswordChar = '*';
        }

        private void pcbMostrar2_Click(object sender, EventArgs e)
        {
            pcbOcultar2.BringToFront();

            txtConfirmNuevaContrasena.PasswordChar = '\0';
        }
    }
}
