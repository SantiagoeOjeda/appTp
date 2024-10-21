using System.Data.OleDb;
using System.Data;

namespace CapaDatos
{
    public class CD_Admin
    {
        CD_Conexion conexion = new CD_Conexion();
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
            string sSql = "SELECT ID, Nombre, Apellido, Correo, Contraseña, Rol FROM Datos ORDER BY ID ASC";
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

        public void AcutualizarUsuario(int idUsuario, string nombre, string apellido, string correo, string contrasena, string rol)
        {
            string sSql = "UPDATE Datos SET Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Contraseña = @Contrasena, ConfirmContraseña = @Contrasena, Rol = @Rol WHERE ID = @ID";

            using (OleDbCommand cmd = new OleDbCommand(sSql, conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                cmd.Parameters.AddWithValue("@Rol", rol);
                cmd.Parameters.AddWithValue("@ID", idUsuario);

                cmd.ExecuteNonQuery();
            }
            conexion.CerrarConexion();
        }

        #endregion
    }
}
