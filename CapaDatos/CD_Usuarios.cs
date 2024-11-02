using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    #region Clase usurario
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Rol { get; set; }
    }
    #endregion
    public class CD_Usuarios : CD_Conexion
    {

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

        #region Metodos
        public void RegistrarUsuarios()
        {
            try
            {
                string sSql = "INSERT INTO Datos (Nombre, Apellido, Correo, Contraseña, ConfirmContraseña, Rol) " +
                              "VALUES (@Nombre, @Apellido, @Correo, @Contrasena, @ConfirmContrasena, @Rol)";

                using (OleDbCommand cmd = new OleDbCommand(sSql, AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@ConfirmContrasena", confirmContrasena);
                    cmd.Parameters.AddWithValue("@Rol", "user");

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
            finally
            {
               CerrarConexion();
            }
        }

        public bool LoginUsuarios(string correo, string contrasena)
        {
            try
            {
                string sSql = "SELECT COUNT(*) FROM Datos WHERE Correo = @Correo AND Contraseña = @Contrasena";

                using (OleDbCommand cmd = new OleDbCommand(sSql, AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void GenerarCodigoRecuperacion(string correo, string codigo)
        {
            try
            {
                string sSql = "UPDATE Datos SET CodigoRecuperacion = @Codigo WHERE Correo = @Correo";

                using (OleDbCommand cmd = new OleDbCommand(sSql, AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@Correo", correo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar código de recuperación: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool CambiarContrasena(string correo, string codigo, string nuevaContrasena)
        {
            try
            {
                string sSql = "SELECT COUNT(*) FROM Datos WHERE Correo = @Correo AND CodigoRecuperacion = @Codigo";

                using (OleDbCommand cmd = new OleDbCommand(sSql, AbrirConexion()))
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

                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cambiar la contraseña: " + ex.Message);
                return false;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public string ObtenerRol(string correo)
        {
            try
            {
                string sSql = "SELECT Rol FROM Datos WHERE Correo = @Correo";

                using (OleDbCommand cmd = new OleDbCommand(sSql, AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);

                    string rol = (string)cmd.ExecuteScalar();
                    return rol;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el rol: " + ex.Message);
                return null;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public Usuario ObtenerUsuarioPorCorreo(string correo)
        {
            try
            {
                string sSql = "SELECT Nombre, Rol FROM Datos WHERE Correo = @Correo";

                using (OleDbCommand cmd = new OleDbCommand(sSql, AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                Nombre = reader["Nombre"].ToString(),
                                Rol = reader["Rol"].ToString()
                            };
                            return usuario;
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado en la base de datos.");
                            return null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el usuario: " + ex.Message);
                return null;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public DataTable ObtenerUsuarios()
        {
            try
            {
                string sSql = "SELECT ID, Nombre, Apellido, Correo, Contraseña, Rol FROM Datos ORDER BY ID ASC";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sSql, AbrirConexion());

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la lista de usuarios: " + ex.Message);
                return null;
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void ElimiinarUsuario(string idUsuario)
        {
            try
            {
                string sSql = "DELETE FROM Datos WHERE ID = @ID";

                using (OleDbCommand cmd = new OleDbCommand(sSql, AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@ID", idUsuario);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void AcutualizarUsuario(int idUsuario, string nombre, string apellido, string correo, string contrasena, string rol)
        {
            try
            {
                string sSql = "UPDATE Datos SET Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Contraseña = @Contrasena, ConfirmContraseña = @Contrasena, Rol = @Rol WHERE ID = @ID";

                using (OleDbCommand cmd = new OleDbCommand(sSql, AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@Rol", rol);
                    cmd.Parameters.AddWithValue("@ID", idUsuario);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public bool ExisteCorreo(string correo)
        {
            bool existe = false;

            try
            {
                    string sSql = "SELECT COUNT(*) FROM Datos WHERE Correo = @correo";
                using (OleDbCommand comando = new OleDbCommand(sSql, AbrirConexion()))
                {
                    comando.Parameters.AddWithValue("@correo", correo);

                    int count = (int)comando.ExecuteScalar();
                    existe = count > 0;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar el correo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CerrarConexion();
            }

            return existe;
        }
        public void CargarUsuarios()
        {
            try
            {
                string sSql = "INSERT INTO Datos (Nombre, Apellido, Correo, Contraseña, ConfirmContraseña, Rol) " +
                              "VALUES (@Nombre, @Apellido, @Correo, @Contrasena, @ConfirmContrasena, @Rol)";

                using (OleDbCommand cmd = new OleDbCommand(sSql, AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@ConfirmContrasena", confirmContrasena);
                    cmd.Parameters.AddWithValue("@Rol", rol);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
            finally
            {
                CerrarConexion();
            }
        }

        #endregion
    }
}
