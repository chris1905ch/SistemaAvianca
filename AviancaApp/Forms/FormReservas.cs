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
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Reserva r = new Reserva
            {
                ClienteID = Convert.ToInt32(cbCliente.SelectedValue),
                VueloID = Convert.ToInt32(cbVuelo.SelectedValue),
                TarifaID = Convert.ToInt32(cbTarifa.SelectedValue),
                EstadoReserva = cbEstado.Text
            };

            ReservaDAL.AgregarReserva(r);
            MessageBox.Show("Reserva creada correctamente");
        }
    }
}
