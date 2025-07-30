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
    public partial class FormMenu : Form
    {
        private Usuario usuarioActual;

        public FormMenu(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido, {usuarioActual.UsuarioNombre} ({usuarioActual.Rol})";
        }

        private void btnAeropuertos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá la gestión de Aeropuertos");

        }

        private void btnAviones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá la gestión de Aviones");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá la gestión de Clientes");
            FormClientes f = new FormClientes();
            f.ShowDialog();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá la gestión de Vuelos");
            FormVuelos f = new FormVuelos();
            f.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá la gestión de Reservas");
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá la gestión de Check-in");
        }
        
        private void btnEquipaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí se abrirá la gestión de Equipaje");
        }

        private void btnCerrarSesion_Click_2(object sender, EventArgs e)
        {
            this.Close();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            FormRuta frm = new FormRuta();
            frm.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados frm = new FormEmpleados();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAviones frm = new FormAviones();
            frm.ShowDialog();
        }
    }
    }

