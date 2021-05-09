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

    public class city
    {
        public int Numero_city { get; set; }
        public string Departamento { get; set; }
        public int PosicionX { get; set; }//coordenada X
        public int PosicionY { get; set; }//coordenada y
        public int[] Distancias{get; set; }
        public city()
        {
            this.Numero_city = 0;
            this.PosicionX = 0;
            this.PosicionY = 0;
        }
        public city(int numero_city,int posicionX,int posicionY,string departamento)
        {
            this.Numero_city = numero_city;
            this.PosicionX = posicionX;
            this.PosicionY = posicionY;
            this.Departamento = departamento;
            switch (numero_city)
            {
                case 0:this.Distancias= new int[24] { 0,287,0,0,0,0,0,0,0,0,739,0,0,0,0,0,0,0,0,0,0,0,0,692 }; ;break;
                case 1: this.Distancias= new int[24] { 287,0,194,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };;break;
                case 2: this.Distancias= new int[24] { 0,194,0,385,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };;break;
                case 3: this.Distancias= new int[24] { 0,0,385,0,295,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,207,0,0 };;break;
                case 4: this.Distancias= new int[24] { 0,0,0,295,0,427,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };;break;
                case 5: this.Distancias= new int[24] { 0,0,0,0,427,0,310,0,0,0,0,0,0,0,387,0,0,0,0,0,0,0,0,0 };;break;
                case 6: this.Distancias= new int[24] { 0,0,0,0,0,310,0,708,0,0,0,0,0,0,0,312,0,0,0,0,0,0,0,0 };;break;
                case 7: this.Distancias= new int[24] { 0,0,0,0,0,0,708,0,233,0,0,0,0,0,0,0,311,0,310,0,0,0,0,0 };;break;
                case 8: this.Distancias= new int[24] { 0,0,0,0,0,0,0,233,0,160,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };;break;
                case 9: this.Distancias= new int[24] { 0,0,0,0,0,0,0,0,160,0,0,0,0,0,0,0,0,0,402,0,0,0,0,0 };;break;
                case 10:this.Distancias= new int[24] { 739,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,232,0 };;break;
                case 11:this.Distancias= new int[24] { 0,0,0,0,0,0,0,0,0,0,0,0,132,0,0,0,0,0,0,0,0,305,0,0 };;break;
                case 12:this.Distancias= new int[24] { 0,0,0,0,0,0,0,0,0,0,0,132,0,101,0,0,0,0,0,0,0,0,0,0 };;break;
                case 13:this.Distancias= new int[24] { 0,0,0,0,0,0,0,0,0,0,0,0,101,0,269,0,0,0,0,0,0,0,0,0 };;break;
                case 14:this.Distancias= new int[24] { 0,0,0,0,0,387,0,0,0,0,0,0,0,269,0,0,0,0,0,0,388,0,0,0 };;break;
                case 15:this.Distancias= new int[24] { 0,0,0,0,0,0,312,0,0,0,0,0,0,0,0,0,157,0,0,0,0,0,0,0 };;break;
                case 16:this.Distancias= new int[24] { 0,0,0,0,0,0,0,311,0,0,0,0,0,0,0,157,0,134,0,0,0,0,0,0 };;break;
                case 17:this.Distancias= new int[24] { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,134,0,0,233,430,0,0,0 };;break;
                case 18:this.Distancias= new int[24] { 0,0,0,0,0,0,0,310,0,402,0,0,0,0,0,0,0,0,0,461,0,0,0,0 };;break;
                case 19:this.Distancias= new int[24] { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,233,0,0,329,0,0,0 };;break;
                case 20:this.Distancias= new int[24] { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,388,0,0,0,0,0,0,0,0,594 };;break;
                case 21:this.Distancias= new int[24] { 0,0,0,207,0,0,0,0,0,0,0,305,0,0,0,0,0,0,0,0,0,0,0,345 };;break;
                case 22:this.Distancias= new int[24] { 0,0,0,0,0,0,0,0,0,232,0,0,0,0,0,0,0,0,0,0,0,0,0,442 };;break;
                case 23: this.Distancias = new int[24]{692,0,0,0,0, 0, 345, 0, 0, 0, 594, 0, 0, 0, 0, 0, 0, 0, 0, 0, 594, 345, 442, 0 }; ; break;
                default:
                    break;
            }
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
