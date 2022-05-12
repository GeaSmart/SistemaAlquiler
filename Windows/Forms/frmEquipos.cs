﻿using System;
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
    public partial class frmEquipos : Form
    {
        public frmEquipos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Text = "";
            this.cmbTipo.SelectedIndex = -1;
            this.txtDescripcion.Text = "";
            this.txtSerie.Text = "";
            this.cmbMarca.SelectedIndex = -1;
            this.cmbModelo.SelectedIndex = -1;
            this.picImagen.Image = null;
            this.cmbEstado.SelectedIndex = -1;

            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Enabled = true;
            this.btnEliminar.Enabled = false;

        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            this.btnNuevo.PerformClick();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = this.txtId.Text.Length > 0 ? Convert.ToInt32(this.txtId.Text) : 0;

            var equipo = new EquipoEntity
            {
                Id = id,
                Codigo = this.txtCodigo.Text,
                Tipo = (this.cmbTipo.SelectedItem == null) ? "" : this.cmbTipo.SelectedItem.ToString(),
                Descripcion = this.txtDescripcion.Text,
                Serie = this.txtSerie.Text,
                Marca = (this.cmbMarca.SelectedItem == null) ? "" : this.cmbMarca.SelectedItem.ToString(),
                Modelo = (this.cmbModelo.SelectedItem == null) ? "" : this.cmbModelo.SelectedItem.ToString(),
                IsDisponible = this.rbtnSi.Checked ? true : false,
                Imagen = Utils.Utils.ImageToByteArray(this.picImagen.Image),
                Estado = (this.cmbEstado.SelectedItem == null) ? "DISPONIBLE" : this.cmbEstado.SelectedItem.ToString(),
            };

            var response = EquipoModel.Guardar(equipo);
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
            this.cmbTipo.SelectedItem = equipo.Tipo;
            this.txtDescripcion.Text = equipo.Descripcion;
            this.txtSerie.Text = equipo.Serie;
            this.cmbMarca.SelectedItem = equipo.Marca;
            this.cmbModelo.SelectedItem = equipo.Modelo;
            this.rbtnSi.Checked = equipo.IsDisponible;
            this.rbtnNo.Checked = !equipo.IsDisponible;
            this.picImagen.Image = Utils.Utils.ByteArrayToImage(equipo.Imagen);
            this.cmbEstado.SelectedItem = equipo.Estado;
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
    }
}
