using AviancaApp.DAL;
using AviancaApp.DAL.AviancaApp.DAL;
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
    public partial class FormCheckIn : Form
    {
        private object reservas;

        public FormCheckIn()
        {
            InitializeComponent();
            cbReserva.SelectedIndexChanged += cbReserva_SelectedIndexChanged;
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {
            CargarReservas();
        }

        private void CargarReservas()
        {
            List<Reserva> reservas = ReservaDAL.ObtenerReservasPendientesCheckIn();

            cbReserva.DataSource = reservas;
            cbReserva.DisplayMember = "NombrePasajero";
            cbReserva.ValueMember = "ReservaID";
            cbReserva.SelectedIndex = -1;
        }


        private void btnCheckIn_Click_1(object sender, EventArgs e)
        {
            if (cbReserva.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una reserva para hacer check-in.");
                return;
            }

            if (cbAsiento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un asiento válido.");
                return;
            }

            int reservaID = Convert.ToInt32(cbReserva.SelectedValue);
            string asiento = cbAsiento.SelectedItem.ToString();

            if (CheckInDAL.ExisteCheckIn(reservaID))
            {
                MessageBox.Show("Esta reserva ya tiene check-in realizado.");
                return;
            }

            CheckIn c = new CheckIn
            {
                ReservaID = reservaID,
                NumeroAsientoAsignado = asiento
            };

            bool exito = CheckInDAL.RegistrarCheckIn(c);

            if (exito)
            {
                MessageBox.Show("Check-In realizado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al realizar el check-in.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReserva.SelectedIndex != -1 && cbReserva.SelectedValue != null && cbReserva.SelectedValue is int)
            {
                int reservaID = (int)cbReserva.SelectedValue;

                Reserva r = ReservaDAL.ObtenerReservas().FirstOrDefault(x => x.ReservaID == reservaID);

                if (r != null)
                {
                    LlenarAsientosDisponibles(r.VueloID);
                }
            }
        }


        private void LlenarAsientosDisponibles(int vueloID)
        {
            cbAsiento.DataSource = null;
            var lista = TarifaDAL.ObtenerAsientosDisponiblesPorVuelo(vueloID);
            cbAsiento.DataSource = lista;
        }

        private void cbAsiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbReserva.DataSource = ReservaDAL.ObtenerReservasPendientesCheckIn(); // o .ObtenerReservas()
            cbReserva.DisplayMember = "NombrePasajero";
            cbReserva.ValueMember = "ReservaID";
            cbReserva.SelectedIndex = -1;

        }
    }
}
