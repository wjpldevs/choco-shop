using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolateria
{
    class Busqueda
    {
        frmOrdenacion.Producto[] array;

        /// <summary>
        /// Contructor de la clase buscar
        /// </summary>
        /// <param name="arregloBuscar"></param>
        public Busqueda(frmOrdenacion.Producto[] arregloBuscar)
        {
            array = arregloBuscar;
        }

        #region Secuecial

        public void BusquedaSecuencial(int longitud, decimal elementoBuscar) // Aquí se aplica el algoritmo de búsqueda desordenada
        {

            int i = 0;
            while ((i < longitud) && (array[i].Precio != elementoBuscar))
                i++;

            if (i == longitud)
                MessageBox.Show(string.Format("El producto {0} no está en la factura.", elementoBuscar), "Elemento no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(string.Format("El producto {0} se encuentra en la fila {1}", elementoBuscar, i + 1), "Elemento encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Binaria

        public void BusquedaBinaria(decimal precioBuscar)
        {
            decimal izquierda = 0, derecha = array.Length - 1, centro = (izquierda + derecha) / 2;

            while (izquierda <= derecha && precioBuscar != array[(int)centro].Precio)
            {
                if (precioBuscar > array[(int)centro].Precio) { izquierda = centro + 1; }
                else { derecha = centro - 1; }

                centro = (izquierda + derecha) / 2;
            }

            if (izquierda > derecha) { MessageBox.Show(string.Format("El precio {0} no se encontrró", precioBuscar), "Precio no encontrado"); }
            else
            {
                MessageBox.Show(string.Format("El precio se encontró el posición {0}.\nNombre: {1}\nCodigo: {2}\nCantidad: {3}\nFecha de vencimiento: {4}\nPrecio: {5}\nTipo de producto: {6}",
                centro + 1,
                array[(int)centro].Nombre,
                array[(int)centro].Codigo,
                array[(int)centro].Cantidad,
                array[(int)centro].FechaVencimiento,
                array[(int)centro].Precio,
                array[(int)centro].TipoProducto,
                "Precio encontrado"));
            }
        }

        #endregion

        
    }
}
