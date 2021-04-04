using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProblemaAgenteViajero
{
    public partial class frmPrincipal : Form
    {
        Grafo GetGrafo = new Grafo();
        ListaGrafos Lista_grafos = new ListaGrafos();
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
            //dibuja las coordenada arriba del grafo
            foreach(Grafo grafo in Lista_grafos.Obtener_grafos())
            {
                Label Coordenadas = new Label
                {
                    Visible = true,
                    Text = "(" + grafo.PosicionX + "," + grafo.PosicionY + ")",                   
                };
                Coordenadas.AutoSize.ToString();
                Coordenadas.Location = new Point(grafo.PosicionX, grafo.PosicionY - 30);
                GetGrafo.Dibujar_grafo(this.CreateGraphics(), Brushes.Red, this.Size, grafo);
                Controls.Add(Coordenadas);                
            }
        }
        private void frmPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            Grafo grafo = new Grafo
            {
                PosicionX = e.X,
                PosicionY = e.Y
            };
            Lista_grafos.Insertar_grafos(grafo);            
            Generar_coordenadas_grafo();              
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "Coordenada x: " + e.X + "Coordenada y: "+ e.Y;
        }
    }
}
