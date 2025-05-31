

/* Алгоритм Прима */

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
        for (int i = 0; i < n - 1; i++){
            Console.WriteLine($"({MST[i].V1}, {MST[i].V2}) = {MST[i].Weight}");
        }
    }
}







