/* Задача коммивояжера, алгоритм Литтла */

using System;
using System.Collections.Generic;

class Arc {
    public int V1 {get; set;}
    public int V2 {get; set;}
    public double Weight {get; set;}
    public Arc(int a, int b, double c) {
        V1 = a;
        V2 = b;
        Weight = c;
    }
}
class Program {
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] matrix = new double[n+1,n+1];
    for(int i = 1; i < n+1; i++) {
        for(int j = 1; j < n+1; j++) {
            if(i == j) matrix[i,j] = double.PositiveInfinity;
            else {
                Console.Write($"Дуга между {i} и {j} (0 если нет): ");
                matrix[i,j] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
    for(int i = 1; i < n+1; i++) {
        matrix[0,i] = i;
        matrix[i,0] = i;
    }
    matrix[0,0] = double.PositiveInfinity;
    double[,] m = new double[n+1,n+1];
    for(int j = 0; j < n+1; j++){
        for(int i = 0; i < n+1; i++){
            double aaa =  matrix[i,j];
            m[i,j] = aaa;
        }
    }
    List<Arc> coef = new List<Arc>();
    List<Arc> way = new List<Arc>();
    double reduction = 0;
    while(m.GetLength(0) > 2) {
        for(int i = 1; i < m.GetLength(0); i++) {
            double min = double.PositiveInfinity;
            for(int j = 1; j < m.GetLength(0); j++) {
                min = Math.Min(min, m[i,j]);
            }
            for(int j = 1; j < m.GetLength(0); j++) {
                if(m[i,j] != double.PositiveInfinity) m[i,j] -= min;
            }
            reduction += min;
        }
        for(int j = 1; j < m.GetLength(0); j++) {
            double min = double.PositiveInfinity;
            for(int i = 1; i < m.GetLength(0); i++) {
                min = Math.Min(min, m[i,j]);
            }
            for(int i = 1; i < m.GetLength(0); i++) {
                if(m[i,j] != double.PositiveInfinity) m[i,j] -= min;
            }
            reduction += min;
        }
        for(int i = 1; i < m.GetLength(0); i++) {
            for(int j = 1; j < m.GetLength(0); j++) {
                if(m[i,j] == 0) {
                    double min1 = double.PositiveInfinity;
                    double min2 = double.PositiveInfinity;
                    for(int k = 1; k < m.GetLength(0); k++) {
                        if(k == j) continue;
                        min1 = Math.Min(min1, m[i,k]);
                    }
                    for(int k = 1; k < m.GetLength(0); k++) {
                        if(k == i) continue;
                        min2 = Math.Min(min2, m[k,j]);
                    }
                    coef.Add(new Arc(i,j,min1+min2));
                }
            }
        }
        Arc max = new Arc(0,0,0.0);
        foreach(Arc i in coef) {
            if(i.Weight > max.Weight) max = i;
        }
        m[max.V2, max.V1] = double.PositiveInfinity;
        double[,] mat = new double[m.GetLength(0)-1,m.GetLength(0)-1];
        int i1 = 0;
        for (int i = 0; i < m.GetLength(0); i++) {
            if (i == max.V1) continue;
            int j1 = 0;
            for (int j = 0; j < m.GetLength(0); j++) {
                if (j == max.V2) continue;
                mat[i1, j1] = m[i, j];
                j1++;
            }
            i1++;
        }
        way.Add(new Arc(Convert.ToInt32(m[max.V1,0]), Convert.ToInt32(m[0,max.V2]), matrix[Convert.ToInt32(m[max.V1,0]), Convert.ToInt32(m[0,max.V2])]));
        m = new double[mat.GetLength(0),mat.GetLength(0)];
        for(int i = 0; i < mat.GetLength(0); i++){
            for(int j = 0; j < mat.GetLength(0); j++){
                double aaa =  mat[i,j];
                m[i,j] = aaa;
            }
    }
        coef.Clear();
    }
    way.Add(new Arc(Convert.ToInt32(m[1,0]), Convert.ToInt32(m[0,1]), matrix[Convert.ToInt32(m[1,0]), Convert.ToInt32(m[0,1])]));
    foreach(var i in way) {
        Console.WriteLine($"({i.V1}, {i.V2}) = {i.Weight}");
    }
    Console.WriteLine($"Путь = {reduction}");
  }
}












