using CapaDatos;
using System;
using static CapaDatos.CD_Usuarios;
namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios usuario = new CD_Usuarios();

        //atributos
        #region Atributos
        private int idUsuarios;
        private string nombre;
        private string apellido;
        private string correo;
        private string contrasena;
        private string confirmContrasena;
        private string rol;
        #endregion

        //properties
        #region Properties

        public int IdUsuarios
        {
            get => idUsuarios;
            set { idUsuarios = value; }
        }
        public string Nombre
        {
            get => nombre;
            set { nombre = value; }
        }

        public string Apellido
        {
            get => apellido;
            set { apellido = value; }
        }

        public string Correo
        {
            get => correo;
            set { correo = value; }
        }
        public string Contrasena
        {
            get => contrasena;
            set { contrasena = value; }
        }
        public string ConfirmContrasena
        {
            get => confirmContrasena;
            set { confirmContrasena = value; }
        }

        public string Rol
        {
            get => rol;
            set { rol = value; }
        }

        #endregion

        //Metodos
        #region Metodos
        public void RegistrarUsuarios()
        {
            PasarDatos();
            usuario.RegistrarUsuarios();
        }

        public bool Login(string correo, string contrasen)
        {
            return usuario.LoginUsuarios(correo, contrasen);
        }

        public string GenerarCodigoRecuperacion(string correo)
        {
            Random random = new Random();
            string codigo = random.Next(1000, 9999).ToString();  
            usuario.GenerarCodigoRecuperacion(correo, codigo);
            return codigo;
        }

        public bool CambiarContrasena(string correo, string codigo, string nuevaContrasena)
        {
            return usuario.CambiarContrasena(correo, codigo, nuevaContrasena);
        }

        public string ObtenerRol(string correo)
        {
            return usuario.ObtenerRol(correo);
        }

        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            return usuario.ObtenerUsuarioPorCorreo(correo);
        }
        private void PasarDatos()
        {
            usuario.IdUsuarios = idUsuarios;
            usuario.Nombre = this.nombre;
            usuario.Apellido = this.apellido;    
            usuario.Correo = this.correo;    
            usuario.Contrasena = this.contrasena;
            usuario.ConfirmContrasena = this.confirmContrasena;
            usuario.Rol = rol;
        }
        #endregion
    }
}
