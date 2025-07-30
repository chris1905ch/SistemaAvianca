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
            CargarRutas();
        }

        private void CargarRutas()
        {
            var rutas = RutaDAL.ObtenerTodas(); 
            dgvRutas.DataSource = rutas;        
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Ruta r = new Ruta
            {
                Origen = txtOrigen.Text,
                Destino = txtDestino.Text,
                Duracion = txtDuracion.Text
            };

            RutaDAL.Agregar(r);
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

            Ruta r = new Ruta
            {
                RutaID = rutaIdSeleccionada,
                Origen = txtOrigen.Text,
                Destino = txtDestino.Text,
                Duracion = txtDuracion.Text
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
                txtOrigen.Text = fila.Cells["Origen"].Value.ToString();
                txtDestino.Text = fila.Cells["Destino"].Value.ToString();
                txtDuracion.Text = fila.Cells["Duracion"].Value.ToString();
            }
        }
        private void Limpiar()
        {
            throw new NotImplementedException();
            txtOrigen.Clear();
            txtDestino.Clear();
            txtDuracion.Clear();
            rutaIdSeleccionada = -1;
        }
    }
}
