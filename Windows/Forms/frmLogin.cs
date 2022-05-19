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
using Windows.Utils;

namespace Windows.Forms
{
    public partial class frmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        private readonly frmPrincipal principal;
        UserModel model = new UserModel();
        public frmLogin(frmPrincipal principal)
        {
            this.principal = principal;

            InitializeComponent();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var credenciales = new UserEntity() { Username = this.txtUsuario.Text, Password = this.txtContrasena.Text };
            var response = UserModel.Check(credenciales).Data;


            if (this.txtUsuario.Text.Length > 0 && this.txtContrasena.Text.Length > 0)
            {
                if (response != null)
                {
                    this.principal.menuStrip1.Enabled = true;
                    this.principal.toolStrip1.Enabled = true;

                    this.principal.txtUsuario.Text = response.Username;
                    this.principal.txtIsAdmin.Text = response.IsAdmin == true ? "Admin" : "User";
                    this.principal.administraciónToolStripMenuItem.Visible = response.IsAdmin;
                    this.Close();
                }
                else
                {
                    this.txtMensaje.Text = "El Usuario o la contraseña es incorrecta.";
                    this.txtMensaje.ForeColor = Color.White;
                    this.stsMensaje.BackColor = Color.OrangeRed;
                }
            }
            else
            {
                this.txtMensaje.Text = "Ingrese todos los campos requeridos.";
                this.txtMensaje.ForeColor = Color.White;
                this.stsMensaje.BackColor = Color.Orange;
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && this.txtContrasena.Text.Length > 0)
            {
                this.btnLogin.PerformClick();
                this.txtContrasena.Text = String.Empty;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) && this.txtUsuario.Text.Length > 0)
            {
                this.txtContrasena.Focus();
            }
        }
    }
}
