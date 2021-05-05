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
   
    public class Grafo
    {
        public int Numero_grafo { get; set; }
        public string Departamento { get; set; }
        public int PosicionX { get; set; }//coordenada X
        public int PosicionY { get; set; }//coordenada y
        
        public Grafo()
        {
            this.Numero_grafo = 0;
            this.PosicionX = 0;
            this.PosicionY = 0;
        }
        public Grafo(int numero_grafo,int posicionX,int posicionY,string departamento)
        {
            this.Numero_grafo = numero_grafo;
            this.PosicionX = posicionX;
            this.PosicionY = posicionY;
            this.Departamento = departamento;
        }      
        public void Dibujar_grafo(Graphics graphics,Brush solid,Size size, Grafo grafo)
        {
            if (this.PosicionX < size.Width && this.PosicionY < size.Height)
            {                
                graphics.FillEllipse(solid, grafo.PosicionX-9, grafo.PosicionY-5, 30, 30);                                           
            }            
        }
    }
    public class ListaGrafos
    {
        public int[,] Matriz_adyacencia { get; set; }
        public List<Grafo> List_grafos { get; set; }      
        //Array
        public ListaGrafos()
        {
            if (List_grafos == null)
            {
                List_grafos = new List<Grafo>();
            }
            Matriz_adyacencia = new int[List_grafos.Count, List_grafos.Count];
        }
        public List<Grafo> Obtener_grafos()
        {
            return List_grafos;
        }
        public void Insertar_grafos(Grafo grafo)
        {
            List_grafos.Add(grafo);
        }
        public void Insert_graph(int index, Grafo grafo)
        {
            List_grafos.Insert(index, grafo);
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
        public double Select_grafo(int x1, int y1,int z)
        {
           
            for (int i = 1; i < List_grafos.Count; i++)
            {
                if ((List_grafos.ElementAt(i).PosicionX+40>=x1&&x1>= List_grafos.ElementAt(i).PosicionX)&&
                   (List_grafos.ElementAt(i).PosicionY + 40 >= y1 && y1 >= List_grafos.ElementAt(i).PosicionY) )
                {
                    z = i;
                }
                
            }

            return Calcular_distancia(List_grafos.ElementAt(0).PosicionX, List_grafos.ElementAt(z).PosicionX
                , List_grafos.ElementAt(0).PosicionY, List_grafos.ElementAt(z).PosicionY);
        }

        public void Generar_camino(Graphics graphics)
        {
            GraphicsPath camino = new GraphicsPath();
            Pen Pen = new Pen(Color.Black, 5);
            for (int i = 1; i < List_grafos.Count; i++)
            {               
              int x1, x2, y1, y2;
              x1 = List_grafos.ElementAt(i-1).PosicionX ;
              y1 = List_grafos.ElementAt(i-1).PosicionY;
              y2 = List_grafos.ElementAt(i).PosicionY ;
              x2 = List_grafos.ElementAt(i).PosicionX;

              camino.AddLine(x1, y1, x2, y2);
              graphics.DrawPath(Pen, camino);

                //Recorrer todos los nodos
                //y identificar desde el nodo inicial cual conecta con el otro nodo para hayar la distancia mas corta
            }
        }
        public void Camino_punto_a_punto(Graphics graphics, Grafo Inicial, Grafo Final)
        {
            Grafo grafo = new Grafo();

            GraphicsPath camino = new GraphicsPath();
            Pen Pen = new Pen(Color.Black, 5);                     
          
            //camino.AddLine(Inicial.PosicionX, Inicial.PosicionY, Final.PosicionX, Final.PosicionY);             
            //graphics.DrawPath(Pen, camino);

            for (int i = 1; i<List_grafos.Count;i++)
            {
                grafo.PosicionX = List_grafos.ElementAt(i).PosicionX;
                grafo.PosicionY = List_grafos.ElementAt(i).PosicionY;
                if(Math.Sqrt(Math.Pow(Inicial.PosicionX-grafo.PosicionX, 2) + Math.Pow(Inicial.PosicionY-grafo.PosicionY, 2))>
                    Math.Sqrt(Math.Pow(Final.PosicionX - grafo.PosicionX, 2) + Math.Pow(Final.PosicionY - grafo.PosicionY, 2)))
                {
                    camino.AddLine(Inicial.PosicionX, Inicial.PosicionY, grafo.PosicionX, grafo.PosicionY);
                    graphics.DrawPath(Pen, camino);
                }
              
            }           
        }
        public void Cerrar_camino(Graphics graphics)
        {
            GraphicsPath camino = new GraphicsPath();
            Pen Pen = new Pen(Color.Black, 5);            
            int contador = List_grafos.Count()-1;
            foreach(Grafo Grafo in Obtener_grafos())
            {                
                int x1,y1,x2, y2;
                x1 = List_grafos.ElementAt(0).PosicionX;
                y1 = List_grafos.ElementAt(0).PosicionY ;
                x2 = List_grafos.ElementAt(contador).PosicionX;
                y2 = List_grafos.ElementAt(contador).PosicionY ;
                camino.AddLine(x2, y2, x1, y1);
                graphics.DrawPath(Pen, camino);
            }
        }       
        public int Obtener_resta_cordenada_X()
        {
            int coordenadasX = 0;
            for (int i = 1; i < List_grafos.Count; i++)
            {
                int x1, x2;
                x1 = List_grafos.ElementAt(i - 1).PosicionX;
                x2 = List_grafos.ElementAt(i).PosicionX;

                coordenadasX = x2 - x1;

            }
            return coordenadasX;
        }
        public int Obtener_resta_coordenada_Y()
        {
            int coordenadaY = 0;
            for (int i = 1; i < List_grafos.Count; i++)
            {
                int y1, y2;
                y1 = List_grafos.ElementAt(i - 1).PosicionY;
                y2 = List_grafos.ElementAt(i).PosicionY;

                coordenadaY = y2 - y1;
            }
            return coordenadaY;
        }       
        public double Calcular_distancia()
        {
            double suma_distancias = 0;
           
            foreach (Grafo grafo in Obtener_grafos())
            {
                //double Distancia = Math.Sqrt(Math.Pow(CalcularX, 2) + Math.Pow(CalcularY, 2));
                double distancia = Math.Sqrt(Math.Pow(Obtener_resta_cordenada_X(), 2) + Math.Pow(Obtener_resta_coordenada_Y(), 2));
                suma_distancias += distancia;
                
            }
            return suma_distancias;
        }      
        public void Filas_Columnas()
        {            
            for(int filas=0;filas<List_grafos.Count;filas++)
            {
                for(int columnas=0;columnas<List_grafos.Count;columnas++)
                {
                    Matriz_adyacencia[filas,columnas] = Matriz_adyacencia[List_grafos.Count,List_grafos.Count];
                }
            }
        }
        public List<Grafo> Encontrar_grafo_por_numero(int grafo)
        {
            return Obtener_grafos().FindAll(x => x.Numero_grafo.Equals(grafo));
        }
        public List<Grafo> Encontrar_grafo_por_nombre(string depa)
        {
            return Obtener_grafos().FindAll(x => x.Departamento.Equals(depa));
        }
    }
}
