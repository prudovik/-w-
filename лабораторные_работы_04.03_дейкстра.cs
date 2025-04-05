/* Алгоритм Дейкстры */

using System;
using System.Collections.Generic;
class Program {
    static double[,] Matrix(int n) {
        double[,] m = new double[n,n];
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < n; j++) {
                if(i == j) m[i,j] = double.PositiveInfinity;
                else {
                    Console.Write($"Дуга между {i} и {j} (0 если нет): ");
                    m[i,j] = Convert.ToDouble(Console.ReadLine());
                    if(m[i,j] == 0) m[i,j] = double.PositiveInfinity;
                }
            }
        }
        return m;
    }
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] m = Matrix(n);
    Console.Write("Начальная вершина: "); int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Конечная вершина: "); int b = Convert.ToInt32(Console.ReadLine());
    double[,] c = new double[n,n+1];
    for(int j = 0; j < n; j++) {
        c[0,j] = double.PositiveInfinity;
    }
    c[0,a] = 0;
    c[0,n] = a;
    List<int> p = new List<int>();
    p.Add(a);
    double way = 0;

        for(int i = 1; i < n; i++) {
            for(int j = 0; j < n; j++) {
                if(p.Contains(j)) continue;
                else {
                    c[i,j] = Math.Min(c[i-1,j], m[Convert.ToInt32(c[i-1,n]),j]+c[i-1,Convert.ToInt32(c[i-1,n])]);
                }
            }
            double min = double.PositiveInfinity;
            int ind = 0;
            for(int j = 0; j<n; j++) {
                if(c[i,j] < min && c[i,j] != 0) {
                    min = c[i,j];
                    ind = j;
                } 
            }
            c[i,n] = ind;
            way = min;
            p.Add(ind);
            if(ind == b) break;
        }

    Console.WriteLine(way);
  }
}

