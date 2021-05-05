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
        public int Contador = 1;



        //Rectangle Rect = new Rectangle();
        public frmPrincipal()
        {
            InitializeComponent();

        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            //Lista_grafos.Insertar_grafos(new Grafo(0, 303, 193, "Loreto"));
            Lista_grafos.Insertar_grafos(new Grafo(1, 77, 186, "Tumbes"));
            Lista_grafos.Insertar_grafos(new Grafo(2, 84, 228, "Piura"));
            Lista_grafos.Insertar_grafos(new Grafo(3, 101, 264, "Lambayeque"));
            Lista_grafos.Insertar_grafos(new Grafo(4, 162, 320, "LaLibertad"));
            Lista_grafos.Insertar_grafos(new Grafo(5, 194, 370, "Ancash"));
            Lista_grafos.Insertar_grafos(new Grafo(6, 232, 439, "Lima"));
            Lista_grafos.Insertar_grafos(new Grafo(7, 282, 523, "Ica"));
            Lista_grafos.Insertar_grafos(new Grafo(8, 403, 574, "Arequipa"));
            Lista_grafos.Insertar_grafos(new Grafo(9, 473, 617, "Moquegua"));
            Lista_grafos.Insertar_grafos(new Grafo(10, 501, 646, "Tacna"));
            Lista_grafos.Insertar_grafos(new Grafo(11, 150, 270, "Cajamarca"));
            Lista_grafos.Insertar_grafos(new Grafo(12, 258, 365, "Huanuco"));
            Lista_grafos.Insertar_grafos(new Grafo(13, 287, 400, "Pasco"));
            Lista_grafos.Insertar_grafos(new Grafo(14, 303, 436, "Junin"));
            Lista_grafos.Insertar_grafos(new Grafo(15, 304, 483, "Huancavelica"));
            Lista_grafos.Insertar_grafos(new Grafo(16, 341, 518, "Ayacucho"));
            Lista_grafos.Insertar_grafos(new Grafo(17, 392, 513, "Apurímac"));
            Lista_grafos.Insertar_grafos(new Grafo(18, 417, 481, "Cusco"));
            Lista_grafos.Insertar_grafos(new Grafo(19, 508, 540, "Puno"));
            Lista_grafos.Insertar_grafos(new Grafo(20, 487, 449, "Madre de Dios"));
            Lista_grafos.Insertar_grafos(new Grafo(21, 367, 379, "Ucayali"));
            Lista_grafos.Insertar_grafos(new Grafo(22, 232, 294, "San Martin"));
            Lista_grafos.Insertar_grafos(new Grafo(23, 175, 230, "Amazonas"));
            Lista_grafos.Insertar_grafos(new Grafo(24, 303, 205, "Loreto"));



            //cbxInicio.DataSource = Lista_grafos.List_grafos;
            //cbxInicio.DisplayMember = "Departamento";
            //cbxInicio.ValueMember = "Numero_grafo";
            //////cbxInicio.Items.Clear();
            //cbxFinal.DataSource = Lista_grafos.List_grafos;
            //cbxFinal.DisplayMember = "Departamento";
            //cbxFinal.ValueMember = "Numero_grafo";
            //////cbxFinal.Items.Add("asd");
     

            foreach (Grafo Graph in Lista_grafos.Obtener_grafos())
            {
                listboxGrafos.Items.Add("Grafo numero: " + Graph.Numero_grafo);
                listboxGrafos.Items.Add("Grafo posicion X: " + Graph.PosicionX);
                listboxGrafos.Items.Add("Grafo posicion Y: " + Graph.PosicionY);
                listboxGrafos.Items.Add("Departamento: " + Graph.Departamento);
                listboxGrafos.Items.Add("_____________________________________");

            }

            Generar_coordenadas_grafo();
        }
        private void Generar_coordenadas_grafo()
        {
            foreach (Grafo grafo in Lista_grafos.Obtener_grafos())
            {              
                Label Numero = new Label //muestra el numero que le corresponde al grafo
                {
                    Visible = true,
                    Text = grafo.Numero_grafo.ToString(),
                };
                Numero.Size = new Size(20, 14);
                Numero.BackColor = Color.Red;
                Numero.Location = new Point(grafo.PosicionX -2, grafo.PosicionY );
                
                pbxImagen.Controls.Add(Numero);
                GetGrafo.Dibujar_grafo(pbxImagen.CreateGraphics(), Brushes.Red, pbxImagen.Size, grafo);
            }
        }     
        private void frmPrincipal_MouseClick(object sender, MouseEventArgs e){}

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
             if (Lista_grafos.List_grafos.Count>0)
             {
             Lista_grafos.Select_grafo(e.X, e.Y,0);
             
             this.Text = "Canidadad de nodos: "+ Lista_grafos.Obtener_grafos().Count+" " +"Coordenada x: " + e.X + " Coordenada y: "+ e.Y+"distancia"+ Lista_grafos.Select_grafo(e.X, e.Y, 0);
             }
             else
             {
                 this.Text = "Canidadad de nodos: " + Lista_grafos.Obtener_grafos().Count + " " + "Coordenada x: " + e.X + " Coordenada y: " + e.Y;
             }
        }      

        private void btnDistancia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Lista_grafos.Calcular_distancia().ToString());
        }

        private void pbxImagen_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void pbxImagen_MouseClick(object sender, MouseEventArgs e)
        {           
           Generar_coordenadas_grafo();
        }

        private void pbxImagen_MouseMove(object sender, MouseEventArgs e)
        {
            if (Lista_grafos.List_grafos.Count > 0)
            {
                Lista_grafos.Select_grafo(e.X, e.Y, 0);

                this.Text = "Canidadad de nodos: " + Lista_grafos.Obtener_grafos().Count + " " + "Coordenada x: " + e.X + " Coordenada y: " + e.Y + "distancia" + Lista_grafos.Select_grafo(e.X, e.Y, 0);
            }
            else
            {
                this.Text = "Canidadad de nodos: " + Lista_grafos.Obtener_grafos().Count + " " + "Coordenada x: " + e.X + " Coordenada y: " + e.Y;
            }
        }

        private void pbxImagen_Click(object sender, EventArgs e)
        {

        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {

                Lista_grafos.Generar_camino(pbxImagen.CreateGraphics());
                Lista_grafos.Cerrar_camino(pbxImagen.CreateGraphics());

            }
            catch
            {
                MessageBox.Show("Error al generar el camino");
            }

        }
        private void btnNodo_Click(object sender, EventArgs e)
        {
            try
            {

                //foreach(Grafo grafo in Lista_grafos.List_grafos)
                //{
                //    grafo.Departamento = cbxInicio.SelectedItem.ToString();
                //    grafo.Departamento = cbxFinal.SelectedItem.ToString();


                //    Grafo inicial = Lista_grafos.List_grafos.Find(x => x.Departamento.Equals(grafo.Departamento));

                //    Grafo final = Lista_grafos.List_grafos.Find(x => x.Departamento.Equals(grafo.Departamento));

                //    Lista_grafos.Camino_punto_a_punto(pbxImagen.CreateGraphics(), inicial, final);

                //}

                //Grafo i = (Grafo)cbxInicio.Items[cbxInicio.SelectedIndex];
                //Grafo f = (Grafo)cbxFinal.Items[cbxFinal.SelectedIndex];

                //ar a= Lista_grafos.Encontrar_grafo_por_nombre(cbxInicio.SelectedItem.ToString());

                //Grafo i = new Grafo();

                //i.Numero_grafo = Convert.ToInt32(cbxInicio.SelectedValue);

                //Grafo f = new Grafo();

                //f.Numero_grafo = Convert.ToInt32(cbxFinal.SelectedValue);

                //Grafo inicial = (Grafo)cbxInicio.Items[Convert.ToInt32(cbxInicio.SelectedValue)];
                //Grafo final = (Grafo)cbxFinal.Items[Convert.ToInt32(cbxFinal.SelectedValue)];                
                //Lista_grafos.Camino_punto_a_punto(pbxImagen.CreateGraphics(), inicial, final);
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
