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

                admin.EliminarUsuario(idUsuario);

                LlenarDataGriedView();
            }
            else
            {
                MessageBox.Show("Selecciona un usuario para eliminar");
            }
        }
    }
}
