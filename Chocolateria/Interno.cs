using System;
using System.Collections.Generic;

namespace Chocolateria
{
    public class Interno
    {
        private frmOrdenacion.Producto[] array;

        /// <summary>
        /// Constructor de la clase interno
        /// </summary>
        /// <param name="arregloOrdenar"></param>
        public Interno(frmOrdenacion.Producto[] arregloOrdenar)
        {
            array = arregloOrdenar;
        }

        #region Intercambio

        public void Intercambio()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Precio > array[j].Precio)
                    {
                        var aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }

            }
        }

        #endregion 

        #region Insercion

        public void Insercion()
        {
            decimal auxiliar = 0;
            int k = 0;

            for (int i = 1; i < array.Length; i++)
            {
                auxiliar = array[i].Precio;
                k = i - 1;

                while (k >= 0 && auxiliar < array[k].Precio)
                {                  
                    array[k + 1].Precio = array[k].Precio; k--;
                }
                array[k + 1].Precio = auxiliar;
            }
        }

        #endregion

        #region Seleccion
        public void Seleccion()
        {
            int tamaño = array.Length - 1, k = 0;

            for (int i = 0; i < tamaño; i++)
            {
                decimal menor = array[i].Precio;
                k = i;

                for (int j = i + 1; j <= tamaño; j++)
                {
                    if (menor > array[j].Precio)
                    {
                        menor = array[j].Precio;
                        k = j;
                    }
                }
                array[k].Precio = array[i].Precio;
                array[i].Precio = menor;
            }
        }

        #endregion

        #region ShellSort
        public void ShellSort()
        {
            int intervalo = array.Length / 2, vueltasExternas = intervalo, vueltasInternas = array.Length - 1;

            for (int i = 0; i < vueltasExternas; i++)
            {
                for (int j = 0; intervalo + j <= vueltasInternas; j++)
                {
                    if (array[j].Precio > array[intervalo + j].Precio)
                    {
                        var aux = array[j];
                        array[j] = array[intervalo + j];
                        array[intervalo + j] = aux;
                    }
                }
                intervalo /= 2;
                if (intervalo == 0)
                    intervalo = 1;
            }
        }
        #endregion

        #region Quicksort

        public void Quicksort(int ini, int fin)
        {
            int izq = ini; int Der = fin; bool band = true;
            int pos = ini;
            frmOrdenacion.Producto aux = array[0];
            while (band == true)
            {
                band = false;
                while ((array[pos].Precio <= array[Der].Precio) && (pos != Der)) { Der--; }

                
                if (pos != Der)
                {
                    aux = array[pos];
                    array[pos] = array[Der];
                    array[Der] = aux;
                    pos = Der;

                    while (array[pos].Precio<= array[Der].Precio && (pos != izq)) { izq++; }
                    if (pos != izq)
                    {
                        band = true;
                        aux = array[pos];
                        array[pos] = array[izq];
                        array[izq] = aux;
                        pos = izq;
                    }
                }
            }

            if (pos - 1 > ini) { Quicksort(ini, pos - 1); }
            if (fin > pos + 1) { Quicksort(pos + 1, fin); }

        }
        #endregion

        #region Heapsort

        public void HeapSort()
        {
            Crear_Monticulo();
            Eliminar_Monticulo();
        }

        private void Crear_Monticulo()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int a = (i % 2 == 0) ? 2 : 1;

                if (array[i].Precio > array[Math.Abs((i - a) / 2)].Precio) // si el hijo es menor que el padre hay intercambio
                {
                    var auxiliar = array[Math.Abs((i - a) / 2)];
                    array[Math.Abs((i - a) / 2)] = array[i];
                    array[i] = auxiliar;

                    // en este punto se regresa hacía la raíz nuevamente, es decir, se repite nuevamente el proceso anterior

                    for (int j = i; j > 0; j--)
                    {
                        a = (j % 2 == 0) ? 2 : 1;

                        if (array[j].Precio > array[Math.Abs((j - a) / 2)].Precio)
                        {
                            auxiliar = array[Math.Abs((j - a) / 2)];
                            array[Math.Abs((j - a) / 2)] = array[j];
                            array[j] = auxiliar;
                        }
                    }

                }
            }

        }

        private void Eliminar_Monticulo()
        {

            for (int i = 0; i < array.Length; i++)
            {
                int j = i;

                var aux = array[array.Length - (i + 1)];
                array[array.Length - (i + 1)] = array[0];
                array[0] = aux;

                int hijoMayor = 0;
                i = 0; // 

                while (((2 * i) + 1 < array.Length - (j + 1)) && ((2 * i) + 2 <= array.Length - (j + 1)))
                {
                    if ((2 * i) + 2 == array.Length - (j + 1))
                    {
                        hijoMayor = (2 * i) + 1;
                    }
                    else
                    {
                        hijoMayor = (array[(2 * i) + 1].Precio > array[(2 * i) + 2].Precio) ? (2 * i) + 1 : (2 * i) + 2;
                    }

                    if (array[i].Precio<= array[hijoMayor].Precio)
                    {
                        var auxiliar = array[hijoMayor];
                        array[hijoMayor] = array[i];
                        array[i] = auxiliar;
                    }

                    i = hijoMayor;
                }
                i = j;
            }
        }

        #endregion

        #region Radixsort 

        public decimal[] RadixSortMejorado()
        {
            // para obtener el número de mayor longitud
            // para ordenar los precios
            int peso = 1;
            int mayor = (int)array[0].Precio;

            decimal[] ordenado = new decimal[array.Length];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].Precio > mayor)
                    mayor = (int)array[i].Precio;
            }

            while (mayor / peso > 0)
            {
                decimal[] montones = new decimal[10];

                // paso 1. rellenar los montones (contadores)
                for (int i = 0; i < array.Length; i++)
                    montones[(int)(array[i].Precio / peso) % 10]++;

                // paso 2. suma parcial
                for (int i = 1; i < montones.Length; i++)
                    montones[i] += montones[i - 1];

                // paso 3. movimiento
                for (int i = ordenado.Length - 1; i >= 0; i--)
                    ordenado[(int)(--montones[(int)(array[i].Precio / peso) % 10])] = array[i].Precio;

                // paso 4. intercambio y reinicio
                for (int i = 0; i < array.Length; i++)
                    array[i].Precio = ordenado[i];

                // paso 5. aumentar *10 el peso segundo el número mayor del arreglo
                peso *= 10;

            }

            return ordenado;
        }
        #endregion

        #region Binsort
        public List<frmOrdenacion.Producto> OrdenacionCasillero(frmOrdenacion.Producto[] arreglo, int a)
        {
            array = arreglo;
            int max = (int)arreglo[0].Precio;
            int min = (int)arreglo[0].Precio;

             for (int i = 1; i <= a; i++)
           {
               if (arreglo[i].Precio < min)
               {
                    min = (int)arreglo[i].Precio;
               }
                else if (arreglo[i].Precio > max)
                {
                    max = (int)arreglo[i].Precio;
               }

          }


           int NumeroCasillero = 10;
           int Rango = (int)(max - min) / NumeroCasillero + 1;
           List<frmOrdenacion.Producto> Resultado = new List<frmOrdenacion.Producto>();
            List<frmOrdenacion.Producto>[] Casillero = new List<frmOrdenacion.Producto>[Rango];
           for (int i = 0; i < Rango; i++)
                Casillero[i] = new List<frmOrdenacion.Producto>();

          for (int i = 0; i <= a; i++)
           {
               int AgregarCasillero = (int)((arreglo[i].Precio - 1) / NumeroCasillero);
               Casillero[AgregarCasillero].Add(arreglo[i]);
           }
            for (int i = 0; i < Rango; i++)
            {
               frmOrdenacion.Producto[] aux = OrdenarLista(Casillero[i]);
               Resultado.AddRange(aux);
            }
            return Resultado;
        }
        public frmOrdenacion.Producto[] OrdenarLista(List<frmOrdenacion.Producto> Dato)
        {
            for (int i = 0; i < Dato.Count; i++)
           {
               for (int j = 0; j < Dato.Count; j++)
                {
                    if (Dato[i].FechaVencimiento < Dato[j].FechaVencimiento)
                   {
                        frmOrdenacion.Producto aux = Dato[i];
                        Dato[i] = Dato[j];
                        Dato[j] = aux;
                    }
                }
           }
           return Dato.ToArray();
        }

        #endregion

    }
}

