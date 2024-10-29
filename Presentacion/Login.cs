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
            txtContraseñaL.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoL.Text;
            string contrasena = txtContraseñaL.Text;

            if (usuarios.Login(correo, contrasena))
            {
                MessageBox.Show("Inicio de sesión exitoso");

                string rol = usuarios.ObtenerRol(correo);

                if(rol == "admin")
                {
                    HomeAdmin homeAdmin = new HomeAdmin();
                    homeAdmin.Show();
                }
                else if(rol == "user")
                {
                    HomeUser homeUser = new HomeUser(correo); 
                    homeUser.Show();    
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos erroneos");
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
