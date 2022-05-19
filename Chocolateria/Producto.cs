using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolateria
{
    public class Producto
    {
        public Producto()
        {
            FE = 0;
            Izq = null;
            Der = null;
            Pad = null;
        }

        public string Nombre, TipoProducto, FechaVencimiento;
        public int Cantidad, Codigo, FE = 0;
        public decimal Precio;
        public Producto Izq;
        public Producto Pad;
        public Producto Der;
    }
}
