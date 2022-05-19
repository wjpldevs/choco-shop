namespace Chocolateria
{
    partial class frmGrafos
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cboMesas = new System.Windows.Forms.ComboBox();
            this.cboRutas = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.PictureBox();
            this.chkMostrarGrafo = new System.Windows.Forms.CheckBox();
            this.chkAgregarVertice = new System.Windows.Forms.CheckBox();
            this.chkEliminarVertice = new System.Windows.Forms.CheckBox();
            this.chkAgregarArista = new System.Windows.Forms.CheckBox();
            this.chkEliminarArista = new System.Windows.Forms.CheckBox();
            this.chkBusquedaAmplia = new System.Windows.Forms.CheckBox();
            this.chkBusquedaProfunda = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReestablecer = new System.Windows.Forms.PictureBox();
            this.mesa7 = new System.Windows.Forms.PictureBox();
            this.mesa8 = new System.Windows.Forms.PictureBox();
            this.mesa6 = new System.Windows.Forms.PictureBox();
            this.mesa5 = new System.Windows.Forms.PictureBox();
            this.mesa4 = new System.Windows.Forms.PictureBox();
            this.mesa3 = new System.Windows.Forms.PictureBox();
            this.mesa2 = new System.Windows.Forms.PictureBox();
            this.mesa1 = new System.Windows.Forms.PictureBox();
            this.btnEjecutarArista = new System.Windows.Forms.PictureBox();
            this.btnEjecutarVetice = new System.Windows.Forms.PictureBox();
            this.btnEjecutarBusqueda = new System.Windows.Forms.PictureBox();
            this.cboV1 = new System.Windows.Forms.ComboBox();
            this.cboV2 = new System.Windows.Forms.ComboBox();
            this.cboVertice = new System.Windows.Forms.ComboBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnReestablecer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutarArista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutarVetice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutarBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(951, 566);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 26);
            this.btnCerrar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar la aplicación");
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Location = new System.Drawing.Point(1051, 560);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(50, 42);
            this.btnRegresar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnRegresar, "Regresar al menú principal");
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cboMesas
            // 
            this.cboMesas.BackColor = System.Drawing.Color.Chocolate;
            this.cboMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMesas.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMesas.FormattingEnabled = true;
            this.cboMesas.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboMesas.Location = new System.Drawing.Point(119, 114);
            this.cboMesas.Name = "cboMesas";
            this.cboMesas.Size = new System.Drawing.Size(85, 34);
            this.cboMesas.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cboMesas, "Determinar vertices");
            this.cboMesas.SelectedIndexChanged += new System.EventHandler(this.cboMesas_SelectedIndexChanged);
            // 
            // cboRutas
            // 
            this.cboRutas.BackColor = System.Drawing.Color.Chocolate;
            this.cboRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRutas.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRutas.FormattingEnabled = true;
            this.cboRutas.Location = new System.Drawing.Point(290, 114);
            this.cboRutas.Name = "cboRutas";
            this.cboRutas.Size = new System.Drawing.Size(81, 34);
            this.cboRutas.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cboRutas, "Determinar aristas");
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Image = global::Chocolateria.Properties.Resources._1479210198_Button_Power_On_01;
            this.btnIniciar.Location = new System.Drawing.Point(415, 74);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(70, 70);
            this.btnIniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIniciar.TabIndex = 13;
            this.btnIniciar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnIniciar, "Iniciar grafo");
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            this.btnIniciar.MouseLeave += new System.EventHandler(this.btnIniciar_MouseLeave);
            this.btnIniciar.MouseHover += new System.EventHandler(this.btnIniciar_MouseHover);
            // 
            // chkMostrarGrafo
            // 
            this.chkMostrarGrafo.AutoSize = true;
            this.chkMostrarGrafo.BackColor = System.Drawing.Color.Chocolate;
            this.chkMostrarGrafo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkMostrarGrafo.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrarGrafo.Location = new System.Drawing.Point(870, 181);
            this.chkMostrarGrafo.Name = "chkMostrarGrafo";
            this.chkMostrarGrafo.Size = new System.Drawing.Size(13, 12);
            this.chkMostrarGrafo.TabIndex = 14;
            this.chkMostrarGrafo.UseVisualStyleBackColor = false;
            this.chkMostrarGrafo.CheckedChanged += new System.EventHandler(this.chkMostrarGrafo_CheckedChanged);
            // 
            // chkAgregarVertice
            // 
            this.chkAgregarVertice.AutoSize = true;
            this.chkAgregarVertice.BackColor = System.Drawing.Color.Chocolate;
            this.chkAgregarVertice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkAgregarVertice.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgregarVertice.Location = new System.Drawing.Point(870, 233);
            this.chkAgregarVertice.Name = "chkAgregarVertice";
            this.chkAgregarVertice.Size = new System.Drawing.Size(13, 12);
            this.chkAgregarVertice.TabIndex = 15;
            this.chkAgregarVertice.UseVisualStyleBackColor = false;
            this.chkAgregarVertice.CheckedChanged += new System.EventHandler(this.chkAgregarVertice_CheckedChanged);
            // 
            // chkEliminarVertice
            // 
            this.chkEliminarVertice.AutoSize = true;
            this.chkEliminarVertice.BackColor = System.Drawing.Color.Chocolate;
            this.chkEliminarVertice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkEliminarVertice.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminarVertice.Location = new System.Drawing.Point(870, 285);
            this.chkEliminarVertice.Name = "chkEliminarVertice";
            this.chkEliminarVertice.Size = new System.Drawing.Size(13, 12);
            this.chkEliminarVertice.TabIndex = 16;
            this.chkEliminarVertice.UseVisualStyleBackColor = false;
            this.chkEliminarVertice.CheckedChanged += new System.EventHandler(this.chkEliminarVertice_CheckedChanged);
            // 
            // chkAgregarArista
            // 
            this.chkAgregarArista.AutoSize = true;
            this.chkAgregarArista.BackColor = System.Drawing.Color.Chocolate;
            this.chkAgregarArista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkAgregarArista.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgregarArista.Location = new System.Drawing.Point(870, 340);
            this.chkAgregarArista.Name = "chkAgregarArista";
            this.chkAgregarArista.Size = new System.Drawing.Size(13, 12);
            this.chkAgregarArista.TabIndex = 17;
            this.chkAgregarArista.UseVisualStyleBackColor = false;
            this.chkAgregarArista.CheckedChanged += new System.EventHandler(this.chkAgregarArista_CheckedChanged);
            // 
            // chkEliminarArista
            // 
            this.chkEliminarArista.AutoSize = true;
            this.chkEliminarArista.BackColor = System.Drawing.Color.Chocolate;
            this.chkEliminarArista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkEliminarArista.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminarArista.Location = new System.Drawing.Point(870, 391);
            this.chkEliminarArista.Name = "chkEliminarArista";
            this.chkEliminarArista.Size = new System.Drawing.Size(13, 12);
            this.chkEliminarArista.TabIndex = 18;
            this.chkEliminarArista.UseVisualStyleBackColor = false;
            this.chkEliminarArista.CheckedChanged += new System.EventHandler(this.chkEliminarArista_CheckedChanged);
            // 
            // chkBusquedaAmplia
            // 
            this.chkBusquedaAmplia.AutoSize = true;
            this.chkBusquedaAmplia.BackColor = System.Drawing.Color.Chocolate;
            this.chkBusquedaAmplia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkBusquedaAmplia.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBusquedaAmplia.Location = new System.Drawing.Point(870, 442);
            this.chkBusquedaAmplia.Name = "chkBusquedaAmplia";
            this.chkBusquedaAmplia.Size = new System.Drawing.Size(13, 12);
            this.chkBusquedaAmplia.TabIndex = 19;
            this.chkBusquedaAmplia.UseVisualStyleBackColor = false;
            this.chkBusquedaAmplia.CheckedChanged += new System.EventHandler(this.chkBusquedaAmplia_CheckedChanged);
            // 
            // chkBusquedaProfunda
            // 
            this.chkBusquedaProfunda.AutoSize = true;
            this.chkBusquedaProfunda.BackColor = System.Drawing.Color.Chocolate;
            this.chkBusquedaProfunda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkBusquedaProfunda.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBusquedaProfunda.Location = new System.Drawing.Point(870, 492);
            this.chkBusquedaProfunda.Name = "chkBusquedaProfunda";
            this.chkBusquedaProfunda.Size = new System.Drawing.Size(13, 12);
            this.chkBusquedaProfunda.TabIndex = 20;
            this.chkBusquedaProfunda.UseVisualStyleBackColor = false;
            this.chkBusquedaProfunda.CheckedChanged += new System.EventHandler(this.chkBusquedaProfunda_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.mesa7);
            this.panel1.Controls.Add(this.mesa8);
            this.panel1.Controls.Add(this.mesa6);
            this.panel1.Controls.Add(this.mesa5);
            this.panel1.Controls.Add(this.mesa4);
            this.panel1.Controls.Add(this.mesa3);
            this.panel1.Controls.Add(this.mesa2);
            this.panel1.Controls.Add(this.mesa1);
            this.panel1.Location = new System.Drawing.Point(47, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 435);
            this.panel1.TabIndex = 25;
            this.toolTip1.SetToolTip(this.panel1, "Área de la chocolateria");
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.BackColor = System.Drawing.Color.Transparent;
            this.btnReestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReestablecer.Image = global::Chocolateria.Properties.Resources._1479506410_Redo;
            this.btnReestablecer.Location = new System.Drawing.Point(1120, 545);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(52, 57);
            this.btnReestablecer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReestablecer.TabIndex = 38;
            this.btnReestablecer.TabStop = false;
            this.toolTip1.SetToolTip(this.btnReestablecer, "Reestablecer");
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            this.btnReestablecer.MouseLeave += new System.EventHandler(this.btnReestablecer_MouseLeave);
            this.btnReestablecer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReestablecer_MouseMove);
            // 
            // mesa7
            // 
            this.mesa7.BackColor = System.Drawing.Color.Transparent;
            this.mesa7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesa7.Image = global::Chocolateria.Properties.Resources.mesa7;
            this.mesa7.Location = new System.Drawing.Point(530, 201);
            this.mesa7.Name = "mesa7";
            this.mesa7.Size = new System.Drawing.Size(89, 89);
            this.mesa7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mesa7.TabIndex = 32;
            this.mesa7.TabStop = false;
            this.toolTip1.SetToolTip(this.mesa7, "Mesa 7");
            this.mesa7.Visible = false;
            // 
            // mesa8
            // 
            this.mesa8.BackColor = System.Drawing.Color.Transparent;
            this.mesa8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesa8.Image = global::Chocolateria.Properties.Resources.mesa8;
            this.mesa8.Location = new System.Drawing.Point(225, 82);
            this.mesa8.Name = "mesa8";
            this.mesa8.Size = new System.Drawing.Size(89, 89);
            this.mesa8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mesa8.TabIndex = 31;
            this.mesa8.TabStop = false;
            this.toolTip1.SetToolTip(this.mesa8, "Mesa 8");
            this.mesa8.Visible = false;
            // 
            // mesa6
            // 
            this.mesa6.BackColor = System.Drawing.Color.Transparent;
            this.mesa6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesa6.Image = global::Chocolateria.Properties.Resources.mesa6;
            this.mesa6.Location = new System.Drawing.Point(225, 309);
            this.mesa6.Name = "mesa6";
            this.mesa6.Size = new System.Drawing.Size(89, 89);
            this.mesa6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mesa6.TabIndex = 30;
            this.mesa6.TabStop = false;
            this.toolTip1.SetToolTip(this.mesa6, "Mesa 6");
            this.mesa6.Visible = false;
            // 
            // mesa5
            // 
            this.mesa5.BackColor = System.Drawing.Color.Transparent;
            this.mesa5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesa5.Image = global::Chocolateria.Properties.Resources.mesa5;
            this.mesa5.Location = new System.Drawing.Point(466, 72);
            this.mesa5.Name = "mesa5";
            this.mesa5.Size = new System.Drawing.Size(89, 89);
            this.mesa5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mesa5.TabIndex = 29;
            this.mesa5.TabStop = false;
            this.toolTip1.SetToolTip(this.mesa5, "Mesa 5");
            this.mesa5.Visible = false;
            // 
            // mesa4
            // 
            this.mesa4.BackColor = System.Drawing.Color.Transparent;
            this.mesa4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesa4.Image = global::Chocolateria.Properties.Resources.mesa4;
            this.mesa4.Location = new System.Drawing.Point(466, 309);
            this.mesa4.Name = "mesa4";
            this.mesa4.Size = new System.Drawing.Size(89, 89);
            this.mesa4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mesa4.TabIndex = 28;
            this.mesa4.TabStop = false;
            this.toolTip1.SetToolTip(this.mesa4, "Mesa 4");
            this.mesa4.Visible = false;
            // 
            // mesa3
            // 
            this.mesa3.BackColor = System.Drawing.Color.Transparent;
            this.mesa3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesa3.Image = global::Chocolateria.Properties.Resources.mesa3;
            this.mesa3.Location = new System.Drawing.Point(161, 201);
            this.mesa3.Name = "mesa3";
            this.mesa3.Size = new System.Drawing.Size(89, 89);
            this.mesa3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mesa3.TabIndex = 27;
            this.mesa3.TabStop = false;
            this.toolTip1.SetToolTip(this.mesa3, "Mesa 3");
            this.mesa3.Visible = false;
            // 
            // mesa2
            // 
            this.mesa2.BackColor = System.Drawing.Color.Transparent;
            this.mesa2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesa2.Image = global::Chocolateria.Properties.Resources.mesa2;
            this.mesa2.Location = new System.Drawing.Point(349, 330);
            this.mesa2.Name = "mesa2";
            this.mesa2.Size = new System.Drawing.Size(89, 89);
            this.mesa2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mesa2.TabIndex = 26;
            this.mesa2.TabStop = false;
            this.toolTip1.SetToolTip(this.mesa2, "Mesa 2");
            this.mesa2.Visible = false;
            // 
            // mesa1
            // 
            this.mesa1.BackColor = System.Drawing.Color.Transparent;
            this.mesa1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mesa1.Image = global::Chocolateria.Properties.Resources.mesa1;
            this.mesa1.Location = new System.Drawing.Point(349, 14);
            this.mesa1.Name = "mesa1";
            this.mesa1.Size = new System.Drawing.Size(89, 89);
            this.mesa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mesa1.TabIndex = 25;
            this.mesa1.TabStop = false;
            this.toolTip1.SetToolTip(this.mesa1, "Mesa 1");
            this.mesa1.Visible = false;
            // 
            // btnEjecutarArista
            // 
            this.btnEjecutarArista.BackColor = System.Drawing.Color.Transparent;
            this.btnEjecutarArista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutarArista.Image = global::Chocolateria.Properties.Resources._1479453296_circle_green;
            this.btnEjecutarArista.Location = new System.Drawing.Point(1213, 333);
            this.btnEjecutarArista.Name = "btnEjecutarArista";
            this.btnEjecutarArista.Size = new System.Drawing.Size(39, 33);
            this.btnEjecutarArista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEjecutarArista.TabIndex = 28;
            this.btnEjecutarArista.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEjecutarArista, "Agregar/Eliminar arista");
            this.btnEjecutarArista.Click += new System.EventHandler(this.btnEjecutarArista_Click);
            this.btnEjecutarArista.MouseLeave += new System.EventHandler(this.btnEjecutarArista_MouseLeave);
            this.btnEjecutarArista.MouseHover += new System.EventHandler(this.btnEjecutarArista_MouseHover);
            // 
            // btnEjecutarVetice
            // 
            this.btnEjecutarVetice.BackColor = System.Drawing.Color.Transparent;
            this.btnEjecutarVetice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutarVetice.Image = global::Chocolateria.Properties.Resources._1479453290_circle_blue;
            this.btnEjecutarVetice.Location = new System.Drawing.Point(1211, 224);
            this.btnEjecutarVetice.Name = "btnEjecutarVetice";
            this.btnEjecutarVetice.Size = new System.Drawing.Size(39, 33);
            this.btnEjecutarVetice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEjecutarVetice.TabIndex = 31;
            this.btnEjecutarVetice.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEjecutarVetice, "Agregar/Eliminar vertice");
            this.btnEjecutarVetice.Click += new System.EventHandler(this.btnEjecutarVetice_Click);
            this.btnEjecutarVetice.MouseLeave += new System.EventHandler(this.btnEjecutarVetice_MouseLeave);
            this.btnEjecutarVetice.MouseHover += new System.EventHandler(this.btnEjecutarVetice_MouseHover);
            // 
            // btnEjecutarBusqueda
            // 
            this.btnEjecutarBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.btnEjecutarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjecutarBusqueda.Image = global::Chocolateria.Properties.Resources._1479453459_search_binoculars_find;
            this.btnEjecutarBusqueda.Location = new System.Drawing.Point(1213, 440);
            this.btnEjecutarBusqueda.Name = "btnEjecutarBusqueda";
            this.btnEjecutarBusqueda.Size = new System.Drawing.Size(39, 33);
            this.btnEjecutarBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEjecutarBusqueda.TabIndex = 33;
            this.btnEjecutarBusqueda.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEjecutarBusqueda, "Busq. Amplia/Busq. Profunda");
            this.btnEjecutarBusqueda.Click += new System.EventHandler(this.btnEjecutarBusqueda_Click);
            this.btnEjecutarBusqueda.MouseLeave += new System.EventHandler(this.btnEjecutarBusqueda_MouseLeave);
            this.btnEjecutarBusqueda.MouseHover += new System.EventHandler(this.btnEjecutarBusqueda_MouseHover);
            // 
            // cboV1
            // 
            this.cboV1.BackColor = System.Drawing.Color.Chocolate;
            this.cboV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboV1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboV1.FormattingEnabled = true;
            this.cboV1.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboV1.Location = new System.Drawing.Point(1144, 333);
            this.cboV1.Name = "cboV1";
            this.cboV1.Size = new System.Drawing.Size(61, 25);
            this.cboV1.TabIndex = 34;
            this.toolTip1.SetToolTip(this.cboV1, "Vertice 1");
            // 
            // cboV2
            // 
            this.cboV2.BackColor = System.Drawing.Color.Chocolate;
            this.cboV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboV2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboV2.FormattingEnabled = true;
            this.cboV2.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboV2.Location = new System.Drawing.Point(1144, 373);
            this.cboV2.Name = "cboV2";
            this.cboV2.Size = new System.Drawing.Size(61, 25);
            this.cboV2.TabIndex = 35;
            this.toolTip1.SetToolTip(this.cboV2, "Vertice 2");
            // 
            // cboVertice
            // 
            this.cboVertice.BackColor = System.Drawing.Color.Chocolate;
            this.cboVertice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVertice.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVertice.FormattingEnabled = true;
            this.cboVertice.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cboVertice.Location = new System.Drawing.Point(1144, 226);
            this.cboVertice.Name = "cboVertice";
            this.cboVertice.Size = new System.Drawing.Size(61, 25);
            this.cboVertice.TabIndex = 36;
            this.toolTip1.SetToolTip(this.cboVertice, "Vértice a agregar");
            // 
            // cboBuscar
            // 
            this.cboBuscar.BackColor = System.Drawing.Color.Chocolate;
            this.cboBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuscar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboBuscar.Location = new System.Drawing.Point(1144, 442);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(61, 25);
            this.cboBuscar.TabIndex = 37;
            this.toolTip1.SetToolTip(this.cboBuscar, "Valor a buscar");
            // 
            // frmGrafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = global::Chocolateria.Properties.Resources.pantalla_grafos2;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.cboVertice);
            this.Controls.Add(this.cboV2);
            this.Controls.Add(this.cboV1);
            this.Controls.Add(this.btnEjecutarBusqueda);
            this.Controls.Add(this.btnEjecutarVetice);
            this.Controls.Add(this.btnEjecutarArista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkBusquedaProfunda);
            this.Controls.Add(this.chkBusquedaAmplia);
            this.Controls.Add(this.chkEliminarArista);
            this.Controls.Add(this.chkAgregarArista);
            this.Controls.Add(this.chkEliminarVertice);
            this.Controls.Add(this.chkAgregarVertice);
            this.Controls.Add(this.chkMostrarGrafo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cboRutas);
            this.Controls.Add(this.cboMesas);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCerrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGrafos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Sienna;
            this.Load += new System.EventHandler(this.frmGrafos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnReestablecer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mesa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutarArista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutarVetice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEjecutarBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cboMesas;
        private System.Windows.Forms.ComboBox cboRutas;
        private System.Windows.Forms.PictureBox btnIniciar;
        private System.Windows.Forms.CheckBox chkMostrarGrafo;
        private System.Windows.Forms.CheckBox chkAgregarVertice;
        private System.Windows.Forms.CheckBox chkEliminarVertice;
        private System.Windows.Forms.CheckBox chkAgregarArista;
        private System.Windows.Forms.CheckBox chkEliminarArista;
        private System.Windows.Forms.CheckBox chkBusquedaAmplia;
        private System.Windows.Forms.CheckBox chkBusquedaProfunda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox mesa4;
        private System.Windows.Forms.PictureBox mesa3;
        private System.Windows.Forms.PictureBox mesa2;
        private System.Windows.Forms.PictureBox mesa1;
        private System.Windows.Forms.PictureBox btnEjecutarArista;
        private System.Windows.Forms.PictureBox btnEjecutarVetice;
        private System.Windows.Forms.PictureBox btnEjecutarBusqueda;
        private System.Windows.Forms.ComboBox cboV1;
        private System.Windows.Forms.ComboBox cboV2;
        private System.Windows.Forms.ComboBox cboVertice;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.PictureBox mesa7;
        private System.Windows.Forms.PictureBox mesa8;
        private System.Windows.Forms.PictureBox mesa6;
        private System.Windows.Forms.PictureBox mesa5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnReestablecer;
    }
}