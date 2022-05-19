using System;
using System.Windows.Forms;

namespace Chocolateria
{
    public partial class frmDesarroladores : Form
    {
        public frmDesarroladores()
        {
            InitializeComponent();
        }

        frmPrincipal principal;

        #region Botones
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal = new frmPrincipal();
            principal.Show();
        }

        private void frmDesarroladores_Load(object sender, EventArgs e)
        {
            // void
        }
        #endregion
    }
}
