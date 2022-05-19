using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Chocolateria
{
    public class Externos
    {

        private static StreamReader leerF1, leerF2;
        private static StreamWriter escribirF1, escribirF2, escribirF3;

        public Externos(List<frmOrdenacion.Producto> lista1, List<frmOrdenacion.Producto> lista2)
        {

        }

        public void Intercalacion()
        {
            try
            {
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
    }
}
