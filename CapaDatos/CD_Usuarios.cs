using System;
using System.Data.OleDb;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuarios
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
        public int IdUsuarios { 
            get => idUsuarios;  
            set { idUsuarios = value; } 
        }
        public string Nombre
        {
            get => nombre;
            set { nombre = value; }
        }
        public string Apellido { 
            get => apellido;
            set {  apellido = value; }
        }

        public string Correo
        {
            get => correo;
            set { correo = value; }
        }
        public string Contrasena {
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

        # region Metodos
        public void RegistrarUsuarios()
        {
            string sSql = "INSERT INTO Datos (Nombre, Apellido, Correo, Contraseña, ConfirmContraseña, Rol) " +
                          "VALUES (@Nombre, @Apellido, @Correo, @Contrasena, @ConfirmContrasena, @Rol)";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                // Agregar los parámetros con sus valores
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                cmd.Parameters.AddWithValue("@ConfirmContrasena", confirmContrasena);
                cmd.Parameters.AddWithValue("@Rol", rol);

                // Ejecuta el comando
                cmd.ExecuteNonQuery();
            }

            // Cerrar la conexión
            conexion.CerrarConexion();
        }

        public bool LoginUsuarios(string correo, string contrasena)
        {
            string sSql = "SELECT COUNT(*) FROM Datos WHERE Correo = @Correo AND Contraseña = @Contrasena";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                int count = (int)cmd.ExecuteScalar();
                conexion.CerrarConexion();

                return count > 0;
            }
        }
        public void GenerarCodigoRecuperacion(string correo, string codigo)
        {
            string sSql = "UPDATE Datos SET CodigoRecuperacion = @Codigo WHERE Correo = @Correo";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Correo", correo);

                cmd.ExecuteNonQuery();

            }
            conexion.CerrarConexion();
        }

        public bool CambiarContrasena(string correo, string codigo, string nuevaContrasena)
        {
            string sSql = "SELECT COUNT(*) FROM Datos WHERE Correo = @Correo AND CodigoRecuperacion = @Codigo";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    string updateSql = "UPDATE Datos SET Contraseña = @NuevaContrasena, ConfirmContraseña = @NuevaContrasena, CodigoRecuperacion = NULL WHERE Correo = @Correo";
                    cmd.CommandText = updateSql;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@NuevaContrasena", nuevaContrasena);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.ExecuteNonQuery();

                    conexion.CerrarConexion();
                    return true;
                }

                conexion.CerrarConexion();
                return false;
            }
        }

        public string ObtenerRol(string correo)
        {
            string sSql = "SELECT Rol FROM Datos WHERE Correo = @Correo";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@Correo", correo);

                string rol = (string )cmd.ExecuteScalar();
                conexion.CerrarConexion();

                return rol;
            }
        }

        #endregion
    }
}
