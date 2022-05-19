using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chocolateria
{
    /// <summary>
    /// Clase Grafico. Simula a un grafo las propiedades y el comportamiento de un grafo no dirigido o bididireccional
    /// </summary>
    public class Grafico
    {
        #region Campos
        private int vertices, aristas;
        public bool agregarV;

        private List<List<int>> adyacencia;

        #endregion

        #region Constructores
        /// <summary>
        /// Crea un nuevo grafo con un determinado número de vértices
        /// </summary>
        /// <param name="vertices"></param>
        public Grafico(int vertices)
        {
            Vertices = vertices;
            Aristas = 0;

            ListaAdyacencia = new List<List<int>>();

            for (int i = 0; i < vertices; i++)
                ListaAdyacencia.Add(new List<int>());
                
        }

        /// <summary>
        /// Crea un nuevo grafo con un determinado número de vértices y aristas
        /// </summary>
        /// <param name="vertices"></param>
        /// <param name="aristas"></param>
        public Grafico(int vertices, int aristas) : this(vertices)
        {
            Vertices = vertices;
            int aris = aristas;

            
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Write("\n\nDATOS DE GRAFO:\n\n");
            //Console.ForegroundColor = ConsoleColor.Cyan;

            //for (int i = 0; i < aris; i++)
            //{
            //    Console.Write("{0:D2}.           conectado con           ", i + 1);

            //    Console.SetCursorPosition(7, i + 6);
            //    int vertice1 = int.Parse(Console.ReadLine());

            //    Console.SetCursorPosition(33, i + 6);
            //    int vertice2 = int.Parse(Console.ReadLine());

            //    AgregarArista(vertice1, vertice2);
            //}
            
        }

        #endregion

        #region Metodos y propiedades
        /// <summary>
        /// Agrega una nueva arista al grafo, a partir dos vértices de referencia
        /// </summary>
        /// <param name="vertice1"></param>
        /// <param name="vertice2"></param>
        public void AgregarArista(int vertice1, int vertice2)
        {
            // esto se el los grafos no digiridos, que en realidad son lo bidireccionales

            if (ListaAdyacencia[vertice1] != null && ListaAdyacencia[vertice2] != null)
            {
                ListaAdyacencia[vertice1].Add(vertice2);
                ListaAdyacencia[vertice2].Add(vertice1);
                Aristas++;
            }
            else
            {
                MessageBox.Show(string.Format("No existen los vértices {0} y {1}.\nPor tal razón, no se puede agregar una nueva arista", vertice1, vertice2), "Agregar nueva arista", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Console.Write("No existen los vértices {0} y {1}.\nPor tal razón, no se puede agregar una nueva arista.", vertice1, vertice2);
            }
        }

        public void EliminarArista(int vertice1, int vertice2)
        {
            List<int> listaV1 = ListaAdyacencia[vertice1];

            if (listaV1.Contains(vertice2))
                ListaAdyacencia[vertice1].Remove(vertice2);

            List<int> listaV2 = ListaAdyacencia[vertice2];

            if (listaV2.Contains(vertice1))
                ListaAdyacencia[vertice2].Remove(vertice1);

            Aristas--;
        }

        public void AgregarVertice(int vertice)
        {
            try
            {
                //agregarVertice.Add(new int());
                ListaAdyacencia.Insert(vertice, new List<int>());
                //agregarVertice = new List<int>();
                Vertices++;
                agregarV = true;
                MessageBox.Show("Vertice insertado");
            }
            catch 
            {
                MessageBox.Show("Agregar las mesas como tipo pila.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                agregarV = false;
            }

        }

        public void EliminarVertice(int vertice)
        {
            if (ListaAdyacencia[vertice] != null)
            {
                Aristas -= ListaAdyacencia[vertice].Count; // determina la cantidad de aristas a eliminar
                Vertices--; // se disminuye en 1 la cantidad de vértices

                int[] arreglo = ListaAdyacencia[vertice].ToArray();

                for (int i = 0; i < arreglo.Length; i++) // Elimina las aristas del vértice
                    ListaAdyacencia[vertice].Remove(arreglo[i]);

                //for (int i = vertice; i < ListaAdyacencia.Length - 1; i++) // Elimina el vértice especificado
                //    ListaAdyacencia[i] = ListaAdyacencia[i + 1];

                ListaAdyacencia.RemoveAt(vertice); // elimina el vértice

            }
            else
            {
                MessageBox.Show(string.Format("El vértice {0} ya ha sido eliminado.\nPor favor intente con otro.", vertice), "Avivso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        /// <summary>
        /// Obtiene y establece el arreglo de la lista de adyacencia que contiene los vértices del grafo
        /// </summary>
        public List<List<int>> ListaAdyacencia
        {
            get { return adyacencia; }
            set { adyacencia = value; }
        }

        /// <summary>
        /// Obtiene y establece la cantidad de vértices del grafo
        /// </summary>
        public int Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }

        /// <summary>
        ///  Obtiene y establece la cantidad de aristas del grafo
        /// </summary>
        public int Aristas
        {
            get { return aristas; }
            set { aristas = value; }
        }

        /// <summary>
        /// Obtiene la colección del arreglo de lista de adyacencia, apartir de la interfaz IEnumerable
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public IEnumerable<int> ListaAdy(int v)
        {
            return adyacencia[v];
        }

        /// <summary>
        /// Muestra la información sobre el grafo actual
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = Vertices + " mesas, " + Aristas + " rutas.\n\n";
            for (int i = 0; i < Vertices; i++)
            {
                s += string.Format("Mesa {0}: ", i + 1);
                foreach (int j in ListaAdyacencia[i])
                    s += (j + 1)+ " ";
                s += "\n";
            }
            return s;
        }
        #endregion

    }
}
