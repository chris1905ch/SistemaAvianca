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
    public partial class FormEquipaje : Form
    {
        public FormEquipaje()
        {
            InitializeComponent();
        }

        private void FormEquipaje_Load(object sender, EventArgs e)
        {
            CargarReservas();
            cbTipo.Items.Add("De mano");
            cbTipo.Items.Add("Facturado");
            cbTipo.SelectedIndex = 0;
            var reservas = ReservaDAL.ObtenerReservas();
            cbReserva.DataSource = reservas;
            cbReserva.DisplayMember = "ReservaID"; // O lo que quieras mostrar
            cbReserva.ValueMember = "ReservaID";
        }

        private void CargarReservas()
        {
            var reservas = ReservaDAL.ObtenerReservas(); // Debes tener este método ya creado
            cbReserva.DataSource = reservas;
            cbReserva.DisplayMember = "ReservaID";
            cbReserva.ValueMember = "ReservaID";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbReserva.SelectedIndex == -1 || cbTipo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtPeso.Text, out decimal peso))
            {
                MessageBox.Show("Peso inválido.");
                return;
            }

            Equipaje eObj = new Equipaje
            {
                ReservaID = Convert.ToInt32(cbReserva.SelectedValue),
                TipoEquipaje = cbTipo.SelectedItem.ToString(),
                Peso = peso
            };

            EquipajeDAL.AgregarEquipaje(eObj);
            MessageBox.Show("Equipaje registrado correctamente.");
            txtPeso.Clear();
        }
    }
}
