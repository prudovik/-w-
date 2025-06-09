/* Алгоритм Форда-Беллмана */

using System;
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
       double[] c = new double[n];
    for(int j = 0; j < n; j++) {
        c[j] = double.PositiveInfinity;
    }
    c[a] = 0;
    for (int i = 0; i < n - 1; i++) {
        for (int j = 0; j < n; j++) {
            for (int k = 0; k < n; k++) {
                if (m[j, k] != 0 && c[j] != double.PositiveInfinity && c[j] + m[j, k] < c[k]) {
                    c[k] = c[j] + m[j, k];
                }
            }
        }
    }
    for(int i = 0; i < n; i++) {
        if(i != a) Console.WriteLine($"Расстояние от {a} до {i} = {c[i]}");
    }
  }
}





