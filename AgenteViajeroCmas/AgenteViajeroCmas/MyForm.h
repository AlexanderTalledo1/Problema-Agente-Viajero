#pragma once
#include"Elementos.h"
namespace AgenteViajeroCmas {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Resumen de MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	private:
		int cantGrafos = 0;

	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::TextBox^ textBox3;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::Label^ label5;
	private: System::Windows::Forms::GroupBox^ groupBox1;
	public: System::Windows::Forms::PictureBox^ pictureBox1;
	private: System::Windows::Forms::Label^ d1;
	public:
	private: System::Windows::Forms::Label^ d2;
	private: System::Windows::Forms::Label^ d3;
	private: System::Windows::Forms::Label^ d4;
	private: System::Windows::Forms::Label^ d5;
	private: System::Windows::Forms::Label^ d6;
	private: System::Windows::Forms::Label^ d7;
	private: System::Windows::Forms::Label^ d8;
	private: System::Windows::Forms::Label^ d9;
	private: System::Windows::Forms::Label^ d10;
	private: System::Windows::Forms::Label^ d11;
	private: System::Windows::Forms::Label^ d12;
	private: System::Windows::Forms::Label^ d13;
	private: System::Windows::Forms::Label^ d14;
	private: System::Windows::Forms::Label^ d15;

	private: System::Windows::Forms::Label^ d16;
	private: System::Windows::Forms::Label^ d17;
	private: System::Windows::Forms::Label^ d18;
	private: System::Windows::Forms::Label^ d21;
	private: System::Windows::Forms::Label^ d20;
	private: System::Windows::Forms::Label^ d19;
	private: System::Windows::Forms::Label^ d24;
	private: System::Windows::Forms::Label^ d23;
	private: System::Windows::Forms::Label^ d22;
	private:




	
		  
		   
	private:
		vector<Grafo>* grafos = new vector<Grafo>;
		Graphics^ g;
	public:
		MyForm(void)
		{
			
			InitializeComponent();
		
			general = new Grafo();

			general->E = 32;
			general->V = 24;
			general->G[1-1].push_back(Distancia(2-1, 287));
			general->G[2-1].push_back(Distancia(1-1, 287));
												 
			general->G[3-1].push_back(Distancia(2-1, 194));
			general->G[2-1].push_back(Distancia(3-1, 194));
												 
			general->G[4-1].push_back(Distancia(3-1, 385));
			general->G[3-1].push_back(Distancia(4-1, 385));
												 
			general->G[5-1].push_back(Distancia(4-1, 295));
			general->G[4-1].push_back(Distancia(5-1, 295));
												 
			general->G[6-1].push_back(Distancia(5-1, 427));
			general->G[5-1].push_back(Distancia(6-1, 427));
												 
			general->G[6-1].push_back(Distancia(7-1, 310));
			general->G[7-1].push_back(Distancia(6-1, 310));
												 
			general->G[7-1].push_back(Distancia(8-1, 708));
			general->G[8-1].push_back(Distancia(7-1, 708));
												 
			general->G[8-1].push_back(Distancia(9-1, 223));
			general->G[9-1].push_back(Distancia(8-1, 223));
						
			general->G[9-1].push_back(Distancia(10-1, 160));
			general->G[10-1].push_back(Distancia(9-1, 160));

			general->G[1-1].push_back(Distancia(24-1, 692));
			general->G[24-1].push_back(Distancia(1-1, 692));
						 
			general->G[21-1].push_back(Distancia(24-1, 594));
			general->G[24-1].push_back(Distancia(21-1, 594));
						 						   
			general->G[21-1].push_back(Distancia(20-1, 329));
			general->G[20-1].push_back(Distancia(21-1, 329));
						 						   
			general->G[19-1].push_back(Distancia(20-1, 461));
			general->G[20-1].push_back(Distancia(19-1, 461));
						 						   
			general->G[10-1].push_back(Distancia(19-1, 402));
			general->G[19-1].push_back(Distancia(10-1, 402));

			general->G[1-1].push_back(Distancia(11-1, 739));
			general->G[11-1].push_back(Distancia(1-1, 739));

			general->G[11-1].push_back(Distancia(23-1, 232));
			general->G[23-1].push_back(Distancia(11-1, 232));
						 						   
			general->G[23-1].push_back(Distancia(24-1, 442));
			general->G[24-1].push_back(Distancia(23-1, 442));

			general->G[4-1].push_back(Distancia(22-1, 207));
			general->G[22-1].push_back(Distancia(4-1, 207));
						 
			general->G[22-1].push_back(Distancia(24-1, 345));
			general->G[24-1].push_back(Distancia(22-1, 345));
						 						   
			general->G[22-1].push_back(Distancia(12-1, 305));
			general->G[12-1].push_back(Distancia(22-1, 305));
						 						   
			general->G[12-1].push_back(Distancia(13-1, 132));
			general->G[13-1].push_back(Distancia(12-1, 132));
						 						   
			general->G[13-1].push_back(Distancia(14-1, 101));
			general->G[14-1].push_back(Distancia(13-1, 101));
						 						   
			general->G[14-1].push_back(Distancia(15-1, 269));
			general->G[15-1].push_back(Distancia(14-1, 269));
						 
			general->G[15-1].push_back(Distancia(6-1, 387));
			general->G[6-1].push_back(Distancia(15-1, 387));
						
			general->G[7-1].push_back(Distancia(16-1, 312));
			general->G[16-1].push_back(Distancia(7-1, 312));

			general->G[16-1].push_back(Distancia(17-1, 157));
			general->G[17-1].push_back(Distancia(16-1, 157));
						 						   
			general->G[17-1].push_back(Distancia(18-1, 134));
			general->G[18-1].push_back(Distancia(17-1, 134));
						 						   
			general->G[21-1].push_back(Distancia(18-1, 430));
			general->G[18-1].push_back(Distancia(21-1, 430));
						 						   
			general->G[18-1].push_back(Distancia(20-1, 233));
			general->G[20-1].push_back(Distancia(18-1, 233));
						 
			general->G[17-1].push_back(Distancia(8-1, 311));
			general->G[8-1].push_back(Distancia(17-1, 311));
						
			general->G[8-1].push_back(Distancia(19-1, 310));
			general->G[19-1].push_back(Distancia(8-1, 310));
						 
			general->G[15-1].push_back(Distancia(21-1, 388));
			general->G[21-1].push_back(Distancia(15-1, 388));
			//
			//TODO: agregar código de constructor aquí
			//
		}

