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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtPassword.Text.Trim();

            Usuario u = UsuarioDAL.ValidarLogin(usuario, clave);
            if (u != null)
            {
                MessageBox.Show($"Bienvenido {u.UsuarioNombre} ({u.Rol})", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormMenu menu = new FormMenu(u); // pasamos el usuario
                menu.Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

