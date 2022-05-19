using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chocolateria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        frmOrdenacion ordenacion;
        frmDesarroladores desarrolladores;
        frmInfo acercaDe;
        frmArboles arboles;
        frmGrafos grafos;

        private void btnOrdenacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            ordenacion = new frmOrdenacion();
            ordenacion.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            this.Hide();
            acercaDe = new frmInfo();
            acercaDe.Show();

        }

        private void btnDesarrolladores_Click(object sender, EventArgs e)
        {
            this.Hide();
            desarrolladores = new frmDesarroladores();
            desarrolladores.Show();
        }

        private void btnOrdenacion_Hover(object sender, EventArgs e)
        {
            this.btnOrdenacion.BackColor = Color.Coral;
        }

        private void btnOrdenacion_Leave(object sender, EventArgs e)
        {
            this.btnOrdenacion.BackColor = Color.Transparent;
        }

        private void btnArboles_Click(object sender, EventArgs e)
        {
            this.Hide();
            arboles = new frmArboles();
            arboles.Show();
        }

        private void btnGrafos_Click(object sender, EventArgs e)
        {
            this.Hide();
            grafos = new frmGrafos();
            grafos.Show();
        }
    }
}
