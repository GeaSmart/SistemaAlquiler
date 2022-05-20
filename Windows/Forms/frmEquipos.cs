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
    public partial class frmEquipos : DevComponents.DotNetBar.Metro.MetroForm
    {
        public frmEquipos()
        {
            InitializeComponent();
        }
        bool isSearchMode = true;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtCodigo.Text = "";
            this.txtTipo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtSerie.Text = "";
            this.txtMarca.Text = "";
            this.txtModelo.Text = "";
            this.picImagen.Image = null;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.nudPrecioBaseDia.Value = 0;

            cargarMarcas();
            isSearchMode = false;
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            this.btnNuevo.PerformClick();
            cargarMarcas();
            cargarTipos();
        }
        private void cargarMarcas()
        {
            var listadoMarcas = ConfigModel.Obtener("MARCA").Data;
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            foreach (ConfigEntity item in listadoMarcas)
            {
                coleccion.Add(item.Value);
            }
            this.txtMarca.AutoCompleteCustomSource = coleccion;
        }

        private void cargarTipos()
        {
            var listadoMarcas = ConfigModel.Obtener("TIPO").Data;
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            foreach (ConfigEntity item in listadoMarcas)
            {
                coleccion.Add(item.Value);
            }
            this.txtTipo.AutoCompleteCustomSource = coleccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = this.txtId.Text.Length > 0 ? Convert.ToInt32(this.txtId.Text) : 0;

            var equipo = new EquipoEntity
            {
                Id = id,
                Codigo = this.txtCodigo.Text,
                Tipo = this.txtTipo.Text,
                Descripcion = this.txtDescripcion.Text,
                Serie = this.txtSerie.Text,
                Marca = this.txtMarca.Text,
                Modelo = this.txtModelo.Text,
                Imagen = Utils.Utils.ImageToByteArray(this.picImagen.Image),
                PrecioBaseDia=this.nudPrecioBaseDia.Value
            };

            var response = EquipoModel.Guardar(equipo);
            if (response.Response)
            {                
                procesarMarcas(new ConfigEntity { Value = equipo.Marca });
                procesarTipos(new ConfigEntity { Value = equipo.Tipo });
                MessageBox.Show("El registro fue guardado");
                this.btnNuevo.PerformClick();
                isSearchMode = false;
                cargarMarcas();
                cargarTipos();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }

        void procesarMarcas(ConfigEntity entidad)
        {
            ConfigModel.GuardarMarca(entidad);
            ConfigModel.EliminarMarcasDuplicadas();
        }

        void procesarTipos(ConfigEntity entidad)
        {
            ConfigModel.GuardarTipo(entidad);
            ConfigModel.EliminarTiposDuplicadas();
        }

        private void btnCarga_Click(object sender, EventArgs e)
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
                this.picImagen.Image = Image.FromFile(dialog.FileName); //Configuracion.ScaleImage(Image.FromFile(dialog.FileName), 210, 210);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaEquipo busqueda = new frmBusquedaEquipo();

            var result = busqueda.ShowDialog();
            if (result == DialogResult.OK)
            {
                int val = busqueda.Id;
                isSearchMode = true;
                CargarEquipo(val);
                this.btnGuardar.Text = "Actualizar";
                this.btnGuardar.Enabled = true;
                this.btnEliminar.Enabled = true;                
            }
        }

        private void CargarEquipo(int id)
        {
            var equipo = EquipoModel.Obtener(id).Data;

            this.txtId.Text = equipo.Id.ToString();
            this.txtCodigo.Text = equipo.Codigo;
            this.txtTipo.Text = equipo.Tipo;
            this.txtDescripcion.Text = equipo.Descripcion;
            this.txtSerie.Text = equipo.Serie;
            this.txtMarca.Text = equipo.Marca;
            this.txtModelo.Text = equipo.Modelo;
            this.picImagen.Image = Utils.Utils.ByteArrayToImage(equipo.Imagen);
            this.nudPrecioBaseDia.Value = equipo.PrecioBaseDia;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = this.txtId.Text.Length > 0 ? Convert.ToInt32(this.txtId.Text) : 0;
            var response = EquipoModel.Eliminar(id);
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

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            if (!isSearchMode)
            {
                if (this.txtTipo.Text.Length >= 3)
                {
                    this.txtCodigo.Text = this.txtTipo.Text.Substring(0, 3) + getLastId(this.txtTipo.Text);
                }
                else
                {
                    this.txtCodigo.Text = string.Empty;
                }
            }
        }

        private string getLastId(string tipo)
        {
            var response = (ConfigModel.GetLastId(tipo) + 1).ToString();

            switch (response.Length)
            {
                case 1:
                    response = "00" + response;
                    break;
                case 2:
                    response = "0" + response;
                    break;
            }
            return response;
        }

        private void btnRefrescarCodigo_Click(object sender, EventArgs e)
        {
            if (this.txtTipo.Text.Length >= 3)
                this.txtCodigo.Text = this.txtTipo.Text.Substring(0, 3) + getLastId(this.txtTipo.Text);
        }
    }
}
