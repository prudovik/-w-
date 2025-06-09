
/* Алгоритм 2 */

using System;
using System.Collections.Generic;
class Program {
    static int[,] Matrix(int n) {
        int[,] m = new int[n,n];
        for(int i = 0; i < n; i++) {
            for(int j = 0; j <= i; j++) {
                if(i == j) m[i,j] = 0;
                else {
                    Console.WriteLine($"Ребро между {i} и {j}:");
                    m[i,j] = Convert.ToInt32(Console.ReadLine());
                    m[j,i] = m[i,j];
                }
            }
        }
        return m;
    }
    
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] m = Matrix(n);
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
                if (m[currentVertex, j] == 1 && points.Contains(j)) {
                    currentComponent.Add(j);
                    points.Remove(j);
                }
            }
            ind++;
        }
        components.Add(currentComponent);
    }
    Console.WriteLine($"Всего компонент связности: {components.Count}");
    for (int i = 0; i < components.Count; i++) {
        Console.WriteLine($"Компонента связности {i + 1}: {string.Join(", ", components[i])}");
    }
  }
}




