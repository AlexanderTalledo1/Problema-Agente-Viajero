using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProblemaAgenteViajero
{
    public partial class frmPrincipal : Form
    {
        readonly Grafo GetGrafo = new Grafo();
        readonly ListaGrafos Lista_grafos = new ListaGrafos();

        public string Nombre { get; set; }
        public int Contador = 0;

          //Rectangle Rect = new Rectangle();
        public frmPrincipal()
        {
            InitializeComponent();     
        }      
        private void frmPrincipal_Load(object sender, EventArgs e) 
        {         
        }
        private void Generar_coordenadas_grafo()
        {            
            foreach (Grafo grafo in Lista_grafos.Obtener_grafos())
            {
                Label Coordenadas = new Label//muestra las coordenada arriba del grafo
                {
                    Visible = true,
                    Text = "(" + grafo.PosicionX + "," + grafo.PosicionY + ")",
                };
                Coordenadas.Size = new Size(80, 15);
                Coordenadas.Location = new Point(grafo.PosicionX, grafo.PosicionY - 30);


                Label Numero = new Label //muestra el numero que le corresponde al grafo
                {
                    Visible = true,
                    Text = grafo.Numero_grafo.ToString(),
                };
                Numero.Size = new Size(20,14);
                Numero.BackColor = Color.Red;
                Numero.Location = new Point(grafo.PosicionX+13, grafo.PosicionY+15);

                                
                Controls.Add(Coordenadas);
                Controls.Add(Numero);
                GetGrafo.Dibujar_grafo(this.CreateGraphics(), Brushes.Red, this.Size, grafo);
            }
        }
        private void Generar_camino_grafos()
        {
            try
            {
                //foreach (Grafo grafo in Lista_grafos.Obtener_grafos())
                //{
                //    for (int i = 0; i < Lista_grafos.Obtener_grafos().Count; i++)
                //    {
                //        Pen Lapiz = new Pen(Color.Black, 2);

                //        Point[] Puntos = new Point[100];
                //        GraphicsPath Camino = new GraphicsPath();
                //        Puntos[i] = new Point(grafo.PosicionX, grafo.PosicionY);
                //        Camino.AddPolygon(Puntos);
                //        this.CreateGraphics().DrawPath(Lapiz,Camino);
                //    }
                //}

                //for(int i=0;i< Lista_grafos;i++)
                //{
                //    GraphicsPath camino = new GraphicsPath();
                //    Point[] Puntos = new Point[100];
                //    Pen Lapiz = new Pen(Color.Black, 2);
                //    Grafo graph = new Grafo();
                //    Puntos[i] = new Point(graph.PosicionX, graph.PosicionY);
                //    camino.AddPolygon(Puntos);

                //    this.CreateGraphics().DrawPath(Lapiz, camino);
                //}
                Point[] Puntos = new Point[100];
                foreach (Grafo grafo in Lista_grafos.Obtener_grafos())
                {


                    GraphicsPath camino = new GraphicsPath();
                    Pen Lapiz = new Pen(Color.Black, 2);
                    Puntos[grafo.Numero_grafo] = new Point(grafo.PosicionX + 20, grafo.PosicionY + 20);                
                    camino.AddPolygon(Puntos);
                        //camino.add                 
                    this.CreateGraphics().DrawPath(Lapiz, camino);
                   
                   
                }

            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
           
        }
        //private void Generar_camino_grafos()
        //{
        //    Pen Lapiz = new Pen(Color.Black, 2);
        //   //foreach(Grafo Grafo in Lista_grafos.Obtener_grafos())
        //   //{
        //     Point[] puntos =
        //     {
        //         new Point(20,20),
        //        new Point(200,60),
        //        new Point(180,240),
        //        new Point(50,270),
        //        new Point(100,40),
        //        new Point(10,100)
        //         //new Point(Grafo.PosicionX,Grafo.PosicionY),
        //     };
        //     GraphicsPath Camino = new GraphicsPath();
        //     Camino.AddPolygon(puntos);
        //     this.CreateGraphics().DrawPath(Lapiz, Camino);
           
             
        //    for(int i=0;i<Lista_grafos.Obtener_grafos().Count;i++)           
        //    {

           
        //    }

        //   //}                            
        //}
        private void frmPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            Contador +=1;
            Grafo grafo = new Grafo
            {
                PosicionX = e.X,
                PosicionY = e.Y,
                Numero_grafo =Contador,
            };
            Lista_grafos.Insertar_grafos(grafo);
            Generar_coordenadas_grafo();
            
            //Generar_camino_grafos();
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Canidadad de nodos: "+ Lista_grafos.Obtener_grafos().Count+" " +"Coordenada x: " + e.X + " Coordenada y: "+ e.Y;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar_camino_grafos();
        }
    }
}
