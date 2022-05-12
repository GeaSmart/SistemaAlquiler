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
    public partial class frmClientes : Form
    {
        ApplicationDBContext context = new ApplicationDBContext();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.btnNuevo.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente busqueda = new frmBusquedaCliente();

            var result = busqueda.ShowDialog();
            if (result == DialogResult.OK)
            {
                int val = busqueda.Id;
                CargarCliente(val);
                this.btnGuardar.Text = "Actualizar";
                this.btnGuardar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }

        private void CargarCliente(int id)
        {
            var cliente = ClienteModel.Obtener(id).Data;

            this.txtId.Text = cliente.Id.ToString();
            this.txtNombres.Text = cliente.NombreCompleto;
            this.txtDocumento.Text = cliente.Documento;
            this.txtDireccion.Text = cliente.Direccion;
            this.txtCelular.Text = cliente.Celular;
            this.pictureBox1.Image = Utils.Utils.ByteArrayToImage(cliente.Imagen1);
            this.pictureBox2.Image = Utils.Utils.ByteArrayToImage(cliente.Imagen2);
            this.pictureBox3.Image = Utils.Utils.ByteArrayToImage(cliente.Imagen3);
        }

        private void btnCarga1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Todas las imágenes|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|BMP|*.bmp|GIF|*.gif|JPEG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
            dialog.Title = "Seleccione fotografía";
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName); //Configuracion.ScaleImage(Image.FromFile(dialog.FileName), 210, 210);
            }
        }

        private void btnCarga2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Todas las imágenes|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|BMP|*.bmp|GIF|*.gif|JPEG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
            dialog.Title = "Seleccione fotografía";
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(dialog.FileName); //Configuracion.ScaleImage(Image.FromFile(dialog.FileName), 210, 210);
            }
        }

        private void btnCarga3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Todas las imágenes|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|BMP|*.bmp|GIF|*.gif|JPEG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
            dialog.Title = "Seleccione fotografía";
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(dialog.FileName); //Configuracion.ScaleImage(Image.FromFile(dialog.FileName), 210, 210);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = this.txtId.Text.Length > 0 ? Convert.ToInt32(this.txtId.Text) : 0;

            var cliente = new ClienteEntity
            {
                Id = id,
                Documento = this.txtDocumento.Text,
                NombreCompleto = this.txtNombres.Text,
                Direccion = this.txtDireccion.Text,
                Celular = this.txtCelular.Text,
                Imagen1 = this.pictureBox1.Image != null? Utils.Utils.ImageToByteArray(this.pictureBox1.Image):null,
                Imagen2 = this.pictureBox1.Image != null ? Utils.Utils.ImageToByteArray(this.pictureBox2.Image) : null,
                Imagen3 = this.pictureBox1.Image != null ? Utils.Utils.ImageToByteArray(this.pictureBox3.Image) : null,
            };

            var response = ClienteModel.Guardar(cliente);
            if (response.Response)
            {
                MessageBox.Show("El registro fue guardado");
                this.btnNuevo.PerformClick();
            }
            else
            {
                MessageBox.Show(response.Message);
            }                
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = this.txtId.Text.Length > 0 ? Convert.ToInt32(this.txtId.Text) : 0;
            var response = ClienteModel.Eliminar(id);
            if (response.Response)
            {
                MessageBox.Show("Registro eliminado");
                this.btnNuevo.PerformClick();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtNombres.Text = "";
            this.txtDocumento.Text = "";
            this.txtDireccion.Text = "";
            this.txtCelular.Text = "";

            this.pictureBox1.Image = null;
            this.pictureBox2.Image = null;
            this.pictureBox3.Image = null;

            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Enabled = true;
            this.btnEliminar.Enabled = false;
        }
    }
}
