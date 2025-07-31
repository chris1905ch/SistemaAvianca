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
using AviancaApp.Models;

namespace AviancaApp.Forms
{
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();
        }

        private void CargarClientes()
        {
            var clientes = ClienteDAL.ObtenerClientes();
            cbCliente.DataSource = clientes;
            cbCliente.DisplayMember = "Nombres";
            cbCliente.ValueMember = "ClienteID";
            cbCliente.SelectedIndex = -1;
        }

        private void CargarVuelos()
        {
            var vuelos = VueloDAL.ObtenerVuelos();
            cbVuelo.DataSource = vuelos;
            cbVuelo.DisplayMember = "NumeroVuelo";
            cbVuelo.ValueMember = "VueloID";
            cbVuelo.SelectedIndex = -1;
        }

        private void LimpiarFormulario()
        {
            
        }

        private void btnReservar_Click_1(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex == -1 || cbVuelo.SelectedIndex == -1 || cbTarifa.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione cliente, vuelo y tarifa.");
                return;
            }

            Reserva r = new Reserva
            {
                ClienteID = Convert.ToInt32(cbCliente.SelectedValue),
                VueloID = Convert.ToInt32(cbVuelo.SelectedValue),
                TarifaID = Convert.ToInt32(cbTarifa.SelectedValue),
                EstadoReserva = cbEstado.SelectedItem.ToString()
            };

            ReservaDAL.AgregarReserva(r);
            MessageBox.Show("Reserva creada correctamente");
            LimpiarFormulario();
        }

        private void cbVuelo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbVuelo.SelectedIndex != -1)
            {
                int vueloID = Convert.ToInt32(cbVuelo.SelectedValue);
                var tarifas = TarifaDAL.ObtenerTarifasPorVuelo(vueloID);

                cbTarifa.DataSource = tarifas;
                cbTarifa.DisplayMember = "Descripcion";  // Muestra: Clase + Precio + Asientos
                cbTarifa.ValueMember = "TarifaID";
                cbTarifa.SelectedIndex = -1;
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormReservas_Load_1(object sender, EventArgs e)
        {
            CargarClientes();
            CargarVuelos();

            // Cargar tarifas cuando se seleccione un vuelo
            cbVuelo.SelectedIndexChanged += cbVuelo_SelectedIndexChanged_1;

            // Estados fijos para la reserva
            cbEstado.Items.Add("Confirmada");
            cbEstado.Items.Add("Cancelada");
            cbEstado.SelectedIndex = 0;

            cbTarifa.DataSource = null; // Inicia vacío, se llena al seleccionar vuelo

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (cbCliente.SelectedIndex == -1 || cbVuelo.SelectedIndex == -1 || cbTarifa.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione cliente, vuelo y tarifa.");
                return;
            }

            Reserva r = new Reserva
            {
                ClienteID = Convert.ToInt32(cbCliente.SelectedValue),
                VueloID = Convert.ToInt32(cbVuelo.SelectedValue),
                TarifaID = Convert.ToInt32(cbTarifa.SelectedValue),
                EstadoReserva = cbEstado.SelectedItem.ToString(),
                FechaReserva = dtpFechaReserva.Value // <--- asegúrate de tener esta línea
            };

            ReservaDAL.AgregarReserva(r);
            MessageBox.Show("Reserva creada correctamente");
            LimpiarFormulario();

        }
    }
}
