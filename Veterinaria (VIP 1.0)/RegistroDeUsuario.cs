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
    public partial class RegistroDeUsuario : Form
    {
        public RegistroDeUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            ResgistroDeMascota formularioNuevo = new ResgistroDeMascota();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }
    }
}
