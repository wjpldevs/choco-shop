using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolateria
{
    public class BusquedaAmplia
    {
        private bool[] marcado;
        private int[] aristaPara;
        public int verticeRecurso;

        public BusquedaAmplia(Grafico G, int s)
        {
            marcado = new bool[G.Vertices];
            aristaPara = new int[G.Vertices];
            this.verticeRecurso = s;
            BA(G, s);
        }

        public void BA(Grafico G, int s)
        {
            Queue<int> cola = new Queue<int>();
            marcado[s] = true; // recurso marcado
            cola.Enqueue(s); // y lo pone en la cola 

            while(cola.Count != 0)
            {
                int v = cola.Dequeue();
                foreach (int w in G.ListaAdy(v))
                {
                    if (!marcado[w])
                    {
                        aristaPara[w] = v; // guardar la última arista en un camino más corto,
                        marcado[w] = true; // marcarlo, ya que el camino se sabe, 
                        cola.Enqueue(w); // y agregarlo a la cola
                    }
                }
            }

        }

        public bool TieneCamino(int vertice) { return marcado[vertice]; }

        public IEnumerable<int> CaminoPara(int vertice)
        {
            if (!TieneCamino(vertice)) return null;
            Stack<int> camino = new Stack<int>();

            for (int x = vertice; x != verticeRecurso; x = aristaPara[x])
                camino.Push(x);

            camino.Push(verticeRecurso);
            return camino;
        }

    }
}
