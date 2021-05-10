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
        
        city GetCity ;

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
            //MessageBox.Show(Lista_grafos.Calcular_distancia().ToString());
            //GetCity.buscar_camino();
            //MessageBox.Show(GetCity.getdistancia().ToString()+ GetCity.getcamino().ToString());
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

                this.Text = "Canidadad de nodos: " + Lista_grafos.Obtener_grafos().Count + " " + "Coordenada x: " + e.X + " Coordenada y: " + e.Y + "distancia" + Lista_grafos.Select_grafo(e.X, e.Y, 0) + " nombre: " + Lista_grafos.Select_grafo(e.X, e.Y, 1);
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

        private void cbxInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxInicio.SelectedIndex)
            {
   
                case 0:  GetCity =new city(1, 77, 186, "Tumbes") ;break;
                case 1:  GetCity =new city(2, 84, 228, "Piura");; break;
                case 2:  GetCity =new city(3, 101, 264, "Lambayeque");; break;
                case 3:  GetCity =new city(4, 162, 320, "LaLibertad");; break;
                case 4:  GetCity =new city(5, 194, 370, "Ancash");; break;
                case 5:  GetCity =new city(6, 232, 439, "Lima");; break;
                case 6:  GetCity =new city(7, 282, 523, "Ica"); ;break;
                case 7:  GetCity =new city(8, 403, 574, "Arequipa"); ;break;
                case 8:  GetCity =new city(9, 473, 617, "Moquegua"); ;break;
                case 9:  GetCity =new city(10, 501, 646, "Tacna"); ;break;
               case 10:  GetCity =new city(11, 150, 270, "Cajamarca"); ;break;
               case 11:  GetCity =new city(12, 258, 365, "Huanuco");; break;
               case 12:  GetCity =new city(13, 287, 400, "Pasco");; break;
               case 13:  GetCity =new city(14, 303, 436, "Junin"); ;break;
               case 14:  GetCity =new city(15, 304, 483, "Huancavelica"); ;break;
               case 15:  GetCity =new city(16, 341, 518, "Ayacucho"); ;break;
               case 16:  GetCity =new city(17, 392, 513, "Apurímac"); ;break;
               case 17:  GetCity =new city(18, 417, 481, "Cusco");; break;
               case 18:  GetCity =new city(19, 508, 540, "Puno");; break;
               case 19:  GetCity =new city(20, 487, 449, "Madre de Dios");; break;
               case 20:  GetCity =new city(21, 367, 379, "Ucayali");; break;
               case 21:  GetCity =new city(22, 232, 294, "San Martin");; break;
               case 22:  GetCity =new city(23, 175, 230, "Amazonas");; break;
               case 23:  GetCity = new city(24, 303, 205, "Loreto");; break;
            }
        }

        private void cbxFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxFinal.SelectedIndex)
            {
                case 0:this.GetCity.addestino(1); break;
                case 1: this.GetCity.addestino(2); break;
                case 2: this.GetCity.addestino(3); break;
                case 3: this.GetCity.addestino(4); break;
                case 4: this.GetCity.addestino(5); break;
                case 5: this.GetCity.addestino(6); break;
                case 6: this.GetCity.addestino(7); break;
                case 7: this.GetCity.addestino(8); break;
                case 8: this.GetCity.addestino(9); break;
                case 9: this.GetCity.addestino(10); break;
                case 10:this.GetCity.addestino(11); break;
                case 11:this.GetCity.addestino(12); break;
                case 12:this.GetCity.addestino(13); break;
                case 13:this.GetCity.addestino(14); break;
                case 14:this.GetCity.addestino(15); break;
                case 15:this.GetCity.addestino(16); break;
                case 16:this.GetCity.addestino(17); break;
                case 17:this.GetCity.addestino(18); break;
                case 18:this.GetCity.addestino(19); break;
                case 19:this.GetCity.addestino(20); break;
                case 20:this.GetCity.addestino(21); break;
                case 21:this.GetCity.addestino(22); break;
                case 22: this.GetCity.addestino(23); break;

                case 23: this.GetCity.addestino(24); break;
            }
        }
    }
}
