using CapaNegocio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class HomeAdmin : Form
    {
        CN_Admin admin = new CN_Admin();
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            LlenarDataGriedView();
        }

        private void LlenarDataGriedView()
        {
            dgvUsuarios.DataSource = admin.ObtenerUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvUsuarios.SelectedRows.Count > 0)
            {
                string idUsuario = dgvUsuarios.SelectedRows[0].Cells["ID"].Value.ToString();

                DialogResult result = MessageBox.Show("¿Estas seguro de eliminar este usuario?", "Confirmar eliminacion", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {

                    admin.EliminarUsuario(idUsuario);

                    LlenarDataGriedView();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para eliminar");
            }
        }

        private void chbEdicion_CheckedChanged(object sender, EventArgs e)
        {
            bool habilitar = chbEdicion.Checked;

            txtNombreA.Enabled = habilitar;
            txtCorreoA.Enabled = habilitar;   
            txtContraseñaA.Enabled = habilitar; 
            txtApellidoA.Enabled = habilitar;
            cmbRol.Enabled = habilitar;
        }

        //private void CargarRoles()
        //{
            
        //    //cmbRol.SelectedIndex = 0;
        //}

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUsuarios.SelectedRows[0];
                txtNombreA.Text = row.Cells["Nombre"].Value.ToString();
                txtCorreoA.Text = row.Cells["Apellido"].Value.ToString();
                txtContraseñaA.Text = row.Cells["Correo"].Value.ToString();
                txtApellidoA.Text = row.Cells["Contraseña"].Value.ToString();


                cmbRol.Items.Clear();
                cmbRol.Items.Add("admin");
                cmbRol.Items.Add("user");
                string rolActual = row.Cells["Rol"].Value.ToString();
                cmbRol.SelectedItem = rolActual;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(dgvUsuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["ID"].Value);

                string nombre = txtNombreA.Text;
                string apellido = txtApellidoA.Text;
                string correo = txtCorreoA.Text;    
                string contrasena = txtContraseñaA.Text;
                string rol = cmbRol.SelectedItem.ToString();    

                admin.ActualizarUsuario(idUsuario, nombre, apellido, correo, contrasena, rol);

                MessageBox.Show("Actualizado");

                LlenarDataGriedView();
            }
        }
    }
}
