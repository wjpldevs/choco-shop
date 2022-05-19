using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Chocolateria
{
    public partial class frmOrdenacion : Form
    {
        public frmOrdenacion()
        {
            InitializeComponent();
        }

        private frmPrincipal principal;

        private Interno ordenamientoInterno;
        private Busqueda busqueda;

        private static StreamReader leerF1, leerF2;
        private static StreamWriter escribirF1, escribirF2, escribirF3;

        private static StreamReader F_Lectura, F1_Lectura, F2_Lectura;
        private static StreamWriter F_Escritura, F1_Escritura, F2_Escritura;

        private static StreamReader F_Lect, F1_Lect, F2_Lect, F3_Lect;
        private static StreamWriter F_Escrit, F1_Escrit, F2_Escrit, F3_Escrit;

        public int CantidadProductos { get; set; }
        public int Puntero { get; set; }

        public struct Producto
        {
            public string Nombre, Codigo, TipoProducto;
            public int Cantidad;
            public DateTime FechaVencimiento;
            public decimal Precio;
        }

        private List<decimal> listaPro1;
        private List<decimal> listaPro2;

        public Producto[] listaProductos;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtIniciar.Equals("") || int.Parse(this.txtIniciar.Text) <= 0)
                {
                    MessageBox.Show("Error", "Error en el botón iniciar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtIniciar.Clear(); this.txtIniciar.Focus();
                }
                else
                {
                    try
                    {
                        Puntero = 0;
                        CantidadProductos = int.Parse(this.txtIniciar.Text);
                        listaProductos = new Producto[CantidadProductos];
                        listaPro1 = new List<decimal>(CantidadProductos);
                        listaPro2 = new List<decimal>(CantidadProductos);

                        this.txtIniciar.Clear();
                        this.txtNombre.Focus();
                        this.txtIniciar.Enabled = false;

                        //---------- se necesita eliminar el archivo 2 de mezcla equilibrada
                        //System.IO.FileInfo archivo2 = new System.IO.FileInfo("MezclaEquilibrada_F2.txt");
                        //try
                        //{
                        //    archivo2.Delete();
                        //}
                        //catch (System.IO.IOException ex)
                        //{
                        //    MessageBox.Show(string.Format("Ha ocurrido lo siguiente: "+ex), "Error al eliminar el archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        //----------
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(string.Format("Ha ocurrido lo siguiente: " + ex), "Error en el botón iniciar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtIniciar.Clear(); this.txtIniciar.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido lo siguiente: " + ex), "Error en el botón iniciar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarControles()
        {
            this.txtNombre.Clear();
            this.txtCodigo.Clear();
            this.txtCantidad.Clear();
            this.txtPrecio.Clear();
            this.txtNombre.Focus();
        }

        private void Mostrar()
        {
            dtgProductos.Rows.Clear();
            for (int i = 0; i < listaProductos.Length; i++)
                dtgProductos.Rows.Add(listaProductos[i].Nombre, listaProductos[i].Codigo, listaProductos[i].Cantidad, listaProductos[i].FechaVencimiento, listaProductos[i].Precio, listaProductos[i].TipoProducto);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtPrecio.Text) ||
                    string.IsNullOrEmpty(this.txtCodigo.Text) || string.IsNullOrEmpty(this.txtCantidad.Text))
                {
                    MessageBox.Show(string.Format("Hay un valor que no válido.\nPor favor verifique nuevamente."), "Error en el ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtNombre.Focus();
                }
                else
                {
                    listaProductos[Puntero].Nombre = this.txtNombre.Text;
                    listaProductos[Puntero].Codigo = this.txtCodigo.Text;
                    listaProductos[Puntero].Cantidad = int.Parse(this.txtCantidad.Text);
                    listaProductos[Puntero].FechaVencimiento = DateTime.Parse(this.txtFechaVencimiento.Text);
                    listaProductos[Puntero].Precio = decimal.Parse(this.txtPrecio.Text);
                    listaProductos[Puntero].TipoProducto = this.cboTipoProducto.Text;

                    dtgProductos.Rows.Add(listaProductos[Puntero].Nombre, listaProductos[Puntero].Codigo, listaProductos[Puntero].Cantidad, listaProductos[Puntero].FechaVencimiento, listaProductos[Puntero].Precio, listaProductos[Puntero].TipoProducto);

                    Puntero++;

                    if (Puntero == listaProductos.Length)
                    {
                        MessageBox.Show(string.Format("{0} productos ingresados exitosamente", listaProductos.Length), "Productos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                    }
                    else
                    {
                        LimpiarControles();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido el siguiente error: {0}", ex), "Error al agregar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtBuscar.Text) || decimal.Parse(this.txtBuscar.Text) <= 0)
                {
                    MessageBox.Show("Error.\nIntente buscar con un valor válido");
                }
                else
                {
                    busqueda = new Busqueda(listaProductos);
                    busqueda.BusquedaBinaria(decimal.Parse(this.txtBuscar.Text));
                    this.txtBuscar.Clear();
                    this.txtBuscar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido lo siguiente: "+ex), "Error en búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Hover(object sender, EventArgs e)
        {
            this.btnBuscar.Height = 47;
            this.btnBuscar.Width = 62;
        }

        private void SoloTexto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
                return;
            }
        }

        private void SoloEntero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void SoloDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void SoloTextoDigito(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }
        }

        private void btnAgregar_Hover(object sender, EventArgs e)
        {
            this.btnAgregar.Height = 74;
            this.btnAgregar.Width = 75;
        }

        private void btnAgregar_Leave(object sender, EventArgs e)
        {
            this.btnAgregar.Height = 69;
            this.btnAgregar.Width = 75;
        }

        private void btnEliminar_Hover(object sender, EventArgs e)
        {
            this.btnEliminar.Height = 47;
            this.btnEliminar.Width = 62;
        }

        private void btnEliminar_Leave(object sender, EventArgs e)
        {
            this.btnEliminar.Height = 42;
            this.btnEliminar.Width = 57;
        }

        private void btnBuscar_Leave(object sender, EventArgs e)
        {
            this.btnBuscar.Height = 42;
            this.btnBuscar.Width = 57;
        }

        private void btnIniciar_Hover(object sender, EventArgs e)
        {
            this.btnIniciar.Height = 75;
            this.btnIniciar.Width = 75;
        }

        private void btnIniciar_Leave(object sender, EventArgs e)
        {
            this.btnIniciar.Height = 70;
            this.btnIniciar.Width = 70;
        }

        private void frmOrdenacion_Load(object sender, EventArgs e)
        {
            // void
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                bool encontrado = false;
                if (string.IsNullOrEmpty(this.txtEliminar.Text))
                {
                    MessageBox.Show("Error al eliminar el producto.\nVerifique si ha ingresado una cadena válida.", "Error en eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtEliminar.Clear();
                    this.txtEliminar.Focus();
                }
                else
                {
                    string code = this.txtEliminar.Text;

                    for (int i = 0; i < this.dtgProductos.Rows.Count - 1; i++)
                    {
                        if (this.dtgProductos[1, i].Value.Equals(code))
                        {
                            this.dtgProductos.Rows.RemoveAt(i);
                            listaProductos.SetValue(null, i);
                            encontrado = true;
                            return;
                        }
                    }
                    
                    if (encontrado)
                    {
                        Mostrar();
                        this.txtEliminar.Clear();
                        this.txtEliminar.Focus();
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado el código: "+code, "Error en eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtEliminar.Clear();
                        this.txtEliminar.Focus();
                    }

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido lo siguiente: "+ex), "Error en eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtEliminar.Clear();
                this.txtEliminar.Focus();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            principal = new frmPrincipal();
            principal.Show();
        }

        private void chkInternos_Checked(object sender, EventArgs e)
        {
            chkExternos.Checked = false;
            this.cboMetodos.Focus();
            this.cboMetodos.Items.Clear();
            this.cboMetodos.Items.Add("Selección");
            this.cboMetodos.Items.Add("Inserción");
            this.cboMetodos.Items.Add("Intercambio");
            this.cboMetodos.Items.Add("Shellsort");
            this.cboMetodos.Items.Add("Quicksort");
            this.cboMetodos.Items.Add("Heapsort");
            this.cboMetodos.Items.Add("Radixsort");
            this.cboMetodos.Items.Add("Binsort");
        }

        private void chkExternos_Checked(object sender, EventArgs e)
        {
            chkInternos.Checked = false;
            this.cboMetodos.Focus();
            this.cboMetodos.Items.Clear();
            this.cboMetodos.Items.Add("Intercalación de archivos");
            this.cboMetodos.Items.Add("Mezcla directa");
            this.cboMetodos.Items.Add("Mezcla equilibrada");
        }

        private void cboMetodos_Select(object sender, EventArgs e)
        {
            ordenamientoInterno = new Interno(listaProductos);

            switch (this.cboMetodos.Text)
            {
                case "Selección":
                    ordenamientoInterno.Seleccion();
                    Mostrar();
                    MessageBox.Show("Datos ordenados");
                    break;

                case "Inserción":
                    ordenamientoInterno.Insercion();
                    Mostrar();
                    MessageBox.Show("Datos ordenados");

                    break;

                case "Intercambio":
                    ordenamientoInterno.Intercambio();
                    Mostrar();
                    MessageBox.Show("Datos ordenados");
                    break;

                case "Shellsort":
                    ordenamientoInterno.ShellSort();
                    Mostrar();
                    MessageBox.Show("Datos ordenados");
                    break;

                case "Quicksort":
                    ordenamientoInterno.Quicksort(0, listaProductos.Length - 1);
                    Mostrar();
                    MessageBox.Show("Datos ordenados");
                    break;

                case "Heapsort":
                    ordenamientoInterno.HeapSort();
                    Mostrar();
                    MessageBox.Show("Datos ordenados");
                    break;

                case "Radixsort":
                    ordenamientoInterno.RadixSortMejorado();
                    Mostrar();
                    MessageBox.Show("Datos ordenados");
                    break;

                case "Intercalación de archivos":
                    try
                    {
                        Intercalacion();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    break;

                case "Binsort":
                    Producto[] array = ordenamientoInterno.OrdenacionCasillero(listaProductos, listaProductos.Length).ToArray();
                    dtgProductos.Rows.Clear();
                    foreach (Producto prod in array)
                    {
                        this.dtgProductos.Rows.Add(prod);
                    }
                    break;

                case "Mezcla directa":
                    try
                    {
                        Escribir();
                        Mezclar(F_Lectura, F_Escritura, F1_Lectura, F1_Escritura, F2_Lectura, F2_Escritura);
                        MessageBox.Show("Se han ordenado los datos satisfactoriamente.", "Datos ordenados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido lo siguiente: " + ex, "Error al ordenar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Mezcla equilibrada":
                    try
                    {
                        EscribirMezclaE();
                        Ordenar_Por_Mezcla_Equilibrada();
                        MessageBox.Show("Se han ordenado los datos satisfactoriamente.", "Datos ordenados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido lo siguiente: " + ex, "Error al ordenar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                default:
                    break;
            }
        }

        #region Intercalacion
        public void Intercalacion()
        {
            try
            {
                EscribirOrdenar();

                leerF1 = new StreamReader("F1.txt");
                leerF2 = new StreamReader("F2.txt");
                escribirF3 = new StreamWriter("F3.txt");

                bool bandera1 = true;
                bool bandera2 = true;

                int puntuero1 = 0, puntuero2 = 0;

                while ((!leerF1.EndOfStream || bandera1 == false) && (!leerF2.EndOfStream || bandera2 == false))
                {
                    if (bandera1 == true)
                    {
                        puntuero1 = Convert.ToInt32(leerF1.ReadLine());
                        bandera1 = false;
                    }

                    if (bandera2 == true)
                    {
                        puntuero2 = Convert.ToInt32(leerF2.ReadLine());
                        bandera2 = false;
                    }

                    if (puntuero1 < puntuero2)
                    {
                        escribirF3.WriteLine(puntuero1.ToString());
                        bandera1 = true;
                    }
                    else
                    {
                        escribirF3.WriteLine(puntuero2.ToString());
                        bandera2 = true;
                    }

                }

                // verifica si se leyó de F1 y no se copió a F3
                if (bandera1 == false)
                {
                    escribirF3.WriteLine(puntuero1.ToString());
                    while (!leerF1.EndOfStream)
                    {
                        puntuero1 = Convert.ToInt32(leerF1.ReadLine());
                        escribirF3.WriteLine(puntuero1);
                    }
                }

                // verifica si se leyó de F2 y no se copió a F3
                if (bandera2 == false)
                {
                    escribirF3.WriteLine(puntuero2.ToString());
                    while (!leerF2.EndOfStream)
                    {
                        puntuero2 = Convert.ToInt32(leerF2.ReadLine());
                        escribirF3.WriteLine(puntuero2);

                    }
                }

                leerF1.Close();
                leerF2.Close();
                escribirF3.Close();

                MessageBox.Show("Se han ordenado los datos satisfactoriamente.", "Datos ordenados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido lo siguiente: " + ex, "Error al ordenar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        public void EscribirOrdenar()
        {
            // datos ordenados
            for (int i = 0; i < listaProductos.Length; i++)
            {
                if (i % 2 == 0)
                {
                    listaPro1.Add(listaProductos[i].Precio);
                }
                else
                {
                    listaPro2.Add(listaProductos[i].Precio);
                }
            }

            listaPro1.Sort();
            listaPro2.Sort();

            escribirF1 = new StreamWriter("F1.txt");

            for (int i = 0; i < listaPro1.Count; i++)
                escribirF1.WriteLine(listaPro1[i]);

            //-----

            escribirF2 = new StreamWriter("F2.txt");

            for (int i = 0; i < listaPro2.Count; i++)
                escribirF2.WriteLine(listaPro2[i]);

            escribirF1.Close();
            escribirF2.Close();
        }
        #endregion 

        #region Mezcla Directa
        public void Escribir()
        {
            F_Escritura = new StreamWriter("MezclaDirecta_F.txt");

            for (int i = 0; i < listaProductos.Length; i++)
            {
                F_Escritura.WriteLine(listaProductos[i].Precio);
            }

            F_Escritura.Close();
        }
        public static int ObtenerCantidad(StreamReader archivoPrincipal)
        {
            archivoPrincipal = new StreamReader("MezclaDirecta_F.txt");
            int cantidad = 0;
            while (!archivoPrincipal.EndOfStream) { string cadena = archivoPrincipal.ReadLine(); cantidad++; }
            archivoPrincipal.Close();
            return cantidad;
        }
        public void Mezclar(StreamReader F_Lectura, StreamWriter F_Escritura, StreamReader F1_Lectura, StreamWriter F1_Escritura, StreamReader F2_Lectura, StreamWriter F2_Escritura)
        {

            int particion = 1, vueltas = ObtenerCantidad(F_Lectura); // para determinar las vueltas a veces la fórmula no es necesaria

            while (particion <= vueltas)
            {
                F_Lectura = new StreamReader("MezclaDirecta_F.txt");
                F1_Escritura = new StreamWriter("MezclaDirecta_F1.txt");
                F2_Escritura = new StreamWriter("MezclaDirecta_F2.txt");

                Particionar(F_Lectura, F1_Escritura, F2_Escritura, particion);

                F_Lectura.Close();
                F1_Escritura.Close();
                F2_Escritura.Close();

                F_Escritura = new StreamWriter("MezclaDirecta_F.txt");
                F1_Lectura = new StreamReader("MezclaDirecta_F1.txt");
                F2_Lectura = new StreamReader("MezclaDirecta_F2.txt");

                Fusionar(F_Escritura, F1_Lectura, F2_Lectura, particion);

                particion *= 2;
            }

        }
        public static void Particionar(StreamReader F_Lectura, StreamWriter F1_Escritura, StreamWriter F2_Escritura, int particion)
        {
            int puntero = 0;

            while (!F_Lectura.EndOfStream)
            {
                int puntero_F1 = 0;
                while (puntero_F1 < particion && !F_Lectura.EndOfStream)
                {
                    puntero = Convert.ToInt32(F_Lectura.ReadLine());
                    F1_Escritura.WriteLine(puntero);
                    puntero_F1++;
                }

                int puntero_F2 = 0;
                while (puntero_F2 < particion && !F_Lectura.EndOfStream)
                {
                    puntero = Convert.ToInt32(F_Lectura.ReadLine());
                    F2_Escritura.WriteLine(puntero);
                    puntero_F2++;
                }
            }
        }
        public static void Fusionar(StreamWriter F_Escritura, StreamReader F1_Lectura, StreamReader F2_Lectura, int particion)
        {
            bool bandera_1 = true, bandera_2 = true;

            int read_1 = 0, read_2 = 0;

            if (!F1_Lectura.EndOfStream)
            {
                read_1 = Convert.ToInt32(F1_Lectura.ReadLine());
                bandera_1 = false;
            }

            if (!F2_Lectura.EndOfStream)
            {
                read_2 = Convert.ToInt32(F2_Lectura.ReadLine());
                bandera_2 = false;
            }

            while ((!F1_Lectura.EndOfStream || bandera_1 == false) && (!F2_Lectura.EndOfStream || bandera_2 == false))
            {
                int puntero_1 = 0, puntero_2 = 0;

                while ((puntero_1 < particion && bandera_1 == false) && (puntero_2 < particion && bandera_2 == false))
                {
                    if (read_1 <= read_2)
                    {
                        F_Escritura.WriteLine(read_1);
                        bandera_1 = true; puntero_1++;

                        if (!F1_Lectura.EndOfStream)
                        {
                            read_1 = Convert.ToInt32(F1_Lectura.ReadLine());
                            bandera_1 = false;
                        }
                    }
                    else
                    {
                        F_Escritura.WriteLine(read_2);
                        bandera_2 = true; puntero_2++;
                        if (!F2_Lectura.EndOfStream)
                        {
                            read_2 = Convert.ToInt32(F2_Lectura.ReadLine());
                            bandera_2 = false;
                        }
                    }
                }

                while (puntero_1 < particion && bandera_1 == false)
                {
                    F_Escritura.WriteLine(read_1);
                    bandera_1 = true; puntero_1++;

                    if (!F1_Lectura.EndOfStream)
                    {
                        read_1 = Convert.ToInt32(F1_Lectura.ReadLine());
                        bandera_1 = false;
                    }
                }

                while (puntero_2 < particion && bandera_2 == false)
                {
                    F_Escritura.WriteLine(read_2);
                    bandera_2 = true; puntero_2++;

                    if (!F2_Lectura.EndOfStream)
                    {
                        read_2 = Convert.ToInt32(F2_Lectura.ReadLine());
                        bandera_2 = false;
                    }
                }

            }

            if (bandera_1 == false) { F_Escritura.WriteLine(read_1); }

            if (bandera_2 == false) { F_Escritura.WriteLine(read_2); }

            while (!F1_Lectura.EndOfStream)
            {
                read_1 = Convert.ToInt32(F1_Lectura.ReadLine());
                F_Escritura.WriteLine(read_1);
            }

            while (!F2_Lectura.EndOfStream)
            {
                read_2 = Convert.ToInt32(F2_Lectura.ReadLine());
                F_Escritura.WriteLine(read_2);
            }

            F_Escritura.Close();
            F1_Lectura.Close();
            F2_Lectura.Close();

        }
        #endregion

        #region Mezcla Equilibrada
        public static int Cantidad { get; set; }
        public void EscribirMezclaE()
        {
            F_Escrit = new StreamWriter("MezclaEquilibrada_F.txt");

            for (int i = 0; i < listaProductos.Length; i++)
            {
                F_Escrit.WriteLine(listaProductos[i].Precio);
            }

            F_Escrit.Close();
        }
        public static void Ordenar_Por_Mezcla_Equilibrada()
        {
            try
            {
                Mezcla_Equilibrada(F_Lect, F_Escrit, F1_Lect, F1_Escrit, F2_Lect, F2_Escrit, F3_Lect, F3_Escrit);

                F2_Lect = new StreamReader("MezclaEquilibrada_F2.txt");
                F_Escrit = new StreamWriter("MezclaEquilibrada_F.txt");

                while (!F2_Lect.EndOfStream)
                {
                    string cadena = F2_Lect.ReadLine();
                    F_Escrit.WriteLine(cadena);
                }

                F2_Lect.Close();
                F_Escrit.Close();

                Mezcla_Equilibrada(F_Lect, F_Escrit, F1_Lect, F1_Escrit, F2_Lect, F2_Escrit, F3_Lect, F3_Escrit);

                MessageBox.Show("Se ha ordenado el archivo satisfactoriamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido lo siguiente: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static bool EstaVacio(StreamReader Archivo, string nombreArchivo)
        {
            Cantidad = 0;

            Archivo = new StreamReader(nombreArchivo);

            while (!Archivo.EndOfStream)
            {
                string cadena = Archivo.ReadLine();
                Cantidad++;
            }

            Archivo.Close();

            bool vacio = (Cantidad == 0) ? true : false; // si retorna true está vacío, sino contiene al menos un elemento
            return vacio;

        }
        public static void Mezcla_Equilibrada(StreamReader Ar_Lectura, StreamWriter Ar_Escritura, StreamReader Ar1_Lectura, StreamWriter Ar1_Escritura, StreamReader Ar2_Lectura, StreamWriter Ar2_Escritura, StreamReader Ar3_Lectura, StreamWriter Ar3_Escritura)
        {
            bool bandera;

            Ar_Lectura = new StreamReader("MezclaEquilibrada_F.txt");
            Ar2_Escritura = new StreamWriter("MezclaEquilibrada_F2.txt");
            Ar3_Escritura = new StreamWriter("MezclaEquilibrada_F3.txt");

            Particion_Inicial(Ar_Lectura, Ar2_Escritura, Ar3_Escritura);

            Ar2_Lectura = new StreamReader("MezclaEquilibrada_F2.txt");
            Ar3_Lectura = new StreamReader("MezclaEquilibrada_F3.txt");
            Ar_Escritura = new StreamWriter("MezclaEquilibrada_F.txt");
            Ar1_Escritura = new StreamWriter("MezclaEquilibrada_F1.txt");

            Fusion_Particion(Ar2_Lectura, Ar3_Lectura, Ar_Escritura, Ar1_Escritura);

            bandera = false;

            while (EstaVacio(Ar1_Lectura, "MezclaEquilibrada_F1.txt") == false || EstaVacio(Ar3_Lectura, "MezclaEquilibrada_F3.txt") == false) // mientras no esté vació tanto F1 como F3
            {
                if (bandera == true)
                {

                    Ar2_Lectura = new StreamReader("MezclaEquilibrada_F2.txt");
                    Ar3_Lectura = new StreamReader("MezclaEquilibrada_F3.txt");
                    Ar_Escritura = new StreamWriter("MezclaEquilibrada_F.txt");
                    Ar1_Escritura = new StreamWriter("MezclaEquilibrada_F1.txt");

                    Fusion_Particion(Ar2_Lectura, Ar3_Lectura, Ar_Escritura, Ar1_Escritura);
                    bandera = false;
                }
                else
                {

                    Ar_Lectura = new StreamReader("MezclaEquilibrada_F.txt");
                    Ar1_Lectura = new StreamReader("MezclaEquilibrada_F1.txt");
                    Ar2_Escritura = new StreamWriter("MezclaEquilibrada_F2.txt");
                    Ar3_Escritura = new StreamWriter("MezclaEquilibrada_F3.txt");

                    Fusion_Particion(Ar_Lectura, Ar1_Lectura, Ar2_Escritura, Ar3_Escritura);
                    bandera = true;
                }
            }
        }
        public static void Particion_Inicial(StreamReader Lectura_Principal, StreamWriter Auxiliar_F2, StreamWriter Auxiliar_F3)
        {
            // se abrieron los archivos para lectura y escritura 

            int auxiliar = 0, puntero = 0;
            bool bandera;

            puntero = Convert.ToInt32(Lectura_Principal.ReadLine());
            Auxiliar_F2.WriteLine(puntero);
            bandera = true;
            auxiliar = puntero;

            while (!Lectura_Principal.EndOfStream)
            {
                puntero = Convert.ToInt32(Lectura_Principal.ReadLine());

                if (puntero >= auxiliar)
                {
                    auxiliar = puntero;

                    if (bandera == true)
                    {
                        Auxiliar_F2.WriteLine(puntero);
                    }
                    else
                    {
                        Auxiliar_F3.WriteLine(puntero);
                    }
                }
                else
                {
                    auxiliar = puntero;

                    if (bandera == true)
                    {
                        Auxiliar_F3.WriteLine(puntero);
                        bandera = false;
                    }
                    else
                    {
                        Auxiliar_F2.WriteLine(puntero);
                        bandera = true;
                    }
                }
            }

            Lectura_Principal.Close();
            Auxiliar_F2.Close();
            Auxiliar_F3.Close();
        }
        public static void Fusion_Particion(StreamReader FA, StreamReader FB, StreamWriter FC, StreamWriter FD)
        {

            // se abrieron los archivos para lectura y escritura

            int auxiliar = 0, puntero_1 = 0, puntero_2 = 0;
            bool bandera_1, bandera_2, bandera_3;

            bandera_1 = true;
            bandera_2 = true;
            bandera_3 = true;

            // inicia con un valor negativo alto
            auxiliar = -32768;

            while ((!FA.EndOfStream || bandera_1 == false) && (!FB.EndOfStream || bandera_2 == false))
            {
                if (bandera_1 == true)
                {
                    puntero_1 = int.Parse(FA.ReadLine());
                    bandera_1 = false;
                }

                if (bandera_2 == true)
                {
                    puntero_2 = int.Parse(FB.ReadLine());
                    bandera_2 = false;
                }

                if (puntero_1 < puntero_2)
                {
                    if (puntero_1 >= auxiliar)
                    {
                        if (bandera_3 == true)
                        {
                            FC.WriteLine(puntero_1);
                        }
                        else
                        {
                            FD.WriteLine(puntero_1);
                        }

                        bandera_1 = true;
                        auxiliar = puntero_1;

                    }
                    else
                    {
                        if (bandera_3 == true)
                        {
                            FC.WriteLine(puntero_2);
                            bandera_3 = false;
                        }
                        else
                        {
                            FD.WriteLine(puntero_2);
                            bandera_3 = true;
                        }

                        bandera_2 = true;
                        auxiliar = -32768;
                    }
                }
                else
                {
                    if (puntero_2 >= auxiliar)
                    {
                        if (bandera_3 == true)
                        {
                            FC.WriteLine(puntero_2);
                        }
                        else
                        {
                            FD.WriteLine(puntero_2);
                        }

                        bandera_2 = true;
                        auxiliar = puntero_2;

                    }
                    else
                    {
                        if (bandera_3 == true)
                        {
                            FC.WriteLine(puntero_1);
                            bandera_3 = false;
                        }
                        else
                        {
                            FD.WriteLine(puntero_1);
                            bandera_3 = true;
                        }

                        bandera_1 = true;
                        auxiliar = -32768;
                    }
                }
            }

            if (bandera_1 == false) // paso 6
            {
                if (bandera_3 == true)
                {
                    FC.WriteLine(puntero_1);

                    while (!FA.EndOfStream)
                    {
                        puntero_1 = Convert.ToInt32(FA.ReadLine());
                        FC.WriteLine(puntero_1);
                    }
                }
                else
                {
                    FD.WriteLine(puntero_1);

                    while (!FA.EndOfStream)
                    {
                        puntero_1 = Convert.ToInt32(FA.ReadLine());
                        FD.WriteLine(puntero_1);
                    }
                }
            } // fin del paso 6

            if (bandera_2 == false) // paso 8
            {
                if (bandera_3 == true)
                {
                    FC.WriteLine(puntero_2);

                    while (!FB.EndOfStream)
                    {
                        puntero_2 = Convert.ToInt32(FB.ReadLine());
                        FC.WriteLine(puntero_2);
                    }
                }
                else
                {
                    FD.WriteLine(puntero_2);

                    while (!FB.EndOfStream)
                    {
                        puntero_2 = Convert.ToInt32(FB.ReadLine());
                        FD.WriteLine(puntero_2);
                    }
                }
            }

            FA.Close();
            FB.Close();
            FC.Close();
            FD.Close();
        }
        #endregion

    }
}
