using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Entities;
using Windows.Model;

namespace Windows.Forms
{
    public partial class frmCambiarContraseña : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmCambiarContraseña()
        {
            InitializeComponent();
        }

        private void frmCambiarContraseña_Load(object sender, EventArgs e)
        {
            var usuarios = UserModel.Obtener();
            this.cmbUsuario.DataSource = usuarios.Data;
            this.cmbUsuario.DisplayMember = "Username";
            this.cmbUsuario.ValueMember = "Id";
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new UserEntity { Id = Convert.ToInt32(this.cmbUsuario.SelectedValue.ToString()), Password = this.txtContraseñaNueva.Text };

                var response = UserModel.Guardar(usuario).Response;
                if (response)
                {
                    MessageBox.Show("La contraseña fue actualizada!");
                }
                else
                {
                    MessageBox.Show("No se pudo cambiar la contraseña, intente nuevamente y verifique");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
