using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemaAgenteViajero
{
    public class Grafo
    {
        public int Numero_grafo { get; set; }
        public int PosicionX { get; set; }//coordenada X
        public int PosicionY { get; set; }//coordenada y

        //public int Arista { get; set; }
        public Grafo()
        {
            this.Numero_grafo = 0;
            this.PosicionX = 0;
            this.PosicionY = 0;
        }
       
        public void Dibujar_grafo(Graphics graphics,Brush solid,Size size, Grafo grafo)
        {
            if (this.PosicionX < size.Width && this.PosicionY < size.Height)
            {
                //Random Numeros_aleatorios = new Random();
                graphics.FillEllipse(solid, grafo.PosicionX, grafo.PosicionY, 40, 40);
                graphics.Dispose();                
                //this.PosicionX = Numeros_aleatorios.Next(0, size.Width);
                //this.PosicionY = Numeros_aleatorios.Next(0, size.Height);  
            }
            
        }
    }
    public class ListaGrafos
    {
        public List<int> Matriz_adyacencia { get; set; }
        public List<Grafo> List_grafos { get; set; }
        //Array
        public ListaGrafos()
        {
            if (List_grafos == null)
            {
                List_grafos = new List<Grafo>();
            }
            if(Matriz_adyacencia == null)
            {
                Matriz_adyacencia = new List<int>();
            }
        }
        public List<Grafo> Obtener_grafos()
        {
            return List_grafos;
        }
        public void Insertar_grafos(Grafo grafo)
        {
            List_grafos.Add(grafo);
        }
        public double Calcular_distancia(int x1,int x2,int y1, int y2)
        {
            //ouble raiz = 0;          
            int CalcularX = x2 - x1;
            int CalcularY = y2 - y1;
            double Distancia = Math.Sqrt(Math.Pow(CalcularX,2)+Math.Pow(CalcularY,2));

            return Distancia;
           // int distancia = 0;
            //Adiciona la arista de 2 nodos
            //for(int distancia =0; distancia<List_grafos.Count;distancia++)
            //{
                
            //}
        }
        public void Mostrar_tabla(int[,] Tabla)
        {
            for (int n = 0; n<Tabla.GetLength(0); n++)
            {
                string Texto = Tabla[n, 0].ToString() + Tabla[n, 1];
                //Tabla[n, 0];
                //Tabla[]
            }
        }
        public void Conectar_nodos()
        {
            foreach(Grafo grafo in List_grafos)
            {
               
            }
        }
    }
}
