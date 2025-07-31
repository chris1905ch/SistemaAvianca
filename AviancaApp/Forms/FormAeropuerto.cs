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
using AviancaApp.DAL;

namespace AviancaApp.Forms
{
    public partial class FormAeropuerto : Form
    {
        public FormAeropuerto()
        {
            InitializeComponent();
            Cargar();
        }
        private void Cargar()
        {
            dgvAeropuertos.DataSource = null;
            dgvAeropuertos.DataSource = AeropuertoDAL.Obtener();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtCodigoIATA.Clear();
            txtCiudad.Clear();
            txtPais.Clear();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            var a = new Aeropuerto
            {
                Nombre = txtNombre.Text.Trim(),
                CodigoIATA = txtCodigoIATA.Text.Trim(),
                Ciudad = txtCiudad.Text.Trim(),
                Pais = txtPais.Text.Trim()
            };
            AeropuertoDAL.Insertar(a);
            Cargar();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAeropuertos.CurrentRow != null)
            {
                var a = (Aeropuerto)dgvAeropuertos.CurrentRow.DataBoundItem;
                a.Nombre = txtNombre.Text.Trim();
                a.CodigoIATA = txtCodigoIATA.Text.Trim();
                a.Ciudad = txtCiudad.Text.Trim();
                a.Pais = txtPais.Text.Trim();
                AeropuertoDAL.Actualizar(a);
                Cargar();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAeropuertos.CurrentRow != null)
            {
                var a = (Aeropuerto)dgvAeropuertos.CurrentRow.DataBoundItem;
                AeropuertoDAL.Eliminar(a.AeropuertoID);
                Cargar();
                Limpiar();
            }
        }

        private void dgvAeropuertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAeropuertos.CurrentRow != null)
            {
                var a = (Aeropuerto)dgvAeropuertos.CurrentRow.DataBoundItem;
                txtNombre.Text = a.Nombre;
                txtCodigoIATA.Text = a.CodigoIATA;
                txtCiudad.Text = a.Ciudad;
                txtPais.Text = a.Pais;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAeropuerto_Load(object sender, EventArgs e)
        {

        }
    }

}

