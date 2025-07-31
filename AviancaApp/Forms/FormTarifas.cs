using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviancaApp.Models;
using AviancaApp.DAL;
using System.Windows.Forms;

namespace AviancaApp.Forms
{
    public partial class FormTarifas : Form
    {
        private object txtAsientosDisponibles;

        public FormTarifas()
        {
            InitializeComponent();
        }

        private void FormTarifas_Load(object sender, EventArgs e)
        {
            CargarVuelos();
            CargarTarifas();
            cbClaseAsiento.Items.Add("Económica");
            cbClaseAsiento.Items.Add("Económica Premium");
            cbClaseAsiento.Items.Add("Business");
            cbClaseAsiento.Items.Add("Primera Clase");
            cbClaseAsiento.Items.Add("Turista");
            cbClaseAsiento.Items.Add("Ejecutiva");

            cbClaseAsiento.SelectedIndex = 0;

            cbAsientosDisponlibles.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                cbAsientosDisponlibles.Items.Add(i);
            }
            cbAsientosDisponlibles.SelectedIndex = 0;
        }

        private void CargarVuelos()
        {
            var vuelos = VueloDAL.ObtenerVuelos();
            cbVuelo.DataSource = vuelos;
            cbVuelo.DisplayMember = "NumeroVuelo";
            cbVuelo.ValueMember = "VueloID";
            cbVuelo.SelectedIndex = -1;
        }

        private void CargarTarifas()
        {
            dgvTarifas.DataSource = null;
            dgvTarifas.DataSource = TarifaDAL.ObtenerTodos();
        }

        private void LimpiarFormulario()
        {
            cbVuelo.SelectedIndex = -1;
            cbClaseAsiento.SelectedIndex = -1;
            txtPrecio.Clear();
            cbAsientosDisponlibles.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbVuelo.SelectedIndex == -1 || cbClaseAsiento.SelectedIndex == -1 ||
        string.IsNullOrWhiteSpace(txtPrecio.Text) || cbAsientosDisponlibles.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            Tarifa tarifa = new Tarifa
            {
                VueloID = Convert.ToInt32(cbVuelo.SelectedValue),
                ClaseAsiento = cbClaseAsiento.SelectedItem.ToString(),
                Precio = Convert.ToDecimal(txtPrecio.Text),
                AsientosDisponibles = Convert.ToInt32(cbAsientosDisponlibles.SelectedItem)
            };

            TarifaDAL.Agregar(tarifa);
            MessageBox.Show("Tarifa agregada correctamente.");
            CargarTarifas();
            LimpiarFormulario();
        }
    


private void dgvTarifas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTarifas.SelectedRows.Count > 0)
            {
                var row = dgvTarifas.SelectedRows[0];
                Tarifa t = (Tarifa)row.DataBoundItem;

                cbVuelo.SelectedValue = t.VueloID;
                cbClaseAsiento.SelectedItem = t.ClaseAsiento;
                txtPrecio.Text = t.Precio.ToString();
                cbAsientosDisponlibles.SelectedItem = t.AsientosDisponibles;
                cbClaseAsiento.Tag = t.TarifaID;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cbClaseAsiento.Tag == null)
            {
                MessageBox.Show("Seleccione una tarifa para actualizar.");
                return;
            }

            Tarifa t = new Tarifa
            {
                VueloID = Convert.ToInt32(cbVuelo.SelectedValue),
                ClaseAsiento = cbClaseAsiento.SelectedItem.ToString(),
                Precio = Convert.ToDecimal(txtPrecio.Text),
                AsientosDisponibles = Convert.ToInt32(cbAsientosDisponlibles.SelectedItem)
            };


            TarifaDAL.Actualizar(t);
            MessageBox.Show("Tarifa actualizada.");
            CargarTarifas();
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbClaseAsiento.Tag == null)
            {
                MessageBox.Show("Seleccione una tarifa para eliminar.");
                return;
            }

            int id = (int)cbClaseAsiento.Tag;
            TarifaDAL.Eliminar(id);
            MessageBox.Show("Tarifa eliminada.");
            CargarTarifas();
            LimpiarFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        
    }
}
