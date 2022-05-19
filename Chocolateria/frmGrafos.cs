using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chocolateria
{
    public partial class frmGrafos : Form
    {
        public frmGrafos()
        {
            InitializeComponent();
        }

        #region Variables y propiedades
        private frmPrincipal principal;
        private Grafico grafo;
        private Graphics panel;
        private Pen lapiz;
        private BusquedaAmplia busquedaAmplia;
        private BusquedaProfunda busquedaProfunda;

        public int Vertices { get; set; }
        public int Aristas { get; set; }
        public int Contador { get; set; }
        public int auxArista { get; set; }
        public bool hayRutas { get; set; }
        #endregion

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

        private void cboMesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (int.Parse(this.cboMesas.SelectedItem.ToString()))
            {
                case 3:

                    cboRutas.Items.Clear();
                    for (int i = 1; i <= 3; i++)
                        cboRutas.Items.Insert(i - 1, i);

                    mesa1.Visible = true;
                    mesa2.Visible = true;
                    mesa3.Visible = true;
                    mesa4.Visible = false;
                    mesa5.Visible = false;
                    mesa6.Visible = false;
                    mesa7.Visible = false;
                    mesa8.Visible = false;

                    break;

                case 4:

                    cboRutas.Items.Clear();
                    for (int i = 1; i <= 6; i++)
                        cboRutas.Items.Insert(i - 1, i);

                    mesa1.Visible = true;
                    mesa2.Visible = true;
                    mesa3.Visible = true;
                    mesa4.Visible = true;
                    mesa5.Visible = false;
                    mesa6.Visible = false;
                    mesa7.Visible = false;
                    mesa8.Visible = false;

                    break;

                case 5:

                    cboRutas.Items.Clear();
                    for (int i = 1; i <= 10; i++)
                        cboRutas.Items.Insert(i - 1, i);

                    mesa1.Visible = true;
                    mesa2.Visible = true;
                    mesa3.Visible = true;
                    mesa4.Visible = true;
                    mesa5.Visible = true;
                    mesa6.Visible = false;
                    mesa7.Visible = false;
                    mesa8.Visible = false;

                    break;

                case 6:

                    cboRutas.Items.Clear();
                    for (int i = 1; i <= 15; i++)
                        cboRutas.Items.Insert(i - 1, i);

                    mesa1.Visible = true;
                    mesa2.Visible = true;
                    mesa3.Visible = true;
                    mesa4.Visible = true;
                    mesa5.Visible = true;
                    mesa6.Visible = true;
                    mesa7.Visible = false;
                    mesa8.Visible = false;

                    break;

                case 7:
                    cboRutas.Items.Clear();
                    for (int i = 1; i <= 21; i++)
                        cboRutas.Items.Insert(i - 1, i);

                    mesa1.Visible = true;
                    mesa2.Visible = true;
                    mesa3.Visible = true;
                    mesa4.Visible = true;
                    mesa5.Visible = true;
                    mesa6.Visible = true;
                    mesa7.Visible = true;
                    mesa8.Visible = false;

                    break;

                case 8:
                    cboRutas.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                        cboRutas.Items.Insert(i - 1, i);

                    mesa1.Visible = true;
                    mesa2.Visible = true;
                    mesa3.Visible = true;
                    mesa4.Visible = true;
                    mesa5.Visible = true;
                    mesa6.Visible = true;
                    mesa7.Visible = true;
                    mesa8.Visible = true;

                    break;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cboMesas.Text) || string.IsNullOrEmpty(this.cboRutas.Text))
            {
                MessageBox.Show("Ha ocurrido un error.\nPor favor escoja una cantidad de mesas y rutas válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cboMesas.Focus();
            }
            else
            {
                if (hayRutas)
                {

                    auxArista = int.Parse(this.cboRutas.Text);
                    Aristas += auxArista;
                    Contador = 0;

                    this.chkAgregarArista.Enabled = true;
                    this.chkAgregarArista.Checked = true;

                    cboV1.Items.Clear();
                    cboV2.Items.Clear();

                    for (int i = 0; i < Vertices; i++)
                    {
                        cboV1.Items.Add(i + 1);
                        cboV2.Items.Add(i + 1);
                    }

                }
                else
                {
                    Vertices = int.Parse(this.cboMesas.Text);
                    Aristas = int.Parse(this.cboRutas.Text);
                    auxArista = Aristas;
                    Contador = 0;

                    grafo = new Grafico(Vertices, Aristas);

                    panel = panel1.CreateGraphics();
                    lapiz = new Pen(Color.White);

                    this.chkAgregarArista.Enabled = true;
                    this.chkAgregarArista.Checked = true;

                    cboV1.Items.Clear();
                    cboV2.Items.Clear();

                    for (int i = 0; i < Vertices; i++)
                    {
                        this.cboV1.Items.Add(i + 1);
                        this.cboV2.Items.Add(i + 1);
                    }
                }
            }
        }

        private void chkMostrarGrafo_CheckedChanged(object sender, EventArgs e)
        {
            #region Check
            if (this.chkMostrarGrafo.Checked)
            {

                this.chkAgregarArista.Enabled = false;
                this.chkAgregarVertice.Enabled = false;
                this.chkBusquedaAmplia.Enabled = false;
                this.chkBusquedaProfunda.Enabled = false;
                this.chkEliminarArista.Enabled = false;
                this.chkEliminarVertice.Enabled = false;

                try
                {
                    MessageBox.Show(string.Format(grafo.ToString()), "Información sobre el grafo actual", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Ha ocurrido lo siguiente: " + ex), "Error al mostrar el grafo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.chkMostrarGrafo.Focus();
                }

                this.chkAgregarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkEliminarArista.Checked = false;
                this.chkEliminarVertice.Checked = false;

            }
            else
            {
                this.chkAgregarArista.Enabled = true;
                this.chkAgregarVertice.Enabled = true;
                this.chkBusquedaAmplia.Enabled = true;
                this.chkBusquedaProfunda.Enabled = true;
                this.chkEliminarArista.Enabled = true;
                this.chkEliminarVertice.Enabled = true;

                this.chkAgregarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkEliminarArista.Checked = false;
                this.chkEliminarVertice.Checked = false;
            }
            #endregion
        }

        private void chkAgregarVertice_CheckedChanged(object sender, EventArgs e)
        {
            #region Check
            if (this.chkAgregarVertice.Checked)
            {
                this.chkAgregarVertice.Enabled = true;
                this.chkAgregarArista.Enabled = false;
                this.chkMostrarGrafo.Enabled = false;
                this.chkBusquedaAmplia.Enabled = false;
                this.chkBusquedaProfunda.Enabled = false;
                this.chkEliminarArista.Enabled = false;
                this.chkEliminarVertice.Enabled = false;

                this.cboVertice.Items.Clear();
                for (int i = 8 - Vertices, j = 1; i > 0; i--, j++)
                    this.cboVertice.Items.Add(Vertices + j);

                this.chkAgregarArista.Checked = false;
                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkEliminarArista.Checked = false;
                this.chkEliminarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;

            }
            else
            {
                this.chkAgregarVertice.Enabled = true;
                this.chkAgregarArista.Enabled = true;
                this.chkMostrarGrafo.Enabled = true;
                this.chkBusquedaAmplia.Enabled = true;
                this.chkBusquedaProfunda.Enabled = true;
                this.chkEliminarArista.Enabled = true;
                this.chkEliminarVertice.Enabled = true;

                this.chkAgregarArista.Checked = false;
                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkEliminarArista.Checked = false;
                this.chkEliminarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;
            }
            #endregion
        }

        private void chkEliminarVertice_CheckedChanged(object sender, EventArgs e)
        {
            #region Check
            if (this.chkEliminarVertice.Checked)
            {
                this.chkAgregarVertice.Enabled = false;
                this.chkAgregarArista.Enabled = false;
                this.chkMostrarGrafo.Enabled = false;
                this.chkBusquedaAmplia.Enabled = false;
                this.chkBusquedaProfunda.Enabled = false;
                this.chkEliminarArista.Enabled = false;
                this.chkEliminarVertice.Enabled = true;

                this.cboVertice.Items.Clear();
                for (int i = 0; i < Vertices; i++)
                    this.cboVertice.Items.Add(i + 1);


                this.chkAgregarArista.Checked = false;
                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkEliminarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;

            }
            else
            {
                this.chkAgregarVertice.Enabled = true;
                this.chkAgregarArista.Enabled = true;
                this.chkMostrarGrafo.Enabled = true;
                this.chkBusquedaAmplia.Enabled = true;
                this.chkBusquedaProfunda.Enabled = true;
                this.chkEliminarArista.Enabled = true;
                this.chkEliminarVertice.Enabled = true;

                this.chkAgregarArista.Checked = false;
                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkEliminarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;
            }
            #endregion
        }

        private void chkAgregarArista_CheckedChanged(object sender, EventArgs e)
        {
            #region Check
            if (this.chkAgregarArista.Checked)
            {
                this.chkAgregarVertice.Enabled = false;
                this.chkAgregarArista.Enabled = true;
                this.chkMostrarGrafo.Enabled = false;
                this.chkBusquedaAmplia.Enabled = false;
                this.chkBusquedaProfunda.Enabled = false;
                this.chkEliminarArista.Enabled = false;
                this.chkEliminarVertice.Enabled = false;

                cboV1.Items.Clear();
                cboV2.Items.Clear();

                for (int i = 0; i < Vertices; i++)
                {
                    cboV1.Items.Add(i + 1);
                    cboV2.Items.Add(i + 1);
                }

                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkEliminarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;
                this.chkEliminarVertice.Checked = false;

            }
            else
            {
                this.chkAgregarVertice.Enabled = true;
                this.chkAgregarArista.Enabled = true;
                this.chkMostrarGrafo.Enabled = true;
                this.chkBusquedaAmplia.Enabled = true;
                this.chkBusquedaProfunda.Enabled = true;
                this.chkEliminarArista.Enabled = true;
                this.chkEliminarVertice.Enabled = true;

                this.chkAgregarArista.Checked = false;
                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkEliminarArista.Checked = false;
                this.chkEliminarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;
            }
            #endregion
        }

        private void chkEliminarArista_CheckedChanged(object sender, EventArgs e)
        {
            #region Check
            if (this.chkEliminarArista.Checked)
            {
                this.chkAgregarVertice.Enabled = false;
                this.chkAgregarArista.Enabled = false;
                this.chkMostrarGrafo.Enabled = false;
                this.chkBusquedaAmplia.Enabled = false;
                this.chkBusquedaProfunda.Enabled = false;
                this.chkEliminarArista.Enabled = true;
                this.chkEliminarVertice.Enabled = false;

                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkAgregarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;
                this.chkEliminarVertice.Checked = false;

            }
            else
            {
                this.chkAgregarVertice.Enabled = true;
                this.chkAgregarArista.Enabled = true;
                this.chkMostrarGrafo.Enabled = true;
                this.chkBusquedaAmplia.Enabled = true;
                this.chkBusquedaProfunda.Enabled = true;
                this.chkEliminarArista.Enabled = true;
                this.chkEliminarVertice.Enabled = true;

                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkAgregarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;
                this.chkEliminarVertice.Checked = false;
            }
            #endregion
        }

        private void chkBusquedaAmplia_CheckedChanged(object sender, EventArgs e)
        {
            #region Check
            if (this.chkBusquedaAmplia.Checked)
            {
                this.chkAgregarVertice.Enabled = false;
                this.chkAgregarArista.Enabled = false;
                this.chkMostrarGrafo.Enabled = false;
                this.chkBusquedaAmplia.Enabled = true;
                this.chkBusquedaProfunda.Enabled = false;
                this.chkEliminarArista.Enabled = false;
                this.chkEliminarVertice.Enabled = false;

                this.cboBuscar.Items.Clear();
                for (int i = 0; i < Vertices; i++)
                    this.cboBuscar.Items.Add(i + 1);

                this.chkEliminarArista.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkAgregarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;
                this.chkEliminarVertice.Checked = false;

            }
            else
            {
                this.chkAgregarVertice.Enabled = true;
                this.chkAgregarArista.Enabled = true;
                this.chkMostrarGrafo.Enabled = true;
                this.chkBusquedaAmplia.Enabled = true;
                this.chkBusquedaProfunda.Enabled = true;
                this.chkEliminarArista.Enabled = true;
                this.chkEliminarVertice.Enabled = true;

                this.cboBuscar.Items.Clear();

                this.chkEliminarArista.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkAgregarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;
                this.chkEliminarVertice.Checked = false;
            }
            #endregion
        }

        private void chkBusquedaProfunda_CheckedChanged(object sender, EventArgs e)
        {
            #region Check
            if (this.chkBusquedaProfunda.Checked)
            {
                this.chkAgregarVertice.Enabled = false;
                this.chkAgregarArista.Enabled = false;
                this.chkMostrarGrafo.Enabled = false;
                this.chkBusquedaAmplia.Enabled = false;
                this.chkBusquedaProfunda.Enabled = true;
                this.chkEliminarArista.Enabled = false;
                this.chkEliminarVertice.Enabled = false;

                this.cboBuscar.Items.Clear();
                for (int i = 0; i < Vertices; i++)
                    this.cboBuscar.Items.Add(i + 1);

                this.chkEliminarArista.Checked = false;
                this.chkBusquedaAmplia.Checked = false;
                this.chkAgregarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;
                this.chkEliminarVertice.Checked = false;

            }
            else
            {
                this.chkAgregarVertice.Enabled = true;
                this.chkAgregarArista.Enabled = true;
                this.chkMostrarGrafo.Enabled = true;
                this.chkBusquedaAmplia.Enabled = true;
                this.chkBusquedaProfunda.Enabled = true;
                this.chkEliminarArista.Enabled = true;
                this.chkEliminarVertice.Enabled = true;

                this.cboBuscar.Items.Clear();

                this.chkEliminarArista.Checked = false;
                this.chkBusquedaAmplia.Checked = false;
                this.chkAgregarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;
                this.chkEliminarVertice.Checked = false;
            }
            #endregion
        }

        private void btnEjecutarArista_Click(object sender, EventArgs e)
        {
            try
            {
                int vertice1 = int.Parse(this.cboV1.Text);
                int vertice2 = int.Parse(this.cboV2.Text);

                if (this.chkAgregarArista.Checked == true && this.chkEliminarArista.Checked == false) // para agregar
                {
                    vertice1 = int.Parse(this.cboV1.Text);
                    vertice2 = int.Parse(this.cboV2.Text);
                    lapiz = new Pen(Color.White);

                    #region pintar aristas
                    switch (Vertices)
                    {
                        case 3: // 3 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }

                            break;

                        case 4: // 6 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 3 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }

                            break;

                        case 5: // 10 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 3 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            } //

                            break;

                        case 6: // 15 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 3 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            } //
                            else if ((vertice1 == 1 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//

                            break;

                        case 7: // 21 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 3 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            } //
                            else if ((vertice1 == 1 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 6 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 6))
                            {
                                panel.DrawLine(lapiz, mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            } // 

                            break;

                        case 8:// 28 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 3 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 8))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            } //
                            else if ((vertice1 == 1 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 6 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 6))
                            {
                                panel.DrawLine(lapiz, mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            } // 
                            else if ((vertice1 == 1 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 6 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 6))
                            {
                                panel.DrawLine(lapiz, mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 7 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 7))
                            {
                                panel.DrawLine(lapiz, mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.AgregarArista(vertice1 - 1, vertice2 - 1);
                            }

                            break;
                    }
                    #endregion

                    Aristas++; Contador++;

                    this.cboRutas.Items.RemoveAt(0); // elimina como tipo pila

                    if (Contador == auxArista)
                    {
                        for (int i = 0; i < this.cboRutas.Items.Count; i++)
                            this.cboRutas.Items[i] = i + 1;

                        if (this.cboRutas.Items.Count == 0)
                        {
                            MessageBox.Show("Se han agotado todas las posibles rutas.\nPor favor verifíquelas en el apartado \"Mostrar grafo\".", "No hay rutas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.cboRutas.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Rutas reestablecidas");
                            hayRutas = true;
                        }
                    }

                }
                else if (this.chkAgregarArista.Checked == false && this.chkEliminarArista.Checked == true) // para eliminar
                {
                    vertice1 = int.Parse(this.cboV1.Text);
                    vertice2 = int.Parse(this.cboV2.Text);
                    lapiz = new Pen(Color.Chocolate);

                    #region despintar aristas
                    switch (Vertices)
                    {
                        case 3: // 3 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }

                            break;

                        case 4: // 6 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 3 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }

                            break;

                        case 5: // 10 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 3 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            } //

                            break;

                        case 6: // 15 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 3 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            } //
                            else if ((vertice1 == 1 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//

                            break;

                        case 7: // 21 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 3 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            } //
                            else if ((vertice1 == 1 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 6 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 6))
                            {
                                panel.DrawLine(lapiz, mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            } // 

                            break;

                        case 8:// 28 aristas

                            if ((vertice1 == 1 && vertice2 == 2) || (vertice1 == 2 && vertice2 == 1))
                            {
                                // buscar como eliminar de la lista los vértices seleccionados
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1); // por el clase clase grafo la lista que contiene los vértices está indexada en 0
                            }
                            else if ((vertice1 == 2 && vertice2 == 3) || (vertice1 == 3 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 3 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 1 && vertice2 == 4) || (vertice1 == 4 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 5) || (vertice1 == 5 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            } //
                            else if ((vertice1 == 1 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 6) || (vertice1 == 6 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }//
                            else if ((vertice1 == 1 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 6 && vertice2 == 7) || (vertice1 == 7 && vertice2 == 6))
                            {
                                panel.DrawLine(lapiz, mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            } // 
                            else if ((vertice1 == 1 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 1))
                            {
                                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 2 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 2))
                            {
                                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 3 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 3))
                            {
                                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 4 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 4))
                            {
                                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 5 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 5))
                            {
                                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 6 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 6))
                            {
                                panel.DrawLine(lapiz, mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }
                            else if ((vertice1 == 7 && vertice2 == 8) || (vertice1 == 8 && vertice2 == 7))
                            {
                                panel.DrawLine(lapiz, mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                                grafo.EliminarArista(vertice1 - 1, vertice2 - 1);
                            }

                            break;
                    }
                    #endregion

                    Aristas--;
                    grafo.Aristas--;
                }
                else
                {
                    MessageBox.Show("Error al insertar/eliminar la arista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido lo siguiente: " + ex), "Error al ejecutar arista", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEjecutarVetice_Click(object sender, EventArgs e)
        {
            try
            {
                int vertice = int.Parse(this.cboVertice.Text);

                if (this.chkAgregarVertice.Checked == true && this.chkEliminarVertice.Checked == false) // agregar
                {
                    if (grafo.agregarV)
                    {
                        switch (vertice)
                        {
                            case 1:

                                this.mesa1.Visible = true;
                                grafo.AgregarVertice(0); // porque está en base 0
                                this.cboVertice.Text = "";
                                this.cboVertice.Items.Remove(1);
                                break;

                            case 2:

                                this.mesa2.Visible = true;
                                grafo.AgregarVertice(1);
                                this.cboVertice.Text = "";
                                this.cboVertice.Items.Remove(2);
                                break;

                            case 3:

                                this.mesa3.Visible = true;
                                grafo.AgregarVertice(2);
                                this.cboVertice.Text = "";
                                this.cboVertice.Items.Remove(3);

                                break;

                            case 4:

                                this.mesa4.Visible = true;
                                grafo.AgregarVertice(3);
                                this.cboVertice.Text = "";
                                this.cboVertice.Items.Remove(4);
                                break;

                            case 5:
                                this.mesa5.Visible = true;
                                grafo.AgregarVertice(4);
                                this.cboVertice.Text = "";
                                this.cboVertice.Items.Remove(5);
                                break;

                            case 6:
                                this.mesa6.Visible = true;
                                grafo.AgregarVertice(5);
                                this.cboVertice.Text = "";
                                this.cboVertice.Items.Remove(6);
                                break;

                            case 7:
                                this.mesa7.Visible = true;
                                grafo.AgregarVertice(6);
                                this.cboVertice.Text = "";
                                this.cboVertice.Items.Remove(7);
                                break;

                            case 8:
                                this.mesa8.Visible = true;
                                grafo.AgregarVertice(7);
                                this.cboVertice.Text = "";
                                this.cboVertice.Items.Remove(8);
                                break;
                        }
                        Vertices++;
                    }
                    else
                    {
                        switch (vertice)
                        {
                            case 1:
                                this.mesa1.Visible = true;
                                grafo.AgregarVertice(0); // porque está en base 0
                                break;
                            case 2:
                                this.mesa2.Visible = true;
                                grafo.AgregarVertice(1);
                                break;
                            case 3:

                                this.mesa3.Visible = true;
                                grafo.AgregarVertice(2);
                                break;

                            case 4:
                                this.mesa4.Visible = true;
                                grafo.AgregarVertice(3);
                                break;

                            case 5:
                                this.mesa5.Visible = true;
                                grafo.AgregarVertice(4);
                                break;

                            case 6:
                                this.mesa6.Visible = true; ;
                                grafo.AgregarVertice(5);

                                break;

                            case 7:
                                this.mesa7.Visible = true;
                                grafo.AgregarVertice(6);
                                break;

                            case 8:
                                this.mesa8.Visible = true;
                                grafo.AgregarVertice(7);
                                break;
                        }
                    }
                }
                else if (this.chkAgregarVertice.Checked == false && this.chkEliminarVertice.Checked == true) // eliminar
                {

                    switch (vertice)
                    {
                        case 1:
                            this.mesa1.Visible = false;
                            this.cboVertice.Items.Remove(1);
                            grafo.EliminarVertice(0); // porque está en base 0
                            break;
                        case 2:
                            this.mesa2.Visible = false;
                            this.cboVertice.Items.Remove(2);
                            grafo.EliminarVertice(1);
                            break;
                        case 3:
                            this.mesa3.Visible = false;
                            this.cboVertice.Items.Remove(3);
                            grafo.EliminarVertice(2);
                            break;

                        case 4:
                            this.mesa4.Visible = false;
                            this.cboVertice.Items.Remove(4);
                            grafo.EliminarVertice(3);
                            break;

                        case 5:
                            this.mesa5.Visible = false;
                            this.cboVertice.Items.Remove(5);
                            grafo.EliminarVertice(4);
                            break;

                        case 6:
                            this.mesa6.Visible = false;
                            this.cboVertice.Items.Remove(6);
                            grafo.EliminarVertice(5);

                            break;

                        case 7:
                            this.mesa7.Visible = false;
                            this.cboVertice.Items.Remove(7);
                            grafo.EliminarVertice(6);
                            break;

                        case 8:
                            this.mesa8.Visible = false;
                            this.cboVertice.Items.Remove(8);
                            grafo.EliminarVertice(7);
                            break;
                    }
                    Vertices--;
                }
                else
                {
                    MessageBox.Show("Error al insertar/eliminar una nueva mesa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido lo siguiente: " + ex), "Error al ejecutar vértice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public string BuscarGrafo(object buscar)
        {
            int valor = 0;
            string s = "";

            if (buscar.Equals(busquedaAmplia))
            {
                valor = busquedaAmplia.verticeRecurso;
                for (int i = 0; i < Vertices; i++)
                {
                    s += string.Format("{0} a {1}: ", valor, i + 1);
                    if (busquedaAmplia.TieneCamino(i))
                        foreach (int x in busquedaAmplia.CaminoPara(i))
                            if (x == valor) s += valor.ToString();
                            else s += string.Format("-" + (x + 1));
                    s += "\n";
                }
                return s;
            }
            else
            {
                valor = busquedaProfunda.source;
                for (int i = 0; i < Vertices; i++)
                {
                    s += string.Format("{0} a {1}: ", valor, i + 1);
                    if (busquedaProfunda.TieneCamino(i))
                        foreach (int x in busquedaProfunda.CaminoPara(i))
                            if (x == valor) s += valor.ToString();
                            else s += string.Format("-" + (x + 1));
                    s += "\n";
                }
                return s;
            }
        }

        private void btnEjecutarBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.cboBuscar.Text))
                {
                    MessageBox.Show("Error.\nEscoja un inicio para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (this.chkBusquedaAmplia.Checked == true && this.chkBusquedaProfunda.Checked == false) // para amplia
                    {
                        busquedaAmplia = new BusquedaAmplia(grafo, int.Parse(this.cboBuscar.Text));
                        MessageBox.Show(BuscarGrafo(busquedaAmplia), "Resultado de la búsqueda amplia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.chkBusquedaAmplia.Checked == false && this.chkBusquedaProfunda.Checked == true) // para profunda
                    {
                        busquedaProfunda = new BusquedaProfunda(grafo, int.Parse(this.cboBuscar.Text));
                        MessageBox.Show(BuscarGrafo(busquedaProfunda), "Resultado de la búsqueda profunda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error.\nEscoja un inicio para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido esto: "+ex), "Error en las búsquedas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Eventos para animar botones

        private void btnIniciar_MouseHover(object sender, EventArgs e)
        {
            this.btnIniciar.Height = 75;
            this.btnIniciar.Width = 75;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            this.btnIniciar.Height = 70;
            this.btnIniciar.Width = 70;
        }

        private void btnEjecutarVetice_MouseHover(object sender, EventArgs e)
        {
            this.btnEjecutarVetice.Height = 43;
            this.btnEjecutarVetice.Width = 37;
        }

        private void btnEjecutarVetice_MouseLeave(object sender, EventArgs e)
        {
            this.btnEjecutarVetice.Height = 39;
            this.btnEjecutarVetice.Width = 33;
        }

        private void btnEjecutarArista_MouseHover(object sender, EventArgs e)
        {
            this.btnEjecutarArista.Height = 43;
            this.btnEjecutarArista.Width = 37;
        }

        private void btnEjecutarArista_MouseLeave(object sender, EventArgs e)
        {
            this.btnEjecutarArista.Height = 39;
            this.btnEjecutarArista.Width = 33;
        }

        private void btnEjecutarBusqueda_MouseHover(object sender, EventArgs e)
        {
            this.btnEjecutarBusqueda.Height = 43;
            this.btnEjecutarBusqueda.Width = 37;
        }

        private void btnEjecutarBusqueda_MouseLeave(object sender, EventArgs e)
        {
            this.btnEjecutarBusqueda.Height = 39;
            this.btnEjecutarBusqueda.Width = 33;
        }

        private void btnReestablecer_MouseLeave(object sender, EventArgs e)
        {
            this.btnReestablecer.Height = 57;
            this.btnReestablecer.Width = 52;
        }

        private void btnReestablecer_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnReestablecer.Height = 62;
            this.btnReestablecer.Width = 57;
        }

        #endregion

        private void frmGrafos_Load(object sender, EventArgs e)
        {
            this.cboBuscar.Items.Clear();
            this.cboRutas.Items.Clear();
            this.cboV1.Items.Clear();
            this.cboV2.Items.Clear();
            this.cboVertice.Items.Clear();
            hayRutas = false;
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea reestablecer el grafo actual?", "Reestablecer aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.cboBuscar.SelectedText = "";
                this.cboRutas.SelectedText = "";
                this.cboV1.SelectedText = "";
                this.cboV1.Text = "";
                this.cboV2.Text = "";
                this.cboV2.SelectedText = "";
                this.cboVertice.SelectedText = "";

                this.cboBuscar.Items.Clear();
                this.cboRutas.Items.Clear();
                this.cboV1.Items.Clear();
                this.cboV2.Items.Clear();
                this.cboVertice.Items.Clear();

                this.mesa1.Visible = false;
                this.mesa2.Visible = false;
                this.mesa3.Visible = false;
                this.mesa4.Visible = false;
                this.mesa5.Visible = false;
                this.mesa6.Visible = false;
                this.mesa7.Visible = false;
                this.mesa8.Visible = false;

                panel = panel1.CreateGraphics();
                lapiz = new Pen(Color.Chocolate);

                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2));
                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2));
                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2));
                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2));
                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2));
                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                panel.DrawLine(lapiz, mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2), mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2));
                panel.DrawLine(lapiz, mesa1.Location.X + (mesa1.Height / 2), mesa1.Location.Y + (mesa1.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                panel.DrawLine(lapiz, mesa2.Location.X + (mesa2.Height / 2), mesa2.Location.Y + (mesa2.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                panel.DrawLine(lapiz, mesa3.Location.X + (mesa3.Height / 2), mesa3.Location.Y + (mesa3.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                panel.DrawLine(lapiz, mesa4.Location.X + (mesa4.Height / 2), mesa4.Location.Y + (mesa4.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                panel.DrawLine(lapiz, mesa5.Location.X + (mesa5.Height / 2), mesa5.Location.Y + (mesa5.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                panel.DrawLine(lapiz, mesa6.Location.X + (mesa6.Height / 2), mesa6.Location.Y + (mesa6.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));
                panel.DrawLine(lapiz, mesa7.Location.X + (mesa7.Height / 2), mesa7.Location.Y + (mesa7.Width / 2), mesa8.Location.X + (mesa8.Height / 2), mesa8.Location.Y + (mesa8.Width / 2));

                this.chkAgregarArista.Checked = false;
                this.chkAgregarVertice.Checked = false;
                this.chkBusquedaAmplia.Checked = false;
                this.chkBusquedaProfunda.Checked = false;
                this.chkEliminarArista.Checked = false;
                this.chkEliminarVertice.Checked = false;
                this.chkMostrarGrafo.Checked = false;

                hayRutas = false;
            }

        }
    }
}
