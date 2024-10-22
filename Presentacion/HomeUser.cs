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
    public partial class HomeUser : Form
    {
        CN_Usuarios user = new CN_Usuarios();

        private string correoLogin;
         public HomeUser(string correoLogin)
        {
            InitializeComponent();
            this.correoLogin = correoLogin;
        }
        private void imgPrincipal_Paint(object sender, PaintEventArgs e)
        {
            // Crear un gráfico circular
            System.Drawing.Drawing2D.GraphicsPath graphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            graphicsPath.AddEllipse(0, 0, imgPrincipal.Width - 1, imgPrincipal.Height - 1);

            // Aplicar el gráfico circular al PictureBox
            imgPrincipal.Region = new Region(graphicsPath);
        }

        private void HomeUser_Load(object sender, EventArgs e)
        {
            string correoUsuario = correoLogin; // Este valor podría provenir del formulario de login

            Usuario usuario = user.ObtenerUsuarioPorCorreo(correoUsuario);

            if (usuario != null)
            {
                txtName.Text = usuario.Nombre;
                txtRol.Text = usuario.Rol;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }
    }
}
