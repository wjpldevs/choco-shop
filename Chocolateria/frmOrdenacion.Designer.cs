namespace Chocolateria
{
    partial class frmOrdenacion
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
            this.txtIniciar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.btnOrdenar = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.PictureBox();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cboMetodos = new System.Windows.Forms.ComboBox();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.chkInternos = new System.Windows.Forms.CheckBox();
            this.chkExternos = new System.Windows.Forms.CheckBox();
            this.txtFechaVencimiento = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrdenar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIniciar
            // 
            this.txtIniciar.BackColor = System.Drawing.Color.Chocolate;
            this.txtIniciar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIniciar.Font = new System.Drawing.Font("Philosopher", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtIniciar.Location = new System.Drawing.Point(272, 77);
            this.txtIniciar.Multiline = true;
            this.txtIniciar.Name = "txtIniciar";
            this.txtIniciar.Size = new System.Drawing.Size(85, 68);
            this.txtIniciar.TabIndex = 0;
            this.txtIniciar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtIniciar, "Cantidad de productos");
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Chocolate;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombre.Location = new System.Drawing.Point(202, 197);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(324, 32);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtNombre, "Nombre del producto");
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloTexto);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(0, 0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 23;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Chocolate;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCodigo.Location = new System.Drawing.Point(633, 197);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(182, 32);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtCodigo, "Código del producto");
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloTextoDigito);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.Chocolate;
            this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecio.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecio.Location = new System.Drawing.Point(633, 235);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(182, 32);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtPrecio, "Precio del producto");
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloDecimal);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Chocolate;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCantidad.Location = new System.Drawing.Point(948, 197);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(306, 32);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtCantidad, "Cantidad del producto");
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEntero);
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
            this.cboTipoProducto.Location = new System.Drawing.Point(1050, 235);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(204, 37);
            this.cboTipoProducto.Sorted = true;
            this.cboTipoProducto.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cboTipoProducto, "Tipo de producto");
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = global::Chocolateria.Properties.Resources._1478568239_search;
            this.btnBuscar.Location = new System.Drawing.Point(1197, 435);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 42);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar registros");
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            this.btnBuscar.MouseLeave += new System.EventHandler(this.btnBuscar_Leave);
            this.btnBuscar.MouseHover += new System.EventHandler(this.btnBuscar_Hover);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::Chocolateria.Properties.Resources._1479211604_RecycleBin_Empty;
            this.btnEliminar.Location = new System.Drawing.Point(1197, 382);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 42);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEliminar, "Eliminar producto");
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_Leave);
            this.btnEliminar.MouseHover += new System.EventHandler(this.btnEliminar_Hover);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(0, 0);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 50);
            this.btnOrdenar.TabIndex = 22;
            this.btnOrdenar.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = global::Chocolateria.Properties.Resources._1478662985_plus_add_green2;
            this.btnAgregar.Location = new System.Drawing.Point(1090, 304);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(69, 70);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar producto");
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_Leave);
            this.btnAgregar.MouseHover += new System.EventHandler(this.btnAgregar_Hover);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Image = global::Chocolateria.Properties.Resources._1479210198_Button_Power_On_01;
            this.btnIniciar.Location = new System.Drawing.Point(366, 77);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(70, 70);
            this.btnIniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIniciar.TabIndex = 12;
            this.btnIniciar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnIniciar, "Iniciar");
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            this.btnIniciar.MouseLeave += new System.EventHandler(this.btnIniciar_Leave);
            this.btnIniciar.MouseHover += new System.EventHandler(this.btnIniciar_Hover);
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
            this.dtgProductos.Location = new System.Drawing.Point(70, 304);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.Size = new System.Drawing.Size(916, 316);
            this.dtgProductos.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dtgProductos, "Datos de inventario de los productos");
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
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Chocolateria.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(992, 609);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 42);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar la aplicacion");
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = global::Chocolateria.Properties.Resources.back;
            this.btnRegresar.Location = new System.Drawing.Point(1101, 609);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(58, 41);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRegresar, "Regresar al menú principal");
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cboMetodos
            // 
            this.cboMetodos.BackColor = System.Drawing.Color.Chocolate;
            this.cboMetodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMetodos.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMetodos.FormattingEnabled = true;
            this.cboMetodos.Items.AddRange(new object[] {
            "Bombón",
            "Pastel",
            "Caramelo",
            "Pudin",
            "Animalito",
            "Paleta",
            "Chocobanano"});
            this.cboMetodos.Location = new System.Drawing.Point(1009, 555);
            this.cboMetodos.Name = "cboMetodos";
            this.cboMetodos.Size = new System.Drawing.Size(245, 34);
            this.cboMetodos.TabIndex = 17;
            this.toolTip1.SetToolTip(this.cboMetodos, "Elija el método utilizar");
            this.cboMetodos.SelectedIndexChanged += new System.EventHandler(this.cboMetodos_Select);
            // 
            // txtEliminar
            // 
            this.txtEliminar.BackColor = System.Drawing.Color.Chocolate;
            this.txtEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEliminar.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtEliminar.Location = new System.Drawing.Point(1009, 392);
            this.txtEliminar.Multiline = true;
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(182, 32);
            this.txtEliminar.TabIndex = 20;
            this.txtEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtEliminar, "Eliminar por código");
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.Chocolate;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBuscar.Location = new System.Drawing.Point(1009, 442);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(182, 32);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtBuscar, "Precio del producto");
            // 
            // chkInternos
            // 
            this.chkInternos.AutoSize = true;
            this.chkInternos.BackColor = System.Drawing.Color.Transparent;
            this.chkInternos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInternos.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInternos.ForeColor = System.Drawing.Color.Black;
            this.chkInternos.Location = new System.Drawing.Point(1009, 484);
            this.chkInternos.Name = "chkInternos";
            this.chkInternos.Size = new System.Drawing.Size(165, 27);
            this.chkInternos.TabIndex = 18;
            this.chkInternos.Text = "Metodos Internos";
            this.toolTip1.SetToolTip(this.chkInternos, "Ordenar con métodos internos");
            this.chkInternos.UseVisualStyleBackColor = false;
            this.chkInternos.CheckedChanged += new System.EventHandler(this.chkInternos_Checked);
            // 
            // chkExternos
            // 
            this.chkExternos.AutoSize = true;
            this.chkExternos.BackColor = System.Drawing.Color.Transparent;
            this.chkExternos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkExternos.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExternos.Location = new System.Drawing.Point(1009, 520);
            this.chkExternos.Name = "chkExternos";
            this.chkExternos.Size = new System.Drawing.Size(165, 27);
            this.chkExternos.TabIndex = 19;
            this.chkExternos.Text = "Métodos Externos";
            this.toolTip1.SetToolTip(this.chkExternos, "Ordenar con métodos externos");
            this.chkExternos.UseVisualStyleBackColor = false;
            this.chkExternos.CheckedChanged += new System.EventHandler(this.chkExternos_Checked);
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.BackColor = System.Drawing.Color.Chocolate;
            this.txtFechaVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaVencimiento.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVencimiento.Location = new System.Drawing.Point(374, 236);
            this.txtFechaVencimiento.Mask = "00/00/0000";
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(152, 31);
            this.txtFechaVencimiento.TabIndex = 24;
            this.txtFechaVencimiento.ValidatingType = typeof(System.DateTime);
            // 
            // frmOrdenacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::Chocolateria.Properties.Resources.pantalla_ordenamiento;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.chkExternos);
            this.Controls.Add(this.chkInternos);
            this.Controls.Add(this.cboMetodos);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIniciar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrdenacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrdenacion";
            this.TransparencyKey = System.Drawing.Color.Sienna;
            this.Load += new System.EventHandler(this.frmOrdenacion_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloEntero);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrdenar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIniciar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.PictureBox btnEliminar;
        private System.Windows.Forms.PictureBox btnOrdenar;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox btnIniciar;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cboMetodos;
        private System.Windows.Forms.CheckBox chkInternos;
        private System.Windows.Forms.CheckBox chkExternos;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.MaskedTextBox txtFechaVencimiento;
    }
}