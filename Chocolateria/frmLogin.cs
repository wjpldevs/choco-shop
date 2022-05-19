using System;
using System.Windows.Forms;

namespace Chocolateria
{
    public partial class frmLogin : Form
    {
        frmInfo info;
        frmPrincipal principal;
        frmLogin login;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Click_btnIngresar(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtUsuario.Text) || string.IsNullOrEmpty(this.txtContrasena.Text))
                {
                    MessageBox.Show("Por favor ingrese datos válidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtContrasena.Clear();
                    this.txtUsuario.Clear();
                    this.txtUsuario.Focus();
                }
                else
                {
                    this.txtContrasena.Clear();
                    this.txtUsuario.Clear();
                    this.Hide();
                    principal = new frmPrincipal();
                    principal.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido el siguiente\nerror al tratar de ingresar al sistema: "+ex), "No se pudo ingresar al sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtContrasena.Clear();
                this.txtUsuario.Clear();
                this.txtUsuario.Focus();
            }
        }

        private void btnIngresar_Hover(object sender, EventArgs e)
        {
            this.btnIngresar.Height = 119;
            this.btnIngresar.Width = 112;
        }

        private void btnIngresar_Leave(object sender, EventArgs e)
        {
            this.btnIngresar.Height = 109;
            this.btnIngresar.Width = 102;
        }

        private void Click_btnMinimizar(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Click_btnCerrar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Click_btnInfo(object sender, EventArgs e)
        {
            this.Hide();
            info = new frmInfo();
            info.Show();
        }

        private void btnMinimizar_Hover(object sender, EventArgs e)
        {
            this.btnMinimizar.Height = 57;
            this.btnMinimizar.Width = 53;
        }

        private void btnMinimizar_Leave(object sender, EventArgs e)
        {
            this.btnMinimizar.Height = 56;
            this.btnMinimizar.Width = 52;
        }

        private void btnCerrar_Hover(object sender, EventArgs e)
        {
            this.btnCerrar.Height = 57;
            this.btnCerrar.Width = 53;
        }

        private void btnCerrar_Leave(object sender, EventArgs e)
        {
            this.btnCerrar.Height = 56;
            this.btnCerrar.Width = 52;
        }

        private void btnInfo_Hover(object sender, EventArgs e)
        {
            this.btnInfo.Height = 57;
            this.btnInfo.Width = 53;
        }

        private void btnInfo_Leave(object sender, EventArgs e)
        {
            this.btnInfo.Height = 56;
            this.btnInfo.Width = 53;
        }
    }
}
