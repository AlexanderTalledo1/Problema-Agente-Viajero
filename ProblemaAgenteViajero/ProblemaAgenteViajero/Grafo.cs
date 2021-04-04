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

        public void Dibujar_grafo(Graphics graphics,Brush solid,Size size, Grafo grafo)
        {
            if (this.PosicionX < size.Width && this.PosicionY < size.Height)
            {
                Random Numeros_aleatorios = new Random();
                graphics.FillEllipse(solid, grafo.PosicionX, grafo.PosicionY, 40, 40);
                graphics.Dispose();
                
                //this.PosicionX = Numeros_aleatorios.Next(0, size.Width);
                //this.PosicionY = Numeros_aleatorios.Next(0, size.Height);  

            }
            
        }
    }
    public class ListaGrafos
    {
        public List<Grafo>List_grafos { get; set; }
        public ListaGrafos()
        {
            if(List_grafos==null)
            {
                List_grafos = new List<Grafo>();
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
        public void Calcular_distancia()
        {
           // int distancia = 0;
            //Adiciona la arista de 2 nodos
        }
        public void Conectar_nodos()
        {
            foreach(Grafo grafo in List_grafos)
            {
               
            }
        }
    }
}
