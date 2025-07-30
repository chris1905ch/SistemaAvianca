using System;
using AviancaApp.DAL;
using AviancaApp.Models;
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
    public partial class FormTripulacion : Form
    {
        private object txtVueloID;

        public FormTripulacion()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
           dataGridView1.DataSource = TripulacionDAL.ObtenerTodos();
        }

        private void FormTripulacion_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Tripulacion t = new Tripulacion
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Cargo = txtCargo.Text,
                VueloID = int.Parse(txtIDVuelo.Text)
            };

            TripulacionDAL.Insertar(t);
            CargarDatos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCargo.Text = "";
            txtIDVuelo.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Tripulacion t = (Tripulacion)dataGridView1.CurrentRow.DataBoundItem;
                t.Nombre = txtNombre.Text;
                t.Apellido = txtApellido.Text;
                t.Cargo = txtCargo.Text;
                t.VueloID = int.Parse(txtIDVuelo.Text);

                TripulacionDAL.Actualizar(t);
                CargarDatos();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Tripulacion t = (Tripulacion)dataGridView1.CurrentRow.DataBoundItem;
                TripulacionDAL.Eliminar(t.TripulacionID);
                CargarDatos();
                LimpiarCampos();
            }
        }


        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                Tripulacion t = (Tripulacion)dataGridView1.CurrentRow.DataBoundItem;
                txtNombre.Text = t.Nombre;
                txtApellido.Text = t.Apellido;
                txtCargo.Text = t.Cargo;
                txtIDVuelo.Text = t.VueloID.ToString();
            }
        }

         
    }
}
