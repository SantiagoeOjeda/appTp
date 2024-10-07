using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Admin
    {
        CD_Conexion conexion = new CD_Conexion();
        OleDbDataReader DR;
        DataTable DT = new DataTable();
        OleDbCommand comando = new OleDbCommand();

        #region atributos
        private int idUsuarios;
        private string nombre;
        private string apellido;
        private string correo;
        private string contrasena;
        private string confirmContrasena;
        private string rol;
        #endregion

        #region properties
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

        #region Metodos

        public DataTable ObtenerUsuarios()
        {
            string sSql = "SELECT ID, Nombre, Apellido, Correo, Contraseña FROM Datos";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sSql,conexion.AbrirConexion());

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conexion.CerrarConexion();

            return dt;
        }

        public void ElimiinarUsuario(string idUsuario)
        {
            string sSql = "DELETE FROM Datos WHERE ID = @ID";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@ID", idUsuario);
                cmd.ExecuteNonQuery();
            }
            conexion.CerrarConexion();
        }

        #endregion
    }
}
