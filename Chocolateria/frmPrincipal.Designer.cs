namespace Chocolateria
{
    partial class frmPrincipal
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
            this.btnOrdenacion = new System.Windows.Forms.Button();
            this.btnArboles = new System.Windows.Forms.Button();
            this.btnGrafos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnDesarrolladores = new System.Windows.Forms.Button();
            this.picOrdenacion = new System.Windows.Forms.PictureBox();
            this.picArboles = new System.Windows.Forms.PictureBox();
            this.picGrafos = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picOrdenacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArboles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrdenacion
            // 
            this.btnOrdenacion.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdenacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdenacion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOrdenacion.FlatAppearance.BorderSize = 0;
            this.btnOrdenacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOrdenacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenacion.Location = new System.Drawing.Point(84, 60);
            this.btnOrdenacion.Name = "btnOrdenacion";
            this.btnOrdenacion.Size = new System.Drawing.Size(245, 58);
            this.btnOrdenacion.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnOrdenacion, "Algoritmos de ordenacion");
            this.btnOrdenacion.UseVisualStyleBackColor = false;
            this.btnOrdenacion.Click += new System.EventHandler(this.btnOrdenacion_Click);
            this.btnOrdenacion.MouseLeave += new System.EventHandler(this.btnOrdenacion_Leave);
            this.btnOrdenacion.MouseHover += new System.EventHandler(this.btnOrdenacion_Hover);
            // 
            // btnArboles
            // 
            this.btnArboles.BackColor = System.Drawing.Color.Transparent;
            this.btnArboles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArboles.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnArboles.FlatAppearance.BorderSize = 0;
            this.btnArboles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnArboles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnArboles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArboles.Location = new System.Drawing.Point(367, 60);
            this.btnArboles.Name = "btnArboles";
            this.btnArboles.Size = new System.Drawing.Size(185, 58);
            this.btnArboles.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnArboles, "Algoritmos sobre árboles binarios y balanceados");
            this.btnArboles.UseVisualStyleBackColor = false;
            this.btnArboles.Click += new System.EventHandler(this.btnArboles_Click);
            // 
            // btnGrafos
            // 
            this.btnGrafos.BackColor = System.Drawing.Color.Transparent;
            this.btnGrafos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrafos.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnGrafos.FlatAppearance.BorderSize = 0;
            this.btnGrafos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGrafos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGrafos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafos.Location = new System.Drawing.Point(595, 60);
            this.btnGrafos.Name = "btnGrafos";
            this.btnGrafos.Size = new System.Drawing.Size(159, 58);
            this.btnGrafos.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnGrafos, "Algoritmos sobre grafos");
            this.btnGrafos.UseVisualStyleBackColor = false;
            this.btnGrafos.Click += new System.EventHandler(this.btnGrafos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(604, 321);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 43);
            this.btnCerrar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar la aplicación");
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.btnAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Location = new System.Drawing.Point(399, 321);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(136, 43);
            this.btnAcercaDe.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAcercaDe, "Acerca de la aplicación");
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnDesarrolladores
            // 
            this.btnDesarrolladores.BackColor = System.Drawing.Color.Transparent;
            this.btnDesarrolladores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesarrolladores.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnDesarrolladores.FlatAppearance.BorderSize = 0;
            this.btnDesarrolladores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDesarrolladores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDesarrolladores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesarrolladores.Location = new System.Drawing.Point(121, 321);
            this.btnDesarrolladores.Name = "btnDesarrolladores";
            this.btnDesarrolladores.Size = new System.Drawing.Size(236, 43);
            this.btnDesarrolladores.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnDesarrolladores, "Desarrolladores de la aplicación");
            this.btnDesarrolladores.UseVisualStyleBackColor = false;
            this.btnDesarrolladores.Click += new System.EventHandler(this.btnDesarrolladores_Click);
            // 
            // picOrdenacion
            // 
            this.picOrdenacion.BackColor = System.Drawing.Color.Transparent;
            this.picOrdenacion.Image = global::Chocolateria.Properties.Resources._1478597226_gtk_sort_ascending;
            this.picOrdenacion.Location = new System.Drawing.Point(132, 143);
            this.picOrdenacion.Name = "picOrdenacion";
            this.picOrdenacion.Size = new System.Drawing.Size(154, 147);
            this.picOrdenacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrdenacion.TabIndex = 6;
            this.picOrdenacion.TabStop = false;
            this.toolTip1.SetToolTip(this.picOrdenacion, "Ordenación");
            // 
            // picArboles
            // 
            this.picArboles.BackColor = System.Drawing.Color.Transparent;
            this.picArboles.Image = global::Chocolateria.Properties.Resources._1478597160_binary_tree;
            this.picArboles.Location = new System.Drawing.Point(381, 143);
            this.picArboles.Name = "picArboles";
            this.picArboles.Size = new System.Drawing.Size(154, 147);
            this.picArboles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArboles.TabIndex = 7;
            this.picArboles.TabStop = false;
            this.toolTip1.SetToolTip(this.picArboles, "Árboles");
            // 
            // picGrafos
            // 
            this.picGrafos.BackColor = System.Drawing.Color.Transparent;
            this.picGrafos.Image = global::Chocolateria.Properties.Resources._1478597331_6;
            this.picGrafos.Location = new System.Drawing.Point(615, 143);
            this.picGrafos.Name = "picGrafos";
            this.picGrafos.Size = new System.Drawing.Size(154, 147);
            this.picGrafos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGrafos.TabIndex = 8;
            this.picGrafos.TabStop = false;
            this.toolTip1.SetToolTip(this.picGrafos, "Grafos");
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::Chocolateria.Properties.Resources.pantalla_principal;
            this.ClientSize = new System.Drawing.Size(850, 400);
            this.Controls.Add(this.picGrafos);
            this.Controls.Add(this.picArboles);
            this.Controls.Add(this.picOrdenacion);
            this.Controls.Add(this.btnDesarrolladores);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGrafos);
            this.Controls.Add(this.btnArboles);
            this.Controls.Add(this.btnOrdenacion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.TransparencyKey = System.Drawing.Color.Chocolate;
            ((System.ComponentModel.ISupportInitialize)(this.picOrdenacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArboles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrafos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenacion;
        private System.Windows.Forms.Button btnArboles;
        private System.Windows.Forms.Button btnGrafos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnDesarrolladores;
        private System.Windows.Forms.PictureBox picOrdenacion;
        private System.Windows.Forms.PictureBox picArboles;
        private System.Windows.Forms.PictureBox picGrafos;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}