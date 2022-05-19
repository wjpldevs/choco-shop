using System;
using System.Windows.Forms;

namespace Chocolateria
{
    public partial class frmInfo : Form
    {
        public frmInfo()
        {
            InitializeComponent();
        }

        frmPrincipal principal;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal = new frmPrincipal();
            principal.Show();
        }
    }
}