		int algoritmoSample(const int begin, const int end, const Grafo graph)
		{
			
		
			
			Pen^ pen = gcnew Pen(Color::Black,5);
			priority_queue<State> pq; 
		
			vector<int> Dist(graph.V, oo); 
			vector<bool> paso(graph.V, false); 
			vector<int> camino;
		
			Dist[begin] = 0; 
			pq.push(State(begin, 0)); 
			while (!pq.empty()) 
			{
				State st = pq.top(); pq.pop(); 
				camino.push_back(st.nodo);
				label5->Text += camino.at(camino.size()-1);
				
				paso[st.nodo] = true;
				if (st.nodo == end)
					return st.costo; 

				int T = (int)graph.G[st.nodo].size();
				for (int i = 0; i < T; ++i) 
				{
						if (!paso[graph.G[st.nodo][i].nodo] && ((Dist[st.nodo] + graph.G[st.nodo][i].costo) < Dist[graph.G[st.nodo][i].nodo]))
					{
						Dist[graph.G[st.nodo][i].nodo] = st.costo + graph.G[st.nodo][i].costo;
						pq.push(State(graph.G[st.nodo][i].nodo, st.costo + graph.G[st.nodo][i].costo));
						/*if (st.nodo==begin)
						{

						}*/
						int in; int fin;
						in = st.nodo;
						fin = graph.G[st.nodo][i].nodo;
						int x1, x2, y1, y2;
						switch (in)
						{
						case 0: x1 =  d1 ->Location.X+13;    y1 = d1->Location.Y + 13; ; break;
						case 1:  x1 = d2->Location.X + 13;   y1 = d2->Location.Y + 13;; ; break;
						case 2:  x1 = d3->Location.X + 13;  y1 = d3->Location.Y + 13;; break;
						case 3:  x1 = d4->Location.X + 13; y1 = d4->Location.Y + 13;; break;
						case 4:  x1 = d5->Location.X + 13; y1 = d5->Location.Y + 13;; ; break;
						case 5:  x1 = d6->Location.X + 13; y1 = d6->Location.Y + 13;; break;
						case 6:  x1 = d7->Location.X + 13; y1 = d7->Location.Y + 13;; ; break;
						case 7:  x1 = d8->Location.X + 13; y1 = d8->Location.Y + 13;; ; break;
						case 8:  x1 = d9->Location.X + 13; y1 = d9->Location.Y + 13;; ; break;
						case 9:  x1 = d10->Location.X;      y1 = d10->Location.Y;; break;
						case 10: x1 = d11->Location.X;     y1 = d11->Location.Y;; break;
						case 11: x1 = d12->Location.X;     y1 = d12->Location.Y + 13;; break;
						case 12: x1 = d13->Location.X;     y1 = d13->Location.Y;; break;
						case 13: x1 = d14->Location.X + 13; y1 = d14->Location.Y + 13;; break;
						case 14: x1 = d15->Location.X;     y1 = d15->Location.Y;; break;
						case 15: x1 = d16->Location.X;     y1 = d16->Location.Y;; ; break;
						case 16: x1 = d17->Location.X;     y1 = d17->Location.Y + 13;; break;
						case 17: x1 = d18->Location.X + 13; y1 = d18->Location.Y + 13;; ; break;
						case 18: x1 = d19->Location.X;     y1 = d19->Location.Y; ; break;
						case 19: x1 = d20->Location.X;     y1 = d20->Location.Y;; ; break;
						case 20: x1 = d21->Location.X + 13; y1 = d21->Location.Y + 13;; break;
						case 21: x1 = d22->Location.X;     y1 = d22->Location.Y+13;; break;
						case 22: x1 = d23->Location.X + 13; y1 = d23->Location.Y + 13;; ; break;
						case 23: x1 = d24->Location.X;     y1 = d24->Location.Y;; break;
						
						default:
							break;
						}
						switch (fin)
						{
						case 0:  x2 = d1->Location.X + 13; y2 = d1->Location.Y + 13; ; break;
						case 1:  x2 = d2->Location.X + 13; y2 = d2->Location.Y + 13;; ; break;
						case 2:  x2 = d3->Location.X + 13; y2 = d3->Location.Y + 13;; break;
						case 3:  x2 = d4->Location.X + 13; y2 = d4->Location.Y + 13;; break;
						case 4:  x2 = d5->Location.X + 13; y2 = d5->Location.Y + 13;; ; break;
						case 5:  x2 = d6->Location.X + 13; y2 = d6->Location.Y + 13;; break;
						case 6:  x2 = d7->Location.X + 13; y2 = d7->Location.Y + 13;; ; break;
						case 7:  x2 = d8->Location.X + 13; y2 = d8->Location.Y + 13;; ; break;
						case 8:  x2 = d9->Location.X + 13; y2 = d9->Location.Y + 13;; ; break;
						case 9:  x2 = d10->Location.X;      y2 = d10->Location.Y;; break;
						case 10: x2 = d11->Location.X;      y2 = d11->Location.Y;; break;
						case 11: x2 = d12->Location.X;      y2 = d12->Location.Y + 13;; break;
						case 12: x2 = d13->Location.X;      y2 = d13->Location.Y;; break;
						case 13: x2 = d14->Location.X + 13; y2 = d14->Location.Y + 13;; break;
						case 14: x2 = d15->Location.X;      y2 = d15->Location.Y;; break;
						case 15: x2 = d16->Location.X;      y2 = d16->Location.Y;; ; break;
						case 16: x2 = d17->Location.X;      y2 = d17->Location.Y + 13;; break;
						case 17: x2 = d18->Location.X + 13; y2 = d18->Location.Y + 13;; ; break;
						case 18: x2 = d19->Location.X;      y2 = d19->Location.Y; ; break;
						case 19: x2 = d20->Location.X;      y2 = d20->Location.Y;; ; break;
						case 20: x2 = d21->Location.X + 13; y2 = d21->Location.Y + 13;; break;
						case 21: x2 = d22->Location.X;      y2 = d22->Location.Y+13;; break;
						case 22: x2 = d23->Location.X + 13; y2 = d23->Location.Y + 13;; ; break;
						case 23: x2 = d24->Location.X;      y2 = d24->Location.Y;; break;

						default:
							break;
						}
						pictureBox1->CreateGraphics()->DrawLine(pen, x1, y1, x2, y2);
						_sleep(600);

					}
				}
			}
			return -1;
		}


