/* Алгоритм Крускала */

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
        if(e == null) return 1;
        else if(Weight > e.Weight) return 1;
        else if(Weight == e.Weight) return 0;
        else return -1;
    }
}
class Program {
    static void Main() {
        Console.Write("Кол-во вершин в графе: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] m = new int[n,n];
        List<Edge> list = new List<Edge>();
        for(int i = 0; i < n; i++) {
            for(int j = 0; j <= i; j++) {
                if(i == j) m[i,j] = 0;
                else {
                    Console.WriteLine($"Вес ребра между {i} и {j} (0 если нету):");
                    m[i,j] = Convert.ToInt32(Console.ReadLine());
                    m[j,i] = m[i,j];
                    if(m[i,j] != 0) {
                        Edge edge = new Edge(i, j, m[i,j]);
                        list.Add(edge);
                    }
                }
            }
        }
        list.Sort();
        List<Edge> MST = new List<Edge>();
        int[] mst = new int[n];
        for(int i = 0; i < n; i++) {
            mst[i] = 0;
        }
        int t = 1;
        for(int i = 0; i < list.Count; i++) {
            if((mst[list[i].V1] == 0) && (mst[list[i].V2] == 0)) {
                mst[list[i].V1] = t;
                mst[list[i].V2] = t;
                t++;
                MST.Add(list[i]);
            }
            else if((mst[list[i].V1] != 0) && (mst[list[i].V2] != 0) && (mst[list[i].V1] == mst[list[i].V2])) {
                continue;
            }
            else if((mst[list[i].V1] != 0) && (mst[list[i].V2] != 0) && (mst[list[i].V1] > mst[list[i].V2])) {
                int aaa = mst[list[i].V1];
                for(int k = 0; k < n; k++) {
                    if(mst[k] == aaa) mst[k] = mst[list[i].V2];
                }
                MST.Add(list[i]);
            }
            else if(((mst[list[i].V1] != 0) && (mst[list[i].V2] != 0) && mst[list[i].V1] < mst[list[i].V2])) {
                int aaa = mst[list[i].V2];
                for(int k = 0; k < n; k++) {
                    if(mst[k] == aaa) mst[k] = mst[list[i].V1];
                }
                MST.Add(list[i]);
            }
            else if((mst[list[i].V1] == 0) && (mst[list[i].V2] != 0)) {
                mst[list[i].V1] = mst[list[i].V2];
                MST.Add(list[i]);
            }
            else if((mst[list[i].V2] == 0) && (mst[list[i].V1] != 0)) {
                mst[list[i].V2] = mst[list[i].V1];
                MST.Add(list[i]);
            }
            if(MST.Count == n-1) break;
        }
        for(int i = 0; i < n-1; i++) {
            Console.WriteLine($"({MST[i].V1}, {MST[i].V2}) = {MST[i].Weight}");
        }
  }
}







