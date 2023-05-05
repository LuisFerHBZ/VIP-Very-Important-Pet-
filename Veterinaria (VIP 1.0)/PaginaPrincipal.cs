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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        public void btnUsuario_Click(object sender, EventArgs e)
        {
            PaginaUsuario formularioNuevo = new PaginaUsuario();
            //this.Hide();
            formularioNuevo.Show();
            //formularioNuevo.FormClosed += (s, args) => this.Close();

        }

        public void btnMascota_Click(object sender, EventArgs e)
        {
            PaginaMascota formularioNuevo = new PaginaMascota();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        public void btnVentas_Click(object sender, EventArgs e)
        {
            PaginaVentas formularioNuevo = new PaginaVentas();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void LLsMedico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServicioVeterinario formularioNuevo = new ServicioVeterinario();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void LLsEstetico_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServicioEstetico formularioNuevo = new ServicioEstetico();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }
    }
}
