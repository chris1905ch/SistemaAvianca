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
    public partial class FormCheckIn : Form
    {
        public FormCheckIn()
        {
            InitializeComponent();
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {

        }
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckIn c = new CheckIn
            {
                ReservaID = Convert.ToInt32(cbReserva.SelectedValue),
                NumeroAsientoAsignado = txtAsiento.Text
            };

            CheckInDAL.RegistrarCheckIn(c);
            MessageBox.Show("Check-In realizado");
        }
    }
}
