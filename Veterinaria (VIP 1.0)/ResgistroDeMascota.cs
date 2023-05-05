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
    public partial class ResgistroDeMascota : Form
    {
        public ResgistroDeMascota()
        {
            InitializeComponent();
        }

        private void btnOmitir_Click(object sender, EventArgs e)
        {
            InicioDeSesion formularioNuevo = new InicioDeSesion();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            InicioDeSesion formularioNuevo = new InicioDeSesion();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }
    }
}
