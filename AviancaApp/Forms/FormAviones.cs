using AviancaApp.DAL;
using AviancaApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AviancaApp.Forms
{
    public partial class FormAviones : Form
    {
        public FormAviones()
        {
            InitializeComponent();
            cboEstado.Items.AddRange(new string[] { "Activo", "Inactivo" });
            cboEstado.SelectedIndex = 0;
            CargarAviones();
        }

        private void CargarAviones()
        {
            dgvAviones.DataSource = null;
            dgvAviones.DataSource = AvionDAL.ObtenerTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion
            {
                Modelo = txtModelo.Text,
                Capacidad = (int)numCapacidad.Value,
                Matricula = txtMatricula.Text,
                Estado = cboEstado.SelectedItem.ToString()
            };

            AvionDAL.Insertar(avion);
            CargarAviones();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAviones.CurrentRow != null)
            {
                Avion avion = (Avion)dgvAviones.CurrentRow.DataBoundItem;
                avion.Modelo = txtModelo.Text;
                avion.Capacidad = (int)numCapacidad.Value;
                avion.Matricula = txtMatricula.Text;
                avion.Estado = cboEstado.SelectedItem.ToString();

                AvionDAL.Actualizar(avion);
                CargarAviones();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAviones.CurrentRow != null)
            {
                Avion avion = (Avion)dgvAviones.CurrentRow.DataBoundItem;
                AvionDAL.Eliminar(avion.AvionID);
                CargarAviones();
                LimpiarCampos();
            }
        }

        private void dgvAviones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAviones.CurrentRow != null)
            {
                Avion avion = (Avion)dgvAviones.CurrentRow.DataBoundItem;
                AvionDAL.Eliminar(avion.AvionID);
                CargarAviones();
                LimpiarCampos();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtModelo.Clear();
            txtMatricula.Clear();
            numCapacidad.Value = 0;
            cboEstado.SelectedIndex = 0;
            dgvAviones.ClearSelection();
        }
    }
}
