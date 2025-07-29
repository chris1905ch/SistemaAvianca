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
    public partial class Vuelos : Form
    {
        private void FormVuelos_Load(object sender, EventArgs e)
        {
            CargarVuelos();
            // Carga rutas y aviones a ComboBox aquí si haces métodos DAL para eso
        }

        private void CargarVuelos()
        {
            dgvVuelos.DataSource = VueloDAL.ObtenerVuelos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vuelo v = new Vuelo
            {
                NumeroVuelo = txtNumero.Text,
                RutaID = Convert.ToInt32(cbRuta.SelectedValue),
                AvionID = Convert.ToInt32(cbAvion.SelectedValue),
                FechaSalida = dtSalida.Value,
                FechaLlegada = dtLlegada.Value,
                EstadoVuelo = cbEstado.Text
            };

            VueloDAL.AgregarVuelo(v);
            CargarVuelos();
        }
    }
}

