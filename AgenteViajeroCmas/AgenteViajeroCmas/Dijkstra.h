#pragma once

#include <queue>




/*
struct Programa
{







	int V, E;
	int comienzo, fin;
	void definirGrafo(Grafo& graph)
	{
		cout << "Ingrese Cantidad de Vertices: " << endl;
		cin >> V;
		cout << "Ingrese Cantidad de Aristas: " << endl;
		cin >> E;

		graph.V = V;
		graph.E = E;
	}
	void cargarGrafo(Grafo& graph)
	{
		for (int i = 0; i < E; ++i)
		{
			int Origen, Destino, Peso;
			cout << "Ingrese Origen: " << endl;
			cin >> Origen;
			cout << "Ingrese Destino: " << endl;
			cin >> Destino;
			cout << "Ingrese Peso de la Arista: " << endl;
			cin >> Peso;

			// Insertamos la arista dos veces, ya que nuestro grafo es un grafo no dirigido.
			graph.G[Origen].push_back(Distancia(Destino, Peso));
			graph.G[Destino].push_back(Distancia(Origen, Peso));
		}
	}
	/*void Dijkstra(Grafo graph)
	{
		cout << "Ingrese Vertice Inicial: " << endl;
		cin >> comienzo;
		cout << "Ingrese Vertice Final: " << endl;
		cin >> fin;
		int n = algoritmoSample(comienzo, fin, graph);
		cout << "Longitud del Camino mas Corto: " << n << endl;
	
	}
};
*/