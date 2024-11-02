using CapaNegocio;
using System;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form
    {
        CN_Usuarios usuarios = new CN_Usuarios();   
        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtContraseñaL.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correoI = txtCorreoL.Text;
            string contrasena = txtContraseñaL.Text;
            if (String.IsNullOrEmpty(correoI) || String.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Los campos están vacíos");
            }
            else
            {
                try
                {
                    if (usuarios.Login(correoI, contrasena))
                    {
                        MessageBox.Show("Inicio de sesión exitoso");

                        string rol;
                        try
                        {
                            rol = usuarios.ObtenerRol(correoI);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al obtener el rol del usuario: " + ex.Message);
                            return; 
                        }

                        if (rol == "admin")
                        {
                            HomeAdmin homeAdmin = new HomeAdmin();
                            homeAdmin.Show();
                        }
                        else if (rol == "user")
                        {
                            HomeUser homeUser = new HomeUser(correoI);
                            homeUser.Show();
                        }
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Datos erróneos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message);
                }
            }
        }

        private void btnRegistroL_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void lnkRecupero_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Recupero recupero = new Recupero();
            recupero.Show();
            this.Hide();
        }

        private void pcboxMostrar_Click_1(object sender, EventArgs e)
        {
            pcboxOcultar.BringToFront();

            txtContraseñaL.PasswordChar = '\0';
        }

        private void pcboxOcultar_Click(object sender, EventArgs e)
        {
            pcboxMostrar.BringToFront();

            txtContraseñaL.PasswordChar = '*';
        }
    }
}
