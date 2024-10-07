using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Admin
    {
        
        private CD_Admin admin = new CD_Admin();

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

        // METODOS
        public DataTable ObtenerUsuarios()
        {
            return admin.ObtenerUsuarios();
        }

        public void EliminarUsuario(string idUsuario)
        {
            admin.ElimiinarUsuario(idUsuario);
        }

    }
}
