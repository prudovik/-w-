/* Найти ребра, являющиеся мостами. */

using System;
using System.Collections.Generic;

class Edge : IComparable<Edge> {
    public int Weight { get; set; }
    public int V1 { get; set; }
    public int V2 { get; set; }
    public Edge(int a, int b, int c) {
        Weight = c;
        V1 = a;
        V2 = b;
    }
    public int CompareTo(Edge e) {
        if (e == null) return 1;
        else if (Weight > e.Weight) return 1;
        else if (Weight == e.Weight) return 0;
        else return -1;
    }
}

class Program {
    static void Main() {
        Console.Write("Кол-во вершин в графе: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] m = new int[n, n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j <= i; j++) {
                if (i == j) m[i, j] = 0;
                else {
                    Console.WriteLine($"Вес ребра между {i} и {j} (0 если нету):");
                    m[i, j] = Convert.ToInt32(Console.ReadLine());
                    m[j, i] = m[i, j];
                }
            }
        }
        List<int> column = new List<int>();
        for (int i = 1; i < n; i++) {
            column.Add(i);
        }
        List<int> line = new List<int>();
        List<Edge> MST = new List<Edge>();
        line.Add(0);
        while (MST.Count != n - 1) {
            int inda = -1;
            int indb = -1;
            int min = 1000000;
            for (int i = 0; i < line.Count; i++) {
                for (int j = 0; j < column.Count; j++) {
                    if ((m[line[i], column[j]] != 0) && (m[line[i], column[j]] < min)) {
                        min = m[line[i], column[j]];
                        inda = line[i];
                        indb = column[j];
                    }
                }
            }
            line.Add(indb);
            for(int i = 0; i < column.Count; i++) {
                if (column[i] == indb) column.RemoveAt(i);
            }
            MST.Add(new Edge(inda, indb, min));
        }
        List<Edge> bridge = new List<Edge>();
        for (int p = 0; p < n - 1; p++){
            int[,] mat = new int[n,n];
            for(int i = 0; i < n; i++) {
                for(int j = 0; j <= i; j++) {
                    if(i == MST[p].V1 && j == MST[p].V2 || i == MST[p].V2 && j == MST[p].V1) {
                        mat[i,j] = 0;
                        mat[j,i] = mat[i,j];
                    }
                    else {
                        mat[i,j] = m[i,j];
                        mat[j,i] = m[j,i];
                    }
                }
            }
            List<int> points = new List<int>();
            for (int i = 0; i < n; i++) {
                points.Add(i);
            }
            List<List<int>> components = new List<List<int>>();
            while (points.Count > 0) {
                List<int> currentComponent = new List<int>();
                currentComponent.Add(points[0]);
                points.RemoveAt(0);
                int ind = 0;
                while (ind < currentComponent.Count) {
                    int currentVertex = currentComponent[ind];
                    for (int j = 0; j < n; j++) {
                        if (mat[currentVertex, j] == 1 && points.Contains(j)) {
                            currentComponent.Add(j);
                            points.Remove(j);
                        }
                    }
                    ind++;
                }
                components.Add(currentComponent);
            }
            if(components.Count > 1) bridge.Add(MST[p]);
        }
        if(bridge.Count == 0) Console.WriteLine("Нет мостов");
        else {
            Console.Write("Мосты: ");
            for(int k = 0; k < bridge.Count; k++) {
                Console.WriteLine($"({bridge[k].V1}, {bridge[k].V2})");
            }
        }
        
    }
}