﻿using CapaNegocio;
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
                    HomeUser homeUser = new HomeUser(); 
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
    }
}