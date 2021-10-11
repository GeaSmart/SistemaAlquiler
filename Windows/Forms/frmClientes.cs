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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusqueda busqueda = new frmBusqueda();

            var result = busqueda.ShowDialog();
            if (result == DialogResult.OK)
            {
                int val = busqueda.Id;
                //this.txtCelular.Text = val.ToString();
                CargarCliente(val);
                this.btnGuardar.Text = "Actualizar";
            }
        }

        private void CargarCliente(int id)
        {
            var cliente = context.Clientes.FirstOrDefault(x => x.Id == id);
            this.txtId.Text = cliente.Id.ToString();
            this.txtNombres.Text = cliente.Nombres;
            this.txtApellidos.Text = cliente.Apellidos;
            this.txtRazonSocial.Text = cliente.RazonSocial;
            this.txtDocumento.Text = cliente.Documento;
            this.txtDireccion.Text = cliente.Direccion;
            this.txtCelular.Text = cliente.Celular;
            this.pictureBox1.Image = Utils.Utils.ByteArrayToImage(cliente.Imagen1);
            this.pictureBox2.Image = Utils.Utils.ByteArrayToImage(cliente.Imagen2);
            this.pictureBox3.Image = Utils.Utils.ByteArrayToImage(cliente.Imagen3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
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

            if (this.btnGuardar.Text.Equals("Guardar"))
            {
                var cliente = new ClienteEntity
                {
                    Documento = this.txtDocumento.Text,
                    Apellidos = this.txtApellidos.Text,
                    Nombres = this.txtNombres.Text,
                    RazonSocial = this.txtRazonSocial.Text,
                    Direccion = this.txtDireccion.Text,
                    Celular = this.txtCelular.Text,
                    Imagen1 = Utils.Utils.ImageToByteArray(this.pictureBox1.Image),
                    Imagen2 = Utils.Utils.ImageToByteArray(this.pictureBox2.Image),
                    Imagen3 = Utils.Utils.ImageToByteArray(this.pictureBox3.Image)
                };
                context.Clientes.Add(cliente);
            }
            else
            {
                int id = Convert.ToInt32(this.txtId.Text);
                var clientex = context.Clientes.FirstOrDefault(x => x.Id == id);
                clientex.Documento = this.txtDocumento.Text;
                clientex.Apellidos = this.txtApellidos.Text;
                clientex.Nombres = this.txtNombres.Text;
                clientex.RazonSocial = this.txtRazonSocial.Text;
                clientex.Direccion = this.txtDireccion.Text;
                clientex.Celular = this.txtCelular.Text;
                clientex.Imagen1 = Utils.Utils.ImageToByteArray(this.pictureBox1.Image);
                clientex.Imagen2 = Utils.Utils.ImageToByteArray(this.pictureBox2.Image);
                clientex.Imagen3 = Utils.Utils.ImageToByteArray(this.pictureBox3.Image);

                //context.SaveChanges();                
            }            
            context.SaveChanges();
        }
    }
}
