/* 2
Определить среди элементов второй максимальный элемент. */

using System;
class Zadachadva {
  static void Main() {
      int a = Convert.ToInt32(Console.ReadLine()), ma = -100000, n, ma2 = -100000;
      for(int i = 1; i <= a; i++) {
          n = Convert.ToInt32(Console.ReadLine());
          if (n > ma) {
              ma2 = ma;
              ma = n;
          }
      }
    Console.WriteLine(ma2);
  }
}

