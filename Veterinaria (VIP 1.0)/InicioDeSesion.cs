namespace Veterinaria__VIP_1._0_
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void lLRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroDeUsuario formularioNuevo = new RegistroDeUsuario();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            PaginaPrincipal formularioNuevo = new PaginaPrincipal();
            this.Hide();
            formularioNuevo.Show();
            formularioNuevo.FormClosed += (s, args) => this.Close();
        }
    }
}