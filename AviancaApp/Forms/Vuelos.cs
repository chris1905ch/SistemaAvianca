using AviancaApp.DAL;
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
    public partial class FormVuelos : Form
    {
        public FormVuelos()
        {
            InitializeComponent();
        }

        private void FormVuelos_Load(object sender, EventArgs e)
        {
            // Cargar estados de vuelo
            cbEstadoVuelo.Items.Add("Programado");
            cbEstadoVuelo.Items.Add("En vuelo");
            cbEstadoVuelo.Items.Add("Cancelado");
            cbEstadoVuelo.SelectedIndex = 0;

            CargarRutas();
            CargarAviones();
            CargarVuelos();
        }

        private void CargarRutas()
        {
            var rutas = RutaDAL.ObtenerRutas();
            cbRuta.DataSource = rutas;
            cbRuta.DisplayMember = "Descripcion"; // Ejemplo: "Origen - Destino"
            cbRuta.ValueMember = "RutaID";
            cbRuta.SelectedIndex = -1;
        }

        private void CargarAviones()
        {
            var aviones = AvionDAL.ObtenerAviones();
            cbAvion.DataSource = aviones;
            cbAvion.DisplayMember = "Matricula";
            cbAvion.ValueMember = "AvionID";
            cbAvion.SelectedIndex = -1;
        }

        private void CargarVuelos()
        {
            List<Vuelo> vuelos = VueloDAL.ObtenerVuelos();
            dgvVuelos.DataSource = null;
            dgvVuelos.DataSource = vuelos;

            // Ocultar columnas que no quieres mostrar
            dgvVuelos.Columns["VueloID"].Visible = false;
            dgvVuelos.Columns["RutaID"].Visible = false;
            dgvVuelos.Columns["AvionID"].Visible = false;
        }

        private void btnAgregarVuelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumeroVuelo.Text) ||
                    cbRuta.SelectedIndex == -1 ||
                    cbAvion.SelectedIndex == -1 ||
                    cbEstadoVuelo.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Vuelo nuevoVuelo = new Vuelo
                {
                    NumeroVuelo = txtNumeroVuelo.Text.Trim(),
                    RutaID = Convert.ToInt32(cbRuta.SelectedValue),
                    AvionID = Convert.ToInt32(cbAvion.SelectedValue),
                    FechaSalida = dtpFechaSalida.Value,
                    FechaLlegada = dtpFechaLlegada.Value,
                    EstadoVuelo = cbEstadoVuelo.SelectedItem.ToString()
                };

                VueloDAL.AgregarVuelo(nuevoVuelo);
                MessageBox.Show("Vuelo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarVuelos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtNumeroVuelo.Clear();
            cbRuta.SelectedIndex = -1;
            cbAvion.SelectedIndex = -1;
            cbEstadoVuelo.SelectedIndex = 0;
            dtpFechaSalida.Value = DateTime.Now;
            dtpFechaLlegada.Value = DateTime.Now;
        }

        private void btnEliminarVuelo_Click(object sender, EventArgs e)
        {
            if (dgvVuelos.CurrentRow != null)
            {
                int vueloID = Convert.ToInt32(dgvVuelos.CurrentRow.Cells["VueloID"].Value);
                DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar el vuelo seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    VueloDAL.EliminarVuelo(vueloID);
                    MessageBox.Show("Vuelo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarVuelos();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un vuelo para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

