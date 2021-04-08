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

                // GraphicsPath camino = new GraphicsPath();
                //Pen Lapiz = new Pen(Color.Black, 1);
                //Grafo graph = new Grafo();
                //for(int i=0;i<Lista_grafos.Obtener_grafos().Count;i++)
                //{
                //    GraphicsPath camino = new GraphicsPath();
                //    Pen Lapiz = new Pen(Color.Black, 2);
                //    Point[] Puntos = new Point[100];
                //    Puntos[i] = new Point(graf.PosicionX, graph.Po);
                //    camino.AddPolygon(Puntos);
                //    this.CreateGraphics().DrawPath(Lapiz, camino);
                //}


                foreach (Grafo grafo in Lista_grafos.Obtener_grafos())
                {
                    GraphicsPath camino = new GraphicsPath();
                    Pen Lapiz = new Pen(Color.Black, 1);
                    Point[] Puntos = new Point[100];
                    Puntos[grafo.Numero_grafo] = new Point(grafo.PosicionX + 20, grafo.PosicionY + 20);
                    camino.AddPolygon(Puntos);
                    this.CreateGraphics().DrawPath(Lapiz, camino);
                }
               //this.CreateGraphics().DrawPath(Lapiz,camino);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }
           
        }        
        private void frmPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            Contador ++;
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
            //Generar_camino_grafos();
            Lista_grafos.Generar_camino(this.CreateGraphics());
            //Lista_grafos.Graphs_connected(this.CreateGraphics());
        }
    }
}
