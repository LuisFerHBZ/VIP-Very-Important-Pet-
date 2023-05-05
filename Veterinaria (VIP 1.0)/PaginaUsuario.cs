using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria__VIP_1._0_
{
    public partial class PaginaUsuario : Form
    {
        public PaginaUsuario()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            PaginaPrincipal formularioNuevo = new PaginaPrincipal();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            PaginaMascota formularioNuevo = new PaginaMascota();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            PaginaVentas formularioNuevo = new PaginaVentas();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }
    }
}

