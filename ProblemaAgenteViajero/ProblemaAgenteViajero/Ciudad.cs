
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProblemaAgenteViajero
{
    static class Constants
    {
        public const int MAXV = 100;
        public const int oo = 0x3f3f3f3f;
    }
    class Edge
    {
        public int nodei { get; set; }
        public int nodef { get; set; }// El nodo destino de la arista.
        public int cost { get; set; } // El costo de la arista.
        public Edge(int _nodei,int _node, int _cost)  { this.nodef = _node;this.cost = _cost;this.nodei = _nodei; } // Constructor parametrizado.
        public Edge() { this.nodef = -1; this.cost = -1; this.nodei = -1; } // Constructor por defecto.
    };
    class Graph
    {
        public List<Edge> List_edges= new List<Edge>(); // Lista de adyacencias.
        
        public int V  { get; set; } // Cantidad de vertices.
        public int E { get; set; } // Cantidad de aristas.
        public Graph()
        {
            this.V = 24;
            this.E = 32;
            this.List_edges.Add(new Edge(1,2,287));
            this.List_edges.Add(new Edge(2,1,287));
            this.List_edges.Add(new Edge(3,2,194));
            this.List_edges.Add(new Edge(2,3,194));
            this.List_edges.Add(new Edge(3,4,385));
            this.List_edges.Add(new Edge(4,3,385));
            this.List_edges.Add(new Edge(5, 4, 295));
            this.List_edges.Add(new Edge(4, 5, 295));
            this.List_edges.Add(new Edge(5,6,427));
            this.List_edges.Add(new Edge(6,5,427));
            this.List_edges.Add(new Edge(6,7,310));
            this.List_edges.Add(new Edge(7,6,310));
            this.List_edges.Add(new Edge(7, 8, 708));
            this.List_edges.Add(new Edge(8, 7, 708));
            this.List_edges.Add(new Edge(8,9,223));
            this.List_edges.Add(new Edge(9,8,223));
            this.List_edges.Add(new Edge(9,10,160));
            this.List_edges.Add(new Edge(10,9,160));
            this.List_edges.Add(new Edge(1,24,692));
            this.List_edges.Add(new Edge(24, 1, 692));
            this.List_edges.Add(new Edge(24,21,594));
            this.List_edges.Add(new Edge(21,24,594));
            this.List_edges.Add(new Edge(21,20,329));
            this.List_edges.Add(new Edge(20,21,329));
            this.List_edges.Add(new Edge(20, 19, 461));
            this.List_edges.Add(new Edge(19, 20, 461));
            this.List_edges.Add(new Edge(19,10,402));
            this.List_edges.Add(new Edge(10,19,402));
            this.List_edges.Add(new Edge(1,11,739));
            this.List_edges.Add(new Edge(11,1,739));
            this.List_edges.Add(new Edge(11, 23, 232));
            this.List_edges.Add(new Edge(23, 11, 232));
            this.List_edges.Add(new Edge(23,24,442));
            this.List_edges.Add(new Edge(24,23,442));
            this.List_edges.Add(new Edge(4,22,207));
            this.List_edges.Add(new Edge(22,4,207));
            this.List_edges.Add(new Edge(22, 24, 345));
            this.List_edges.Add(new Edge(24, 22, 345));
            this.List_edges.Add(new Edge(22,12,305));
            this.List_edges.Add(new Edge(12,22,305));
            this.List_edges.Add(new Edge(12,13,132));
            this.List_edges.Add(new Edge(13,12,132));
            this.List_edges.Add(new Edge(13, 14, 101));
            this.List_edges.Add(new Edge(14, 13, 101));
            this.List_edges.Add(new Edge(14,15,269));
            this.List_edges.Add(new Edge(15,14,269));
            this.List_edges.Add(new Edge(6,15,387));
            this.List_edges.Add(new Edge(15,6,387));
            this.List_edges.Add(new Edge(7,16, 312));
            this.List_edges.Add(new Edge(16, 7, 312));
            this.List_edges.Add(new Edge(16,17,157));
            this.List_edges.Add(new Edge(17,16,157));
            this.List_edges.Add(new Edge(17,18,134));
            this.List_edges.Add(new Edge(18,17,134));
            this.List_edges.Add(new Edge(21, 18, 430));
            this.List_edges.Add(new Edge(18, 21, 430));
            this.List_edges.Add(new Edge(18,20,233));
            this.List_edges.Add(new Edge(20,18,233));
            this.List_edges.Add(new Edge(17,8,311));
            this.List_edges.Add(new Edge(8,17,311));
            this.List_edges.Add(new Edge(8, 19, 310));
            this.List_edges.Add(new Edge(19, 8, 310));

        }
       
    };
    class State
    {
        public int node { get; set; }// El nodo destino de la arista.
        public int cost { get; set; } // El costo de la arista.
        public State(int _node, int _cost) { this.node = _node; this.cost = _cost; } // Constructor parametrizado.
        public State() { this.node = -1; this.cost = -1; } // Constructor por defecto.
//        public static bool operator <(State ImpliedObject, State b) // Sobrecarga del operador de prioridad <.
//=> ImpliedObject.cost > b.cost;

        //       public bool operator <(const State &b) const {
        //	return cost > b.cost;
        //}
    };

    public class city
    {
        Graph grafico = new Graph();
        
        public int Numero_city { get; set; }
        public string Departamento { get; set; }
        public int PosicionX { get; set; }//coordenada X
        public int PosicionY { get; set; }//coordenada y
        public int[] Distancias { get; set; }
        public List<int> camino = new List<int>();
        public int suma_distancias { get; set; }
        public int destino { get; set; }
        State state;
        public city()
        {
            this.Numero_city = 0;
            this.PosicionX = 0;
            this.PosicionY = 0;
            
        }
        public city(int numero_city, int posicionX, int posicionY, string departamento)
        {
          
            this.Numero_city = numero_city;
            this.PosicionX = posicionX;
            this.PosicionY = posicionY;
            this.Departamento = departamento;
            this.suma_distancias = 0;
            switch (numero_city)
            {
                case 1: ; ; break;
                case 2: ; break;
                case 3: ; break;
                case 4: ; ; break;
                case 5: ; break;
                case 6: ; ; break;
                case 7: ; ; break;
                case 8:  ; ; break;
                case 9: ; break;
                case 10: ; break;
                case 11: ; break;
                case 12: ; break;
                case 13: ; break;
                case 14: ; break;
                case 15:; ; break;
                case 16: ; break;
                case 17:; ; break;
                case 18:; ; break;
                case 19:; ; break;
                case 20: ; break;
                case 21: ; break;
                case 22:; ; break;
                case 23: ; break;
                case 24: ; break;
                default:
                    break;
            }

        }
        public void addestino(int n)
        {
            this.destino = n;
        }
        public int getdistancia()
        {
            return suma_distancias;
        }
        public int[] getcamino()
        {
            return camino.ToArray();
        }
        public int algoritmo(int begin, int end, Graph graph)
        {
            Queue<State> pq = new Queue<State>(); // La cola de prioridad.
            vector<int> Dist = new List<int>(graph.V, 0x3f3f3f3f); // La distancia hacia todos los vertices. Inicialmente para cada vertice su valor es infinito.
            List<bool> mark = new List<bool>(graph.V, false); // Este arreglo nos permitira determinar los nodos procesados.Dist

            Dist[begin] = 0; // Valor inicial del vertice de partida.
            pq.push(State(begin, 0)); // Agregamos el primer elemento, que no es mas que el vertice de partida.
            while (!pq.empty()) // Mientras existan vertices por procesar.
            {
                State st = pq.top();
                pq.pop(); // Se desencola el elemento minimo.
                mark[st.node] = true; // Se marca el nodo como visitado.
                if (st.node == end)
                {
                    return st.cost; // Retornamos el valor del camino, hemos llegado al vertice destino.
                }

                int T = (int)graph.G[st.node].size();
                for (int i = 0; i < T; ++i) // Se recorren las adyacencias de "a".
                {
                    // Si no ha sido procesado el vertice "vi" y la distancia hacia "vi" es menor a la distancia
                    // en Dist entonces hemos encontrado un camino mas corto a "vi".
                    if (!mark[graph.G[st.node][i].node] && ((Dist[st.node] + graph.G[st.node][i].cost) < Dist[graph.G[st.node][i].node]))
                    {
                        Dist[graph.G[st.node][i].node] = st.cost + graph.G[st.node][i].cost;
                        pq.push(State(graph.G[st.node][i].node, st.cost + graph.G[st.node][i].cost));
                    }
                }
            }
            return -1; // Si no se puede llegar al destino, retornar -1.
        }
     

    }

    public class Listacitys
    {
        public int[,] Matriz_adyacencia { get; set; }
        public List<city> List_citys { get; set; }      
        //Array
        public Listacitys()
        {
            if (List_citys == null)
            {
                List_citys = new List<city>();
            }
            Matriz_adyacencia = new int[List_citys.Count, List_citys.Count];
            switch (List_citys.ElementAt(0).Numero_city)
            {
                
                default:
                    break;
            }
        }
        public List<city> Obtener_citys()
        {
            return List_citys;
        }
        public void Insertar_citys(city city)
        {
            List_citys.Add(city);
        }
        public void Insert_graph(int index, city city)
        {
            List_citys.Insert(index, city);
        }
        public int Obtener_Adyacencia(int pFila, int pColumna)
        {
            return Matriz_adyacencia[pFila, pColumna];
        }
        public double Calcular_distancia(int x1, int x2, int y1, int y2)
        {                     
            int CalcularX = x2 - x1;
            int CalcularY = y2 - y1;
            double Distancia = Math.Sqrt(Math.Pow(CalcularX, 2) + Math.Pow(CalcularY, 2));
            return Distancia;            
        }
        public double Select_city(int x1, int y1,int z)
        {
            if (z == 0)
            {
                for (int i = 1; i < List_citys.Count; i++)
            {
                if ((List_citys.ElementAt(i).PosicionX+42>=x1&&x1>= List_citys.ElementAt(i).PosicionX)&&
                   (List_citys.ElementAt(i).PosicionY + 40 >= y1 && y1 >= List_citys.ElementAt(i).PosicionY) )
                {
                    z = i;
                }
                
            }

            
            return Calcular_distancia(List_citys.ElementAt(0).PosicionX, List_citys.ElementAt(z).PosicionX
                , List_citys.ElementAt(0).PosicionY, List_citys.ElementAt(z).PosicionY);

            }
            else
            {
                for (int i = 1; i < List_citys.Count; i++)
                {
                    if ((List_citys.ElementAt(i).PosicionX + 42 >= x1 && x1 >= List_citys.ElementAt(i).PosicionX) &&
                       (List_citys.ElementAt(i).PosicionY + 40 >= y1 && y1 >= List_citys.ElementAt(i).PosicionY))
                    {
                        z = i;
                    }

                }
                return z;
            }
        }
        //public string Select_city_nom(int x1, int y1, int z)
        //{

        //    for (int i = 1; i < List_citys.Count; i++)
        //    {
        //        if ((List_citys.ElementAt(i).PosicionX + 42 >= x1 && x1 >= List_citys.ElementAt(i).PosicionX) &&
        //           (List_citys.ElementAt(i).PosicionY + 40 >= y1 && y1 >= List_citys.ElementAt(i).PosicionY))
        //        {
        //            z = i;
        //        }

        //    }

        //    return List_citys.ElementAt(z).Departamento;
        //}
        public void Generar_camino(Graphics graphics)
        {
            GraphicsPath camino = new GraphicsPath();
            Pen Pen = new Pen(Color.Purple, 5);
            for (int i = 1; i < 10; i++)
            {               
              int x1, x2, y1, y2;
              x1 = List_citys.ElementAt(i-1).PosicionX ;
              y1 = List_citys.ElementAt(i-1).PosicionY;
              y2 = List_citys.ElementAt(i).PosicionY ;
              x2 = List_citys.ElementAt(i).PosicionX;

              camino.AddLine(x1, y1, x2, y2);
              graphics.DrawPath(Pen, camino);

                //Recorrer todos los nodos
                //y identificar desde el nodo inicial cual conecta con el otro nodo para hayar la distancia mas corta
            }
            camino.AddLine(List_citys.ElementAt(9).PosicionX, List_citys.ElementAt(9).PosicionY,
                List_citys.ElementAt(18).PosicionX, List_citys.ElementAt(18).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(18).PosicionX, List_citys.ElementAt(18).PosicionY,
               List_citys.ElementAt(7).PosicionX, List_citys.ElementAt(7).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(7).PosicionX, List_citys.ElementAt(7).PosicionY,
               List_citys.ElementAt(16).PosicionX, List_citys.ElementAt(16).PosicionY);
            graphics.DrawPath(Pen, camino);
      

            camino.AddLine(List_citys.ElementAt(18).PosicionX, List_citys.ElementAt(18).PosicionY,
               List_citys.ElementAt(19).PosicionX, List_citys.ElementAt(19).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(16).PosicionX, List_citys.ElementAt(16).PosicionY,
               List_citys.ElementAt(15).PosicionX, List_citys.ElementAt(15).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(6).PosicionX, List_citys.ElementAt(6).PosicionY,
               List_citys.ElementAt(15).PosicionX, List_citys.ElementAt(15).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(19).PosicionX, List_citys.ElementAt(19).PosicionY,
                List_citys.ElementAt(20).PosicionX, List_citys.ElementAt(20).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(20).PosicionX, List_citys.ElementAt(20).PosicionY,
               List_citys.ElementAt(17).PosicionX, List_citys.ElementAt(17).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(20).PosicionX, List_citys.ElementAt(20).PosicionY,
               List_citys.ElementAt(14).PosicionX, List_citys.ElementAt(14).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(14).PosicionX, List_citys.ElementAt(14).PosicionY,
               List_citys.ElementAt(13).PosicionX, List_citys.ElementAt(13).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(5).PosicionX, List_citys.ElementAt(5).PosicionY,
               List_citys.ElementAt(14).PosicionX, List_citys.ElementAt(14).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(13).PosicionX, List_citys.ElementAt(13).PosicionY,
               List_citys.ElementAt(12).PosicionX, List_citys.ElementAt(12).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(12).PosicionX, List_citys.ElementAt(12).PosicionY,
               List_citys.ElementAt(11).PosicionX, List_citys.ElementAt(11).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(11).PosicionX, List_citys.ElementAt(11).PosicionY,
               List_citys.ElementAt(21).PosicionX, List_citys.ElementAt(21).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(4).PosicionX, List_citys.ElementAt(4).PosicionY,
               List_citys.ElementAt(21).PosicionX, List_citys.ElementAt(21).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(10).PosicionX, List_citys.ElementAt(10).PosicionY,
               List_citys.ElementAt(0).PosicionX, List_citys.ElementAt(0).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(22).PosicionX, List_citys.ElementAt(22).PosicionY,
               List_citys.ElementAt(10).PosicionX, List_citys.ElementAt(10).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(22).PosicionX, List_citys.ElementAt(22).PosicionY,
             List_citys.ElementAt(23).PosicionX, List_citys.ElementAt(23).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(23).PosicionX, List_citys.ElementAt(23).PosicionY,
             List_citys.ElementAt(20).PosicionX, List_citys.ElementAt(20).PosicionY);
            graphics.DrawPath(Pen, camino);
            camino.AddLine(List_citys.ElementAt(23).PosicionX, List_citys.ElementAt(23).PosicionY,
           List_citys.ElementAt(21).PosicionX, List_citys.ElementAt(21).PosicionY);
            graphics.DrawPath(Pen, camino);
        }
        public void Camino_punto_a_punto(Graphics graphics, city Inicial, city Final)
        {
            city city = new city();

            GraphicsPath camino = new GraphicsPath();
            Pen Pen = new Pen(Color.Black, 5);                     
          
            //camino.AddLine(Inicial.PosicionX, Inicial.PosicionY, Final.PosicionX, Final.PosicionY);             
            //graphics.DrawPath(Pen, camino);

            for (int i = 1; i<List_citys.Count;i++)
            {
                city.PosicionX = List_citys.ElementAt(i).PosicionX;
                city.PosicionY = List_citys.ElementAt(i).PosicionY;
                if(Math.Sqrt(Math.Pow(Inicial.PosicionX-city.PosicionX, 2) + Math.Pow(Inicial.PosicionY-city.PosicionY, 2))>
                    Math.Sqrt(Math.Pow(Final.PosicionX - city.PosicionX, 2) + Math.Pow(Final.PosicionY - city.PosicionY, 2)))
                {
                    camino.AddLine(Inicial.PosicionX, Inicial.PosicionY, city.PosicionX, city.PosicionY);
                    graphics.DrawPath(Pen, camino);
                }
              
            }           
        }
        public void Cerrar_camino(Graphics graphics)
        {
            GraphicsPath camino = new GraphicsPath();
            Pen Pen = new Pen(Color.Purple, 5);            
            int contador = List_citys.Count()-1;
            foreach(city city in Obtener_citys())
            {                
                int x1,y1,x2, y2;
                x1 = List_citys.ElementAt(0).PosicionX;
                y1 = List_citys.ElementAt(0).PosicionY ;
                x2 = List_citys.ElementAt(contador).PosicionX;
                y2 = List_citys.ElementAt(contador).PosicionY ;
                camino.AddLine(x2, y2, x1, y1);
                graphics.DrawPath(Pen, camino);
            }
        }       
        public int Obtener_resta_cordenada_X()
        {
            int coordenadasX = 0;
            for (int i = 1; i < List_citys.Count; i++)
            {
                int x1, x2;
                x1 = List_citys.ElementAt(i - 1).PosicionX;
                x2 = List_citys.ElementAt(i).PosicionX;

                coordenadasX = x2 - x1;

            }
            return coordenadasX;
        }
        public int Obtener_resta_coordenada_Y()
        {
            int coordenadaY = 0;
            for (int i = 1; i < List_citys.Count; i++)
            {
                int y1, y2;
                y1 = List_citys.ElementAt(i - 1).PosicionY;
                y2 = List_citys.ElementAt(i).PosicionY;

                coordenadaY = y2 - y1;
            }
            return coordenadaY;
        }       
        public double Calcular_distancia()
        {
            double suma_distancias = 0;
           
            foreach (city city in Obtener_citys())
            {
                //double Distancia = Math.Sqrt(Math.Pow(CalcularX, 2) + Math.Pow(CalcularY, 2));
                double distancia = Math.Sqrt(Math.Pow(Obtener_resta_cordenada_X(), 2) + Math.Pow(Obtener_resta_coordenada_Y(), 2));
                suma_distancias += distancia;
                
            }
            return suma_distancias;
        }      
        public void Filas_Columnas()
        {            
            for(int filas=0;filas<List_citys.Count;filas++)
            {
                for(int columnas=0;columnas<List_citys.Count;columnas++)
                {
                    Matriz_adyacencia[filas,columnas] = Matriz_adyacencia[List_citys.Count,List_citys.Count];
                }
            }
        }
        public List<city> Encontrar_city_por_numero(int city)
        {
            return Obtener_citys().FindAll(x => x.Numero_city.Equals(city));
        }
        public List<city> Encontrar_city_por_nombre(string depa)
        {
            return Obtener_citys().FindAll(x => x.Departamento.Equals(depa));
        }
    }
}
