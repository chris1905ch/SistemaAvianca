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

namespace AviancaApp
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = ClienteDAL.ObtenerClientes();
        }

        private void LimpiarCampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtDocumento.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente
            {
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Email = txtEmail.Text,
                NumeroDocumento = txtDocumento.Text
            };

            ClienteDAL.AgregarCliente(c);
            CargarClientes();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                Cliente c = new Cliente
                {
                    ClienteID = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ClienteID"].Value),
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    Email = txtEmail.Text,
                    NumeroDocumento = txtDocumento.Text
                };

                ClienteDAL.ActualizarCliente(c);
                CargarClientes();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ClienteID"].Value);
                ClienteDAL.EliminarCliente(id);
                CargarClientes();
                LimpiarCampos();
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtNombres.Text = dgvClientes.CurrentRow.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = dgvClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtEmail.Text = dgvClientes.CurrentRow.Cells["Email"].Value.ToString();
                txtDocumento.Text = dgvClientes.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
            }
        }
    }
}
