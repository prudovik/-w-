/* Форд Фалкерсон */

using System;
using System.Collections.Generic;

class Program {
   static bool BFS(int[,] residualGraph, int source, int sink, int[] parent, int n) {
        bool[] visited = new bool[n];
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(source);
        visited[source] = true;
        while (queue.Count != 0) {
            int u = queue.Dequeue();
            for (int v = 0; v < n; v++) {
                if (!visited[v] && residualGraph[u, v] > 0) {
                    queue.Enqueue(v);
                    visited[v] = true;
                    parent[v] = u;
                    if (v == sink) return true;
                }
            }
        }
        return false;
    }
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] m = new int[n,n];
    for(int i = 0; i < n; i++) {
        for(int j = 0; j < n; j++) {
            if(i == j) m[i,j] = 0;
            else {
                Console.Write($"Дуга между {i} и {j} (0 если нет): ");
                m[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    Console.Write("Исток: "); int source = Convert.ToInt32(Console.ReadLine());
    Console.Write("Сток: "); int sink = Convert.ToInt32(Console.ReadLine());
    int maxflow = 0;
    int[] parent = new int[n];
    int[,] resg = new int[n, n];
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
            resg[i, j] = m[i, j];
        }
    }
    while(BFS(resg, source, sink, parent, n)) {
        int flow = int.MaxValue;
        for (int i = sink; i != source; i = parent[i]) {
            int j = parent[i];
            flow = Math.Min(flow, resg[j,i]);
        }
        for (int i = sink; i != source; i = parent[i]) {
            int j = parent[i];
            resg[j, i] -= flow;
            resg[i, j] += flow;
        }
        maxflow += flow;
    }
    Console.WriteLine($"Максимальный поток равен {maxflow}");
  }
}








