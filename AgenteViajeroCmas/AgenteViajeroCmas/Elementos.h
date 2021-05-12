#pragma once
#include<iostream>
#include<vector>
#include <queue>
using namespace System;
using namespace System::Drawing;
#define MAXV 100 // Maxima cantidad de vertices.
#define oo 0x3f3f3f3f // Nuestro valor infinito.
using namespace std;

class Distancia
{
public:
	int nodo; // El nodo destino de la arista.
	int costo; // El costoo de la arista.
	vector<int> last;
	Distancia(int _nodo, int _costo)  {
		nodo = _nodo; costo = _costo;
		last.push_back(_nodo);
	} // Constructor parametrizado.
	Distancia() : nodo(-1), costo(-1) {} // Constructor por defecto.

	void dibujarDistancias()
	{

	}
};

class Grafo
{
private:
	int x, y;
public:
	
	vector<Distancia> G[MAXV]; // Lista de adyacencias.
	int V; // Cantidad de vertices.
	int E; // Cantidad de aristas.
	
	void SetX(int n)
	{
		x = n;
	}
	int GetX()
	{
		return x;
	}

	void SetY(int n)
	{
		y = n;
	}
	int GetY()
	{
		return y;

	}
	void DibujarGrafo(Graphics^ grafico, int x, int y)
	{
		grafico->FillEllipse(Brushes::BlueViolet, x, y, 50, 50);
		//grafico->DrawEllipse(gcnew Pen(Color::AliceBlue, 3), x, y, 70, 70);
	}
};

class State
{
public:
	int nodo; // El nodo actual.
	int costo; // El costoo del camino.
	/*vector<int> c;*/
	State(int _nodo, int _costo)  {
		nodo = _nodo; costo = _costo;
		
	} // Constructor parametrizado.
	bool operator <(const State& b) const // Sobrecarga del operador de prioridad <.
	{
		return costo > b.costo;
	}
	/*void addcamino() {
		c.push_back(nodo);
	}*/
	/*int getcamino() {
		
		
	}*/
};