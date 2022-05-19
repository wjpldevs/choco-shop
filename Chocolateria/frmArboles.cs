using System;
using System.Windows.Forms;

namespace Chocolateria
{
    public partial class frmArboles : Form
    {
        public frmArboles()
        {
            InitializeComponent();
        }

        #region Variables de instancia
        private bool bin = false, activado = false;
        private Arbol ab;
        private frmPrincipal principal;
        #endregion

        #region PictureBox

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ab = new Arbol(this);
            bin = true;
            activado = true;
            this.txtNombre.Clear();
            this.txtCodigo.Clear();
            this.txtCantidad.Clear();
            this.txtFechaVencimiento.Clear();
            this.txtPrecio.Clear();
            this.cboTipoProducto.ResetText();
            this.txtEliminar.Clear();
            dtgProductos.Rows.Clear();
            MessageBox.Show("Se ha creado el árbol binario.\n\nPuede empezar a ingresar datos.");
            this.txtNombre.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ab = new Arbol(this);
            bin = false;
            activado = true;
            this.txtNombre.Clear();
            this.txtCodigo.Clear();
            this.txtCantidad.Clear();
            this.txtFechaVencimiento.Clear();
            this.txtPrecio.Clear();
            this.cboTipoProducto.ResetText();
            this.txtEliminar.Clear();
            dtgProductos.Rows.Clear();
            MessageBox.Show("Se ha creado el árbol balanceado.\n\nPuede empezar a ingresar datos.");
            this.txtNombre.Focus();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (activado)
            {
                dtgProductos.Rows.Clear();
                ab.Preorden(ab.raiz);
                MessageBox.Show("Recorrido realizado por código");
            }
            else
                MessageBox.Show(string.Format("No se ha creado un árbol todavia\nCree un árbol e intente nuevamente."), "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (activado)
            {
                dtgProductos.Rows.Clear();
                ab.InOrden(ab.raiz);
                MessageBox.Show("Recorrido realizado por código");
            }
            else
                MessageBox.Show(string.Format("No se ha creado un árbol todavia\nCree un árbol e intente nuevamente."), "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (activado)
            {
                dtgProductos.Rows.Clear();
                ab.Postorden(ab.raiz);
                MessageBox.Show("Recorrido realizado por código");
            }
            else
                MessageBox.Show(string.Format("No se ha creado un árbol todavia\nCree un árbol e intente nuevamente."), "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Botones

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtPrecio.Text) ||
                    string.IsNullOrEmpty(this.txtCodigo.Text) || string.IsNullOrEmpty(this.txtCantidad.Text)
                    || string.IsNullOrEmpty(this.txtFechaVencimiento.Text))
                {
                    MessageBox.Show(string.Format("Hay un valor que no validó o el registro está lleno\nPor favor verifique nuevamente."), "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtNombre.Focus();
                }
                else if (!activado)
                    MessageBox.Show(string.Format("No se ha creado un árbol todavia\nCree un árbol e intente nuevamente."), "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    object[] listaProductos = new object[6];
                    listaProductos[1] = this.txtNombre.Text;
                    listaProductos[0] = int.Parse(this.txtCodigo.Text);
                    listaProductos[2] = int.Parse(this.txtCantidad.Text);
                    listaProductos[3] = this.txtFechaVencimiento.Text;
                    listaProductos[4] = decimal.Parse(this.txtPrecio.Text);
                    listaProductos[5] = this.cboTipoProducto.Text;
                    if (bin)
                        ab.Insercion(ab.raiz, listaProductos);
                    else
                        ab.InsertarBalanceado(ab.raiz, listaProductos);

                    dtgProductos.Rows.Clear();
                    this.txtNombre.Clear();
                    this.txtCodigo.Clear();
                    this.txtCantidad.Clear();
                    this.txtFechaVencimiento.Clear();
                    this.txtPrecio.Clear();
                    this.cboTipoProducto.ResetText();
                    this.txtEliminar.Clear();
                    MessageBox.Show("Producto agregado exitosamente");
                    this.txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido el siguiente error: {0}", ex), "Error al agregar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtNombre.Clear();
                this.txtCodigo.Clear();
                this.txtCantidad.Clear();
                this.txtFechaVencimiento.Clear();
                this.txtPrecio.Clear();
                this.txtEliminar.Clear();
                this.txtNombre.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (activado)
            {
                if (ab.raiz != null)
                {
                    if (bin)
                        ab.Eliminacion(ab.raiz, int.Parse(txtEliminar.Text));
                    else
                        ab.EliminarElemento(int.Parse(txtEliminar.Text));
                    ab.auxc = null;
                    if (ab.eliminado)
                    {
                        MessageBox.Show("Se ha eliminado el producto");
                        ab.eliminado = false;
                    }
                    txtEliminar.Clear();
                    dtgProductos.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("El árbol está vacio");
                    txtEliminar.Clear();
                }
            }
            else
                MessageBox.Show(string.Format("No se ha creado un árbol todavia\nCree un árbol e intente nuevamente."), "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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

        #endregion

        #region Validaciones con eventos
        private void SoloTexto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true; return;
            }
        }

        private void SoloEntero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; return;
            }
        }

        private void SoloDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; return;
            }
        }
        #endregion

        #region Eventos de los picturebox

        private void pictureBox1_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox1.Height = 64;
            pictureBox1.Width = 186;
        }

        private void pictureBox1_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox1.Height = 69;
            pictureBox1.Width = 191;
        }

        private void btnAgregar_MouseHover_1(object sender, EventArgs e)
        {
            btnAgregar.Height = 57;
            btnAgregar.Width = 53;
        }

        private void btnAgregar_MouseLeave_1(object sender, EventArgs e)
        {
            btnAgregar.Height = 52;
            btnAgregar.Width = 48;
        }

        private void pictureBox3_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox5.Height = 100;
            pictureBox5.Width = 110;
        }

        private void pictureBox3_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox5.Height = 95;
            pictureBox5.Width = 105;
        }

        private void pictureBox4_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox4.Height = 100;
            pictureBox4.Width = 110;
        }

        private void pictureBox4_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox4.Height = 95;
            pictureBox4.Width = 105;
        }

        private void pictureBox5_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox3.Height = 100;
            pictureBox3.Width = 110;
        }

        private void pictureBox5_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox3.Height = 95;
            pictureBox3.Width = 105;
        }

        private void btnEliminar_MouseHover_1(object sender, EventArgs e)
        {
            btnEliminar.Height = 62;
            btnEliminar.Width = 57;
        }

        private void btnEliminar_MouseLeave_1(object sender, EventArgs e)
        {
            btnEliminar.Height = 57;
            btnEliminar.Width = 52;
        }

        private void pictureBox2_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox2.Height = 64;
            pictureBox2.Width = 186;
        }

        private void pictureBox2_MouseLeave_1(object sender, EventArgs e)
        {
            pictureBox2.Height = 69;
            pictureBox2.Width = 191;
        }

        #endregion

        #region Metodos adicionales
        public void Escribir(Producto nod)
        {
            dtgProductos.Rows.Add(nod.Nombre, nod.Codigo, nod.Cantidad, nod.FechaVencimiento, nod.Precio, nod.TipoProducto);
            return;
        }

        public void ErrorNodoExiste()
        {
            MessageBox.Show("El código ya existe en el arbol");
        }

        public void ErrorNodoNoExiste()
        {
            MessageBox.Show("No existe un producto con ese código");
        }
        #endregion

    }
}
