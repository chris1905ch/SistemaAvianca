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

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormLogin login = new FormLogin();
            login.Show();
        }
    }
}
