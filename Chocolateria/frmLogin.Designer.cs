namespace Chocolateria
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Sienna;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Philosopher", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsuario.Location = new System.Drawing.Point(315, 171);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(328, 43);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtUsuario, "Nombre de usuario");
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.Sienna;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Philosopher", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContrasena.Location = new System.Drawing.Point(315, 272);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(328, 43);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtContrasena, "Contraseña de usuario");
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Image = global::Chocolateria.Properties.Resources._1478568411_Next;
            this.btnIngresar.Location = new System.Drawing.Point(683, 185);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(109, 102);
            this.btnIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnIngresar, "Ingresar al sistema");
            this.btnIngresar.Click += new System.EventHandler(this.Click_btnIngresar);
            this.btnIngresar.MouseLeave += new System.EventHandler(this.btnIngresar_Leave);
            this.btnIngresar.MouseHover += new System.EventHandler(this.btnIngresar_Hover);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Chocolateria.Properties.Resources._1478568074_minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(346, 341);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(56, 52);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnMinimizar, "Minimizar");
            this.btnMinimizar.Click += new System.EventHandler(this.Click_btnMinimizar);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_Leave);
            this.btnMinimizar.MouseHover += new System.EventHandler(this.btnMinimizar_Hover);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Chocolateria.Properties.Resources._1478568016_close;
            this.btnCerrar.Location = new System.Drawing.Point(452, 341);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 52);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCerrar, "Cerrar");
            this.btnCerrar.Click += new System.EventHandler(this.Click_btnCerrar);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_Leave);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_Hover);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Image = global::Chocolateria.Properties.Resources._1478568120_info;
            this.btnInfo.Location = new System.Drawing.Point(561, 341);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(56, 52);
            this.btnInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInfo.TabIndex = 5;
            this.btnInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.btnInfo, "Información sobre la app");
            this.btnInfo.Click += new System.EventHandler(this.Click_btnInfo);
            this.btnInfo.MouseLeave += new System.EventHandler(this.btnInfo_Leave);
            this.btnInfo.MouseHover += new System.EventHandler(this.btnInfo_Hover);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::Chocolateria.Properties.Resources.Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 434);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Chocolate;
            ((System.ComponentModel.ISupportInitialize)(this.btnIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.PictureBox btnIngresar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnInfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