	protected:
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Timer^ timer1;



	protected:
	private: System::ComponentModel::IContainer^ components;

	private:
		Grafo *general;

#pragma region Windows Form Designer generated code
	
		void InitializeComponent(void)
		{
			this->components = (gcnew System::ComponentModel::Container());
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(MyForm::typeid));
			this->timer1 = (gcnew System::Windows::Forms::Timer(this->components));
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->d1 = (gcnew System::Windows::Forms::Label());
			this->d2 = (gcnew System::Windows::Forms::Label());
			this->d3 = (gcnew System::Windows::Forms::Label());
			this->d4 = (gcnew System::Windows::Forms::Label());
			this->d5 = (gcnew System::Windows::Forms::Label());
			this->d6 = (gcnew System::Windows::Forms::Label());
			this->d7 = (gcnew System::Windows::Forms::Label());
			this->d8 = (gcnew System::Windows::Forms::Label());
			this->d9 = (gcnew System::Windows::Forms::Label());
			this->d10 = (gcnew System::Windows::Forms::Label());
			this->d11 = (gcnew System::Windows::Forms::Label());
			this->d12 = (gcnew System::Windows::Forms::Label());
			this->d13 = (gcnew System::Windows::Forms::Label());
			this->d14 = (gcnew System::Windows::Forms::Label());
			this->d15 = (gcnew System::Windows::Forms::Label());
			this->d16 = (gcnew System::Windows::Forms::Label());
			this->d17 = (gcnew System::Windows::Forms::Label());
			this->d18 = (gcnew System::Windows::Forms::Label());
			this->d21 = (gcnew System::Windows::Forms::Label());
			this->d20 = (gcnew System::Windows::Forms::Label());
			this->d19 = (gcnew System::Windows::Forms::Label());
			this->d24 = (gcnew System::Windows::Forms::Label());
			this->d23 = (gcnew System::Windows::Forms::Label());
			this->d22 = (gcnew System::Windows::Forms::Label());
			this->groupBox1->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// timer1
			// 
			this->timer1->Enabled = true;
			this->timer1->Tick += gcnew System::EventHandler(this, &MyForm::timer1_Tick);
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(782, 310);
			this->button1->Margin = System::Windows::Forms::Padding(2);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(112, 36);
			this->button1->TabIndex = 1;
			this->button1->Text = L"Borrar";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(17, 23);
			this->label2->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(126, 25);
			this->label2->TabIndex = 4;
			this->label2->Text = L"Vertice inicial";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(17, 66);
			this->label3->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(120, 25);
			this->label3->TabIndex = 5;
			this->label3->Text = L"Vertice Final";
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(161, 20);
			this->textBox2->Margin = System::Windows::Forms::Padding(2);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(30, 30);
			this->textBox2->TabIndex = 6;
			this->textBox2->TextChanged += gcnew System::EventHandler(this, &MyForm::textBox2_TextChanged);
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(161, 66);
			this->textBox3->Margin = System::Windows::Forms::Padding(2);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(30, 30);
			this->textBox3->TabIndex = 7;
			// 
			// button2
			// 
			this->button2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->button2->Location = System::Drawing::Point(50, 127);
			this->button2->Margin = System::Windows::Forms::Padding(2);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(123, 54);
			this->button2->TabIndex = 8;
			this->button2->Text = L"Hallar distancia minima";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// label4
			// 
			this->label4->Anchor = static_cast<System::Windows::Forms::AnchorStyles>((((System::Windows::Forms::AnchorStyles::Top | System::Windows::Forms::AnchorStyles::Bottom)
				| System::Windows::Forms::AnchorStyles::Left)
				| System::Windows::Forms::AnchorStyles::Right));
			this->label4->AutoSize = true;
			this->label4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label4->ForeColor = System::Drawing::Color::RoyalBlue;
			this->label4->Location = System::Drawing::Point(71, 205);
			this->label4->Margin = System::Windows::Forms::Padding(2, 0, 2, 0);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(75, 20);
			this->label4->TabIndex = 9;
			this->label4->Text = L"Distancia";
			this->label4->Click += gcnew System::EventHandler(this, &MyForm::label4_Click);
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(757, 272);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(0, 13);
			this->label5->TabIndex = 10;
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->textBox2);
			this->groupBox1->Controls->Add(this->label2);
			this->groupBox1->Controls->Add(this->label4);
			this->groupBox1->Controls->Add(this->textBox3);
			this->groupBox1->Controls->Add(this->button2);
			this->groupBox1->Controls->Add(this->label3);
			this->groupBox1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 15, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->groupBox1->Location = System::Drawing::Point(740, 0);
			this->groupBox1->Margin = System::Windows::Forms::Padding(2);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Padding = System::Windows::Forms::Padding(2);
			this->groupBox1->Size = System::Drawing::Size(222, 270);
			this->groupBox1->TabIndex = 11;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L" ";
			this->groupBox1->Enter += gcnew System::EventHandler(this, &MyForm::groupBox1_Enter);
			// 
			// pictureBox1
			// 
			this->pictureBox1->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox1.Image")));
			this->pictureBox1->ImageLocation = L"";
			this->pictureBox1->InitialImage = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"pictureBox1.InitialImage")));
			this->pictureBox1->Location = System::Drawing::Point(0, 0);
			this->pictureBox1->Margin = System::Windows::Forms::Padding(2);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(532, 822);
			this->pictureBox1->SizeMode = System::Windows::Forms::PictureBoxSizeMode::StretchImage;
			this->pictureBox1->TabIndex = 12;
			this->pictureBox1->TabStop = false;
			// 
			// d1
			// 
			this->d1->AutoSize = true;
			this->d1->Location = System::Drawing::Point(63, 214);
			this->d1->Name = L"d1";
			this->d1->Size = System::Drawing::Size(13, 13);
			this->d1->TabIndex = 13;
			this->d1->Text = L"1";
			// 
			// d2
			// 
			this->d2->AutoSize = true;
			this->d2->Location = System::Drawing::Point(56, 258);
			this->d2->Name = L"d2";
			this->d2->Size = System::Drawing::Size(13, 13);
			this->d2->TabIndex = 14;
			this->d2->Text = L"2";
			// 
			// d3
			// 
			this->d3->AutoSize = true;
			this->d3->Location = System::Drawing::Point(84, 330);
			this->d3->Name = L"d3";
			this->d3->Size = System::Drawing::Size(13, 13);
			this->d3->TabIndex = 15;
			this->d3->Text = L"3";
			// 
			// d4
			// 
			this->d4->AutoSize = true;
			this->d4->Location = System::Drawing::Point(128, 399);
			this->d4->Name = L"d4";
			this->d4->Size = System::Drawing::Size(13, 13);
			this->d4->TabIndex = 16;
			this->d4->Text = L"4";
			// 
			// d5
			// 
			this->d5->AutoSize = true;
			this->d5->Location = System::Drawing::Point(167, 424);
			this->d5->Name = L"d5";
			this->d5->Size = System::Drawing::Size(13, 13);
			this->d5->TabIndex = 17;
			this->d5->Text = L"5";
			// 
			// d6
			// 
			this->d6->AutoSize = true;
			this->d6->Location = System::Drawing::Point(204, 541);
			this->d6->Name = L"d6";
			this->d6->Size = System::Drawing::Size(13, 13);
			this->d6->TabIndex = 18;
			this->d6->Text = L"6";
			// 
			// d7
			// 
			this->d7->AutoSize = true;
			this->d7->Location = System::Drawing::Point(227, 621);
			this->d7->Name = L"d7";
			this->d7->Size = System::Drawing::Size(13, 13);
			this->d7->TabIndex = 19;
			this->d7->Text = L"7";
			// 
			// d8
			// 
			this->d8->AutoSize = true;
			this->d8->Location = System::Drawing::Point(348, 681);
			this->d8->Name = L"d8";
			this->d8->Size = System::Drawing::Size(13, 13);
			this->d8->TabIndex = 20;
			this->d8->Text = L"8";
			// 
			// d9
			// 
			this->d9->AutoSize = true;
			this->d9->Location = System::Drawing::Point(408, 733);
			this->d9->Name = L"d9";
			this->d9->Size = System::Drawing::Size(13, 13);
			this->d9->TabIndex = 21;
			this->d9->Text = L"9";
			// 
			// d10
			// 
			this->d10->AutoSize = true;
			this->d10->Location = System::Drawing::Point(426, 745);
			this->d10->Name = L"d10";
			this->d10->Size = System::Drawing::Size(19, 13);
			this->d10->TabIndex = 22;
			this->d10->Text = L"10";
			// 
			// d11
			// 
			this->d11->AutoSize = true;
			this->d11->Location = System::Drawing::Point(117, 316);
			this->d11->Name = L"d11";
			this->d11->Size = System::Drawing::Size(19, 13);
			this->d11->TabIndex = 23;
			this->d11->Text = L"11";
			// 
			// d12
			// 
			this->d12->AutoSize = true;
			this->d12->Location = System::Drawing::Point(207, 437);
			this->d12->Name = L"d12";
			this->d12->Size = System::Drawing::Size(19, 13);
			this->d12->TabIndex = 24;
			this->d12->Text = L"12";
			// 
			// d13
			// 
			this->d13->AutoSize = true;
			this->d13->Location = System::Drawing::Point(255, 464);
			this->d13->Name = L"d13";
			this->d13->Size = System::Drawing::Size(19, 13);
			this->d13->TabIndex = 25;
			this->d13->Text = L"13";
			// 
			// d14
			// 
			this->d14->AutoSize = true;
			this->d14->Location = System::Drawing::Point(254, 513);
			this->d14->Name = L"d14";
			this->d14->Size = System::Drawing::Size(19, 13);
			this->d14->TabIndex = 26;
			this->d14->Text = L"14";
			// 
			// d15
			// 
			this->d15->AutoSize = true;
			this->d15->Location = System::Drawing::Point(254, 561);
			this->d15->Name = L"d15";
			this->d15->Size = System::Drawing::Size(19, 13);
			this->d15->TabIndex = 27;
			this->d15->Text = L"15";
			// 
			// d16
			// 
			this->d16->AutoSize = true;
			this->d16->Location = System::Drawing::Point(273, 611);
			this->d16->Name = L"d16";
			this->d16->Size = System::Drawing::Size(19, 13);
			this->d16->TabIndex = 28;
			this->d16->Text = L"16";
			// 
			// d17
			// 
			this->d17->AutoSize = true;
			this->d17->Location = System::Drawing::Point(324, 609);
			this->d17->Name = L"d17";
			this->d17->Size = System::Drawing::Size(19, 13);
			this->d17->TabIndex = 29;
			this->d17->Text = L"17";
			// 
			// d18
			// 
			this->d18->AutoSize = true;
			this->d18->Location = System::Drawing::Point(337, 564);
			this->d18->Name = L"d18";
			this->d18->Size = System::Drawing::Size(19, 13);
			this->d18->TabIndex = 30;
			this->d18->Text = L"18";
			// 
			// d21
			// 
			this->d21->AutoSize = true;
			this->d21->Location = System::Drawing::Point(324, 469);
			this->d21->Name = L"d21";
			this->d21->Size = System::Drawing::Size(19, 13);
			this->d21->TabIndex = 31;
			this->d21->Text = L"21";
			// 
			// d20
			// 
			this->d20->AutoSize = true;
			this->d20->Location = System::Drawing::Point(404, 552);
			this->d20->Name = L"d20";
			this->d20->Size = System::Drawing::Size(19, 13);
			this->d20->TabIndex = 32;
			this->d20->Text = L"20";
			// 
			// d19
			// 
			this->d19->AutoSize = true;
			this->d19->Location = System::Drawing::Point(433, 625);
			this->d19->Name = L"d19";
			this->d19->Size = System::Drawing::Size(19, 13);
			this->d19->TabIndex = 33;
			this->d19->Text = L"19";
			// 
			// d24
			// 
			this->d24->AutoSize = true;
			this->d24->Location = System::Drawing::Point(264, 204);
			this->d24->Name = L"d24";
			this->d24->Size = System::Drawing::Size(19, 13);
			this->d24->TabIndex = 34;
			this->d24->Text = L"24";
			// 
			// d23
			// 
			this->d23->AutoSize = true;
			this->d23->Location = System::Drawing::Point(141, 297);
			this->d23->Name = L"d23";
			this->d23->Size = System::Drawing::Size(19, 13);
			this->d23->TabIndex = 35;
			this->d23->Text = L"23";
			// 
			// d22
			// 
			this->d22->AutoSize = true;
			this->d22->Location = System::Drawing::Point(198, 354);
			this->d22->Name = L"d22";
			this->d22->Size = System::Drawing::Size(19, 13);
			this->d22->TabIndex = 36;
			this->d22->Text = L"22";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->AutoSize = true;
			this->BackColor = System::Drawing::SystemColors::ScrollBar;
			this->ClientSize = System::Drawing::Size(1142, 857);
			this->Controls->Add(this->d22);
			this->Controls->Add(this->d23);
			this->Controls->Add(this->d24);
			this->Controls->Add(this->d19);
			this->Controls->Add(this->d20);
			this->Controls->Add(this->d21);
			this->Controls->Add(this->d18);
			this->Controls->Add(this->d17);
			this->Controls->Add(this->d16);
			this->Controls->Add(this->d15);
			this->Controls->Add(this->d14);
			this->Controls->Add(this->d13);
			this->Controls->Add(this->d12);
			this->Controls->Add(this->d11);
			this->Controls->Add(this->d10);
			this->Controls->Add(this->d9);
			this->Controls->Add(this->d8);
			this->Controls->Add(this->d7);
			this->Controls->Add(this->d6);
			this->Controls->Add(this->d5);
			this->Controls->Add(this->d4);
			this->Controls->Add(this->d3);
			this->Controls->Add(this->d2);
			this->Controls->Add(this->d1);
			this->Controls->Add(this->pictureBox1);
			this->Controls->Add(this->groupBox1);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->button1);
			this->Margin = System::Windows::Forms::Padding(2);
			this->Name = L"MyForm";
			this->StartPosition = System::Windows::Forms::FormStartPosition::CenterScreen;
			this->Text = L"MyForm";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->MouseClick += gcnew System::Windows::Forms::MouseEventHandler(this, &MyForm::MyForm_MouseClick);
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void timer1_Tick(System::Object^ sender, System::EventArgs^ e) {
	}
	private: System::Void MyForm_MouseClick(System::Object^ sender, System::Windows::Forms::MouseEventArgs^ e) {

		
	/*	general->DibujarGrafo(this->CreateGraphics(), e->X, e->Y);
		cantGrafos++;
		this->dataGridView1->RowCount = Double::Parse(textBox1->Text)+1;
		this->dataGridView1->AllowUserToResizeColumns = Double::Parse(textBox1->Text);

	
		grafos->push_back(*general);*/
		
		
	}
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		

		
		/*for (int i = 0; i < dataGridView1->Rows->Count-1; i++)
		{

        // Draw rectangle to screen.
			int origen, destino, peso;
			
			
			//this->dataGridView1->Rows[i]->Cells[0];
			

		}
		for (int i = 0; i < grafos->size(); i++)
		{
			Pen^ redBlack = gcnew Pen(Color::Black, 3.0f);
			//cout << grafos[i]<<"  "<< grafos->at(i).GetX();
			this->CreateGraphics()->DrawLine(redBlack, grafos->at(i).GetX(), grafos->at(i).GetY(), grafos->at(i).GetX()+(50*Convert::ToInt32(dataGridView1->Rows[i]->Cells[2]->Value->ToString())), grafos->at(i).GetY()+(50*Convert::ToInt32(dataGridView1->Rows[i]->Cells[2]->Value->ToString())));
		
		}
		*/
	}

private: System::Void label1_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void textBox1_TextChanged(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void dataGridView1_CellContentClick(System::Object^ sender, System::Windows::Forms::DataGridViewCellEventArgs^ e) {
}
private: System::Void MyForm_Load(System::Object^ sender, System::EventArgs^ e) {
}	
private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {

	if (textBox2->Text=="" || textBox3->Text=="")
	{
		label4->Text =  "Ingrese un\n numero";
	}
	if (textBox2->Text == "0" || textBox3->Text == "0" || Double::Parse(textBox2->Text) - 1 >= 25|| Double::Parse(textBox3->Text) - 1>=25)
	{
		label4->Text = "Ingrese un numero \n mayor que 0 \ny menor que 25";
	}
	else
	{
	int inicial, final, rspt;
	inicial = Double::Parse(textBox2->Text)-1;
	final = Double::Parse(textBox3->Text)-1;
	rspt = algoritmoSample(inicial, final, *general);
	cout << rspt;
	label4->Text = rspt + "";
	}

}
private: System::Void label4_Click(System::Object^ sender, System::EventArgs^ e) {
	

}
private: System::Void textBox2_TextChanged(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void groupBox1_Enter(System::Object^ sender, System::EventArgs^ e) {
}
};
}
