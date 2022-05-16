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
    public partial class frmLogin : Form
    {
        UserModel model = new UserModel();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var credenciales = new UserEntity() { Username = this.txtUsername.Text, Password = this.txtPassword.Text };
            MessageBox.Show(UserModel.Check(credenciales).Response.ToString());
        }
    }
}
