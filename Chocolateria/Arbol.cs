using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolateria
{
    class Arbol
    {
        public Producto raiz = null, auxc = null;
        public frmArboles fpadre;
        public bool cambio = false, eliminado = false;

        public Arbol(frmArboles form)
        {
            fpadre = form;
            raiz = null;
            auxc = null;
            cambio = false;
            eliminado = false;
        }

        public void Insercion(Producto RO, object[] datos)
        {
            if (RO != null)
            {
                if (int.Parse(datos[0].ToString()) < RO.Codigo)
                {
                    if (RO.Izq == null)
                    {
                        Producto nod = new Producto();
                        nod.Codigo = int.Parse(datos[0].ToString());
                        nod.Nombre = datos[1].ToString();
                        nod.Cantidad = int.Parse(datos[2].ToString());
                        nod.FechaVencimiento = datos[3].ToString();
                        nod.Precio = decimal.Parse(datos[4].ToString());
                        nod.TipoProducto = datos[5].ToString();
                        RO.Izq = nod;
                    }
                    else
                        Insercion(RO.Izq, datos);
                }
                else if (int.Parse(datos[0].ToString()) > RO.Codigo)
                {
                    if (RO.Der == null)
                    {
                        Producto nod = new Producto();
                        nod.Codigo = int.Parse(datos[0].ToString());
                        nod.Nombre = datos[1].ToString();
                        nod.Cantidad = int.Parse(datos[2].ToString());
                        nod.FechaVencimiento = datos[3].ToString();
                        nod.Precio = decimal.Parse(datos[4].ToString());
                        nod.TipoProducto = datos[5].ToString();
                        RO.Der = nod;
                    }
                    else
                        Insercion(RO.Der, datos);
                }
                else
                {
                    fpadre.ErrorNodoExiste();
                }
            }
            else
            {
                Producto nod = new Producto();
                nod.Codigo = int.Parse(datos[0].ToString());
                nod.Nombre = datos[1].ToString();
                nod.Cantidad = int.Parse(datos[2].ToString());
                nod.FechaVencimiento = datos[3].ToString();
                nod.Precio = decimal.Parse(datos[4].ToString());
                nod.TipoProducto = datos[5].ToString();
                RO = nod;
                if (raiz == null)
                    raiz = RO;
            }
        }

        public void Eliminacion(Producto RO, int cod)
        {
            Producto aux, aux1 = null, otro;
            bool bo;

            if (RO != null)
            {
                if (cod < RO.Codigo)
                {
                    Eliminacion(RO.Izq, cod);
                    if (cambio)
                    {
                        RO.Izq = auxc;
                        cambio = false;
                    }
                }
                else if (cod > RO.Codigo)
                {
                    Eliminacion(RO.Der, cod);
                    if (cambio)
                    {
                        RO.Der = auxc;
                        cambio = false;
                    }
                }
                else
                {
                    otro = RO;

                    if (otro.Der == null)
                    {
                        if (raiz != RO)
                            RO = otro.Izq;
                        else
                            raiz = RO = otro.Izq;
                    }
                    else if (otro.Izq == null)
                    {
                        if (raiz != RO)
                            RO = otro.Der;
                        else
                            raiz = RO = otro.Der;
                    }
                    else
                    {
                        aux = RO.Izq;
                        bo = false;

                        while (aux.Der != null)
                        {
                            aux1 = aux;
                            aux = aux.Der;
                            bo = true;
                        }

                        bool esraiz = false;
                        if (raiz == RO)
                            esraiz = true;
                        RO.Codigo = aux.Codigo;
                        RO.Nombre = aux.Nombre;
                        RO.Cantidad = aux.Cantidad;
                        RO.FechaVencimiento = aux.FechaVencimiento;
                        RO.Precio = aux.Precio;
                        RO.TipoProducto = aux.TipoProducto;
                        otro = aux;
                        if (esraiz)
                            raiz = RO;

                        if (bo == true)
                            aux1.Der = aux.Izq;
                        else
                            RO.Izq = aux.Izq;
                    }
                    cambio = true;
                    otro = null;
                    auxc = RO;
                    eliminado = true;
                }
            }
            else if (raiz != RO)
            {
                fpadre.ErrorNodoNoExiste();
                eliminado = false;
            }
        }

        public void Preorden(Producto RO)
        {
            if (RO != null)
            {
                fpadre.Escribir(RO);
                Preorden(RO.Izq);
                Preorden(RO.Der);
            }
        }

        public void InOrden(Producto RO)
        {
            if (RO != null)
            {
                InOrden(RO.Izq);
                fpadre.Escribir(RO);
                InOrden(RO.Der);
            }
        }

        public void Postorden(Producto RO)
        {
            if (RO != null)
            {
                Postorden(RO.Izq);
                Postorden(RO.Der);
                fpadre.Escribir(RO);
            }
        }

        public void InsertarBalanceado(Producto RO, object[] datos)
        {
            if (RO != null)
            {
                if (int.Parse(datos[0].ToString()) < RO.Codigo)
                {
                    if (RO.Izq == null)
                    {
                        Producto nod = new Producto();
                        nod.Codigo = int.Parse(datos[0].ToString());
                        nod.Nombre = datos[1].ToString();
                        nod.Cantidad = int.Parse(datos[2].ToString());
                        nod.FechaVencimiento = datos[3].ToString();
                        nod.Precio = decimal.Parse(datos[4].ToString());
                        nod.TipoProducto = datos[5].ToString();
                        RO.Izq = nod;
                        nod.Pad = RO;
                        BalanceFE(nod.Pad, -1);
                        cambio = true;
                    }
                    else
                        InsertarBalanceado(RO.Izq, datos);
                }
                else if (int.Parse(datos[0].ToString()) > RO.Codigo)
                {
                    if (RO.Der == null)
                    {
                        Producto nod = new Producto();
                        nod.Codigo = int.Parse(datos[0].ToString());
                        nod.Nombre = datos[1].ToString();
                        nod.Cantidad = int.Parse(datos[2].ToString());
                        nod.FechaVencimiento = datos[3].ToString();
                        nod.Precio = decimal.Parse(datos[4].ToString());
                        nod.TipoProducto = datos[5].ToString();
                        RO.Der = nod;
                        nod.Pad = RO;
                        BalanceFE(nod.Pad, 1);
                        cambio = true;
                    }
                    else
                        InsertarBalanceado(RO.Der, datos);
                }
                else
                    fpadre.ErrorNodoExiste();
            }
            else
            {
                Producto nod = new Producto();
                nod.Codigo = int.Parse(datos[0].ToString());
                nod.Nombre = datos[1].ToString();
                nod.Cantidad = int.Parse(datos[2].ToString());
                nod.FechaVencimiento = datos[3].ToString();
                nod.Precio = decimal.Parse(datos[4].ToString());
                nod.TipoProducto = datos[5].ToString();
                RO = nod;
                if (raiz == null)
                    raiz = RO;
            }
        }

        public void BalanceFE(Producto nodo, int incremento)
        {
            int tipo = -1;
            while (nodo != null)
            {
                nodo.FE += incremento;
                if (nodo.FE == 0)
                {
                    break;
                }
                tipo = tipoRotacion(nodo);
                if (tipo == 0)
                {
                    if (nodo.Pad != null)
                    {
                        if (nodo.Codigo < nodo.Pad.Codigo)
                        {
                            incremento = -1;
                        }
                        else
                        {
                            incremento = 1;
                        }
                    }
                    nodo = nodo.Pad;
                }
                if (tipo == 1)
                {
                    rotacionSI(nodo, nodo.Der);
                    break;
                }
                if (tipo == 2)
                {
                    rotacionSD(nodo.Der, nodo.Der.Izq);
                    rotacionSI(nodo, nodo.Der);
                    break;
                }
                if (tipo == 3)
                {
                    rotacionSD(nodo, nodo.Izq);

                    break;
                }
                if (tipo == 4)
                {
                    rotacionSI(nodo.Izq, nodo.Izq.Der);
                    rotacionSD(nodo, nodo.Izq);

                    break;
                }
            }
        }

        public int tipoRotacion(Producto pr)
        {
            if (pr.FE == 2)
            {
                if ((pr.Der.FE == 0) || (pr.Der.FE == 1))
                    return 1;
                if (pr.Der.FE == -1)
                    return 2;
            }
            else if (pr.FE == -2)
            {
                if ((pr.Izq.FE == 0) || (pr.Izq.FE == -1))
                    return 3;
                if (pr.Izq.FE == 1)
                    return 4;
            }
            return 0;
        }

        public void rotacionSI(Producto pr, Producto hijo_der)
        {
            this.auxc = hijo_der.Izq;
            if (pr == this.raiz)
            {
                this.raiz = hijo_der;
                hijo_der.Pad = null;
            }
            else
            {
                if (pr.Codigo > pr.Pad.Codigo)
                {
                    pr.Pad.Der = hijo_der;
                }
                else
                {
                    pr.Pad.Izq = hijo_der;
                }
                hijo_der.Pad = pr.Pad;
            }
            hijo_der.Izq = pr;
            pr.Der = this.auxc;
            pr.Pad = hijo_der;
            if (this.auxc != null)
            {
                this.auxc.Pad = pr;
            }
            int w = pr.FE;
            pr.FE = (w - 1 - Math.Max(hijo_der.FE, 0));
            int balt = Math.Min(w - 2, w + hijo_der.FE - 2);
            hijo_der.FE = Math.Min(balt, hijo_der.FE - 1);
        }

        public void rotacionSD(Producto pr, Producto hijo_izq)
        {
            this.auxc = hijo_izq.Der;
            if (pr == this.raiz)
            {
                this.raiz = hijo_izq;
                hijo_izq.Pad = null;
            }
            else if (pr.Codigo > pr.Pad.Codigo)
            {
                pr.Pad.Der = hijo_izq;
            }
            else
            {
                pr.Pad.Izq = hijo_izq;
            }

            hijo_izq.Pad = pr.Pad;
            hijo_izq.Der = pr;
            pr.Izq = this.auxc;
            pr.Pad = hijo_izq;
            if (this.auxc != null)
            {
                this.auxc.Pad = pr;
            }
            int w = pr.FE;

            pr.FE = (w + 1 - Math.Min(hijo_izq.FE, 0));
            int balt = Math.Min(w + 2, w - hijo_izq.FE + 2);
            hijo_izq.FE = Math.Max(balt, hijo_izq.FE + 1);
        }

        public void ReestructuraIzq(Producto RO, bool BO)
        {
            Producto nodo1, nodo2;

            if (BO)
            {
                if (RO.FE == -1)
                {
                    RO.FE = 0;
                }
                else if (RO.FE == 0)
                {
                    RO.FE = 1;
                    BO = false;
                }
                else if (RO.FE == 1)
                {
                    nodo1 = RO.Der;
                    if (nodo1 != null)
                    {
                        if (nodo1.FE >= 0)
                        {
                            bool esraiz = false;
                            if (raiz == RO)
                                esraiz = true;
                            RO.Der = nodo1.Izq;
                            nodo1.Izq = RO;

                            if (nodo1.FE == 0)
                            {
                                RO.FE = 1;
                                nodo1.FE = -1;
                                BO = false;
                            }
                            else if (nodo1.FE == 1)
                            {
                                RO.FE = 0;
                                nodo1.FE = 0;
                            }
                            RO = nodo1;
                            if (esraiz)
                                raiz = RO;
                        }
                        else
                        {
                            bool esraiz = false;
                            if (raiz == RO)
                                esraiz = true;
                            nodo2 = nodo1.Izq;
                            RO.Der = nodo2.Izq;
                            nodo2.Izq = RO;
                            nodo1.Izq = nodo2.Der;
                            nodo2.Der = nodo1;
                            if (nodo2.FE == 1)
                                RO.FE = -1;
                            else
                                RO.FE = 0;
                            if (nodo2.FE == -1)
                                nodo1.FE = 1;
                            else
                                nodo1.FE = 0;
                            RO = nodo2;
                            nodo2.FE = 0;
                            if (esraiz)
                                raiz = RO;
                        }
                    }
                    else if (RO.Izq != null)
                        RO.FE = 1;
                    else
                        RO.FE = 0;
                }
            }
        }

        public void ReestructuraDer(Producto RO, bool BO)
        {
            Producto nodo1, nodo2;

            if (BO)
            {
                if (RO.FE == 1)
                {
                    RO.FE = 0;
                }
                else if (RO.FE == 0)
                {
                    RO.FE = -1;
                    BO = false;
                }
                else if (RO.FE == -1)
                {
                    nodo1 = RO.Izq;
                    if (nodo1 == null)
                    {
                        if (nodo1.FE <= 0)
                        {
                            bool esraiz = false;
                            if (raiz == RO)
                                esraiz = true;
                            RO.Izq = nodo1.Der;
                            nodo1.Der = RO;

                            if (nodo1.FE == 0)
                            {
                                RO.FE = -1;
                                nodo1.FE = 1;
                                BO = false;
                            }
                            else if (nodo1.FE == -1)
                            {
                                RO.FE = 0;
                                nodo1.FE = 0;
                            }
                            RO = nodo1;
                            if (esraiz)
                                raiz = RO;
                        }
                        else
                        {
                            bool esraiz = false;
                            if (raiz == RO)
                                esraiz = true;
                            nodo2 = nodo1.Der;
                            RO.Izq = nodo2.Der;
                            nodo2.Der = RO;
                            nodo1.Der = nodo2.Izq;
                            nodo2.Izq = nodo1;
                            if (nodo2.FE == -1)
                                RO.FE = 1;
                            else
                                RO.FE = 0;
                            if (nodo2.FE == 1)
                                nodo1.FE = -1;
                            else
                                nodo1.FE = 0;
                            RO = nodo2;
                            nodo2.FE = 0;
                            if (esraiz)
                                raiz = RO;
                        }
                    }
                    else if (RO.Der != null)
                        RO.FE = 1;
                    else
                        RO.FE = 0;
                }
            }
        }

        public void EliminarElemento(int cod)
        {
            if (this.raiz != null)
            {
                this.auxc = this.raiz;
                if (this.auxc.Codigo == cod)
                {
                    this.raiz = repla(this.raiz);
                    if (raiz.Der == null && raiz.Izq != null)
                        ReestructuraDer(raiz, true);
                    eliminado = true;
                }
                else
                {
                    Producto par = this.raiz;
                    bool foun = false;
                    Producto actual;

                    if (cod < this.auxc.Codigo)
                        actual = this.raiz.Izq;
                    else
                        actual = this.raiz.Der;
                    bool nivel = false;


                    while ((actual != null) && (!foun))
                    {
                        if (cod == actual.Codigo)
                        {
                            foun = true;
                            eliminado = true;

                            if (actual == par.Izq)
                            {
                                par.Izq = repla(actual);
                                ReestructuraIzq(par, foun);
                                if (par.Izq == null && par.Der == null)
                                    nivel = true;
                                else
                                    nivel = false;
                                Producto aux;
                                while (nivel && par.Pad != null)
                                {
                                    aux = par.Pad;
                                    if (par == aux.Izq)
                                    {
                                        if (aux.FE == -1)
                                        {
                                            aux.FE = 0;
                                            par = aux;
                                        }
                                        else if (aux.FE == 0)
                                        {
                                            aux.FE = 1;
                                            par = aux;
                                        }
                                        else if (aux.FE == 1)
                                        {
                                            ReestructuraIzq(par, foun);
                                            par = aux;
                                        }
                                    }
                                    else if (par == aux.Der)
                                    {
                                        if (aux.FE == 1)
                                        {
                                            aux.FE = 0;
                                            par = aux;
                                        }
                                        else if (aux.FE == 0)
                                        {
                                            aux.FE = 1;
                                            par = aux;
                                        }
                                        else if (aux.FE == -1)
                                        {
                                            ReestructuraDer(par, foun);
                                            par = aux;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                par.Der = repla(actual);
                                ReestructuraDer(par, foun);
                                if (par.Izq == null && par.Der == null)
                                    nivel = true;
                                else
                                    nivel = false;
                                Producto aux;
                                while (nivel && par.Pad != null)
                                {
                                    aux = par.Pad;
                                    if (par == aux.Izq)
                                    {
                                        if (aux.FE == -1)
                                        {
                                            aux.FE = 0;
                                            par = aux;
                                        }
                                        else if (aux.FE == 0)
                                        {
                                            aux.FE = 1;
                                            par = aux;
                                        }
                                        else if (aux.FE == 1)
                                        {
                                            ReestructuraIzq(par, foun);
                                            par = aux;
                                        }
                                    }
                                    else if (par == aux.Der)
                                    {
                                        if (aux.FE == 1)
                                        {
                                            aux.FE = 0;
                                            par = aux;
                                        }
                                        else if (aux.FE == 0)
                                        {
                                            aux.FE = 1;
                                            par = aux;
                                        }
                                        else if (aux.FE == -1)
                                        {
                                            ReestructuraDer(par, foun);
                                            par = aux;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            par = actual;
                            if (cod < actual.Codigo)
                                actual = actual.Izq;
                            else
                            {
                                actual = actual.Der;
                            }
                        }
                    }

                    if (!foun)
                    {
                        fpadre.ErrorNodoNoExiste();
                        eliminado = false;
                    }
                }
            }
        }

        public Producto repla(Producto nu)
        {
            Producto result = null;
            if ((nu.Izq == null) && (nu.Der == null))
            {
                result = null;
            }
            else if ((nu.Izq != null) && (nu.Der == null))
            {
                result = nu.Izq;
            }
            else if ((nu.Izq == null) && (nu.Der != null))
            {
                result = nu.Der;
            }
            else
            {
                Producto actual = nu.Der;
                Producto pa = nu;
                while (actual.Izq != null)
                {
                    pa = actual;
                    actual = actual.Izq;
                }
                if (nu.Der == actual)
                {
                    actual.Izq = nu.Izq;
                }
                else
                {
                    pa.Izq = actual.Der;
                    actual.Der = nu.Der;
                    actual.Izq = nu.Izq;
                }
                result = actual;
            }
            return result;
        }
    }
}
