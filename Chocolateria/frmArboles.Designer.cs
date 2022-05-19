namespace Chocolateria
{
    partial class frmArboles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Chocolate;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.Location = new System.Drawing.Point(142, 206);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 32);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtNombre, "Nombre del producto");
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloTexto);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Chocolate;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigo.Location = new System.Drawing.Point(585, 206);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(182, 32);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtCodigo, "Código del producto");
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEntero);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Chocolate;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCantidad.Location = new System.Drawing.Point(897, 206);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(287, 32);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtCantidad, "Cantidad del producto");
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEntero);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Chocolate;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecio.Location = new System.Drawing.Point(585, 244);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(182, 32);
            this.txtPrecio.TabIndex = 6;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtPrecio, "Precio del producto");
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloDecimal);
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.BackColor = System.Drawing.Color.Chocolate;
            this.cboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoProducto.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Items.AddRange(new object[] {
            "Barras",
            "Bombón",
            "Botonetas",
            "Caramelo",
            "Chocobanano",
            "Galletas",
            "Paleta",
            "Pastel",
            "Pudin"});
            this.cboTipoProducto.Location = new System.Drawing.Point(1003, 244);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(181, 37);
            this.cboTipoProducto.Sorted = true;
            this.cboTipoProducto.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cboTipoProducto, "Tipo de producto");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Chocolateria.Properties.Resources.boton_binario;
            this.pictureBox1.Location = new System.Drawing.Point(285, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Utilizar arboles binarios");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave_1);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Chocolateria.Properties.Resources.boton_balanceado;
            this.pictureBox2.Location = new System.Drawing.Point(833, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Utilizar arboles balanceados");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave_1);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover_1);
            // 
            // dtgProductos
            // 
            this.dtgProductos.BackgroundColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.NullValue = "???";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgProductos.GridColor = System.Drawing.Color.SandyBrown;
            this.dtgProductos.Location = new System.Drawing.Point(29, 300);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.Size = new System.Drawing.Size(916, 316);
            this.dtgProductos.TabIndex = 10;
            this.toolTip1.SetToolTip(this.dtgProductos, "Registros de los productos");
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 230;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de vencimiento";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tipo de producto";
            this.Column6.Name = "Column6";
            this.Column6.Width = 140;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = global::Chocolateria.Properties.Resources._1478662985_plus_add_green2;
            this.btnAgregar.Location = new System.Drawing.Point(1193, 215);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(52, 48);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar");
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave_1);
            this.btnAgregar.MouseHover += new System.EventHandler(this.btnAgregar_MouseHover_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Chocolateria.Properties.Resources.boton_preorden;
            this.pictureBox3.Location = new System.Drawing.Point(953, 300);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Recorrido preorden");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave_1);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Chocolateria.Properties.Resources.boton_inorden;
            this.pictureBox4.Location = new System.Drawing.Point(953, 413);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(95, 105);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "Recorrido Inorden");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave_1);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Chocolateria.Properties.Resources.boton_postorden;
            this.pictureBox5.Location = new System.Drawing.Point(953, 524);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(95, 92);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "Recorrido Postorden");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave_1);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Chocolateria.Properties.Resources.eliminar_por_codigo2;
            this.pictureBox6.Location = new System.Drawing.Point(1088, 300);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(145, 146);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::Chocolateria.Properties.Resources._1479211604_RecycleBin_Empty1;
            this.btnEliminar.Location = new System.Drawing.Point(1136, 490);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 52);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEliminar, "Borrar dato por el código");
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave_1);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_MouseHover_1);
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.Color.Chocolate;
            this.txtEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEliminar.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEliminar.Location = new System.Drawing.Point(1070, 452);
            this.txtEliminar.Multiline = true;
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(182, 32);
            this.txtEliminar.TabIndex = 18;
            this.txtEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtEliminar, "Ingrese el código del producto");
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = global::Chocolateria.Properties.Resources.back;
            this.btnRegresar.Location = new System.Drawing.Point(1187, 558);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(58, 41);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRegresar, "Regresar al menú principal");
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Chocolateria.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1078, 558);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 42);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar la aplicación");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.BackColor = System.Drawing.Color.Chocolate;
            this.txtFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaVencimiento.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVencimiento.Location = new System.Drawing.Point(322, 245);
            this.txtFechaVencimiento.Mask = "00/00/0000";
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(144, 31);
            this.txtFechaVencimiento.TabIndex = 21;
            this.toolTip1.SetToolTip(this.txtFechaVencimiento, "Fecha de vencimiento del producto");
            this.txtFechaVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::Chocolateria.Properties.Resources.pantalla_arboles2;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArboles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArboles";
            this.TransparencyKey = System.Drawing.Color.Sienna;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.MaskedTextBox txtFechaVencimiento;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}