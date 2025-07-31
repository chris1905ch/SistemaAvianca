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
            FormAeropuerto frm = new FormAeropuerto();
            frm.ShowDialog();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes f = new FormClientes();
            f.ShowDialog();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {
            FormVuelos f = new FormVuelos();
            f.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            FormReservas frm = new FormReservas();
            frm.ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            FormCheckIn frm = new FormCheckIn();
            frm.ShowDialog();
        }
        
        private void btnEquipaje_Click(object sender, EventArgs e)
        {
            FormEquipaje frm = new FormEquipaje();
            frm.ShowDialog();
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

        private void btnTarifas_Click(object sender, EventArgs e)
        {
            FormTarifas frm = new FormTarifas();
            frm.ShowDialog();
        }
    }
    }

