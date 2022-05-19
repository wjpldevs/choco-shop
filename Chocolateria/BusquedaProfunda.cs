using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolateria
{
    public class BusquedaProfunda
    {
        private bool[] marcado; // ¿se ha llamado a PBP en este vértice?
        private int[] aristaPara;// último vértice el camino conocido de éste vértice
        public int source; // recurso

        public BusquedaProfunda(Grafico G, int recurso)
        {
            marcado = new bool[G.Vertices];
            aristaPara = new int[G.Vertices];
            this.source = recurso;
            PBP(G, recurso);
        }

        private void PBP(Grafico G, int vertice) // método no sobre-escrito
        {
            marcado[vertice] = true;
            foreach (int w in G.ListaAdy(vertice))
            {
                if (!marcado[w])
                {
                    aristaPara[w] = vertice;
                    PBP(G, w);
                }
            }
        }

        public bool TieneCamino(int vertice) { return marcado[vertice]; }

        public IEnumerable<int> CaminoPara(int vertice)
        {
            if (!TieneCamino(vertice)) return null;
            Stack<int> camino = new Stack<int>();

            for (int x = vertice; x != source; x = aristaPara[x])
                camino.Push(x);

            camino.Push(source);
            return camino;
        }

    }
}
