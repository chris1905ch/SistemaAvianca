using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AviancaApp.DAL;
using AviancaApp.Models;

namespace AviancaApp.Forms
{
    public partial class FormEmpleados : Form
    {
        private void LimpiarCampos()
        {
            throw new NotImplementedException();
        }
        public FormEmpleados()
        {
            InitializeComponent();
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            throw new NotImplementedException();
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = EmpleadoDAL.ObtenerEmpleados();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado
            {
                Nombres = txtNombres.Text.Trim(),
                Apellidos = txtApellidos.Text.Trim(),
                Rol = txtRol.Text.Trim()
            };

            EmpleadoDAL.Insertar(emp);
            CargarEmpleados();
            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                Empleado emp = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                emp.Nombres = txtNombres.Text.Trim();
                emp.Apellidos = txtApellidos.Text.Trim();
                emp.Rol = txtRol.Text.Trim();

                EmpleadoDAL.Actualizar(emp);
                CargarEmpleados();
                LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                Empleado emp = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                EmpleadoDAL.Eliminar(emp.EmpleadoID);
                CargarEmpleados();
                LimpiarCampos();
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.CurrentRow != null)
            {
                Empleado emp = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                txtNombres.Text = emp.Nombres;
                txtApellidos.Text = emp.Apellidos;
                txtRol.Text = emp.Rol;
            }
        }
    }
}
