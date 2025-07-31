using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AviancaApp.Models;
using AviancaApp.DAL;
using System.Windows.Forms;


namespace AviancaApp.Forms
{
    public partial class FormRuta : Form
    {
        public FormRuta()
        {
            InitializeComponent();
        }

        private int rutaIdSeleccionada = -1;

        private void FormRuta_Load(object sender, EventArgs e)
        {
            var aeropuertos = AeropuertoDAL.Obtener();

            cmbOrigen.DataSource = aeropuertos;
            cmbOrigen.DisplayMember = "Nombre";
            cmbOrigen.ValueMember = "AeropuertoID";

            cmbDestino.DataSource = new List<Aeropuerto>(aeropuertos); // Copia independiente
            cmbDestino.DisplayMember = "Nombre";
            cmbDestino.ValueMember = "AeropuertoID";

            CargarRutas();
        }

        private void CargarRutas()
        {
            var rutas = RutaDAL.ObtenerTodas();
            dgvRutas.DataSource = null;
            dgvRutas.DataSource = rutas;
            // Opcional: Ocultar columnas si quieres
            // dgvRutas.Columns["AeropuertoOrigenID"].Visible = false;
            // dgvRutas.Columns["AeropuertoDestinoID"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex == -1 || cmbDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona el aeropuerto de origen y destino.");
                return;
            }

            Ruta r = new Ruta
            {
                AeropuertoOrigenID = (int)cmbOrigen.SelectedValue,
                AeropuertoDestinoID = (int)cmbDestino.SelectedValue
            };

            RutaDAL.Insertar(r);
            CargarRutas();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (rutaIdSeleccionada == -1)
            {
                MessageBox.Show("Selecciona una ruta primero");
                return;
            }

            if (cmbOrigen.SelectedIndex == -1 || cmbDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona el aeropuerto de origen y destino.");
                return;
            }

            Ruta r = new Ruta
            {
                RutaID = rutaIdSeleccionada,
                AeropuertoOrigenID = (int)cmbOrigen.SelectedValue,
                AeropuertoDestinoID = (int)cmbDestino.SelectedValue
            };

            RutaDAL.Actualizar(r);
            CargarRutas();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rutaIdSeleccionada == -1)
            {
                MessageBox.Show("Selecciona una ruta primero");
                return;
            }

            RutaDAL.Eliminar(rutaIdSeleccionada);
            CargarRutas();
            Limpiar();
        }

        private void dgvRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvRutas.Rows[e.RowIndex];
                rutaIdSeleccionada = Convert.ToInt32(fila.Cells["RutaID"].Value);

                // Asignar los valores de origen y destino en los combo boxes
                cmbOrigen.SelectedValue = Convert.ToInt32(fila.Cells["AeropuertoOrigenID"].Value);
                cmbDestino.SelectedValue = Convert.ToInt32(fila.Cells["AeropuertoDestinoID"].Value);
            }
        }

        private void Limpiar()
        {
            cmbOrigen.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            rutaIdSeleccionada = -1;
        }
    }
}
