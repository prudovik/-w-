/* 3
Для каждого элемента найти сумму цифр. */

using System;
class Zadachatri {
  static void Main() {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] m = new int[n];
      int summa = 0, a;
      for(int i = 0; i < n; i++){
          m[i] = Convert.ToInt32(Console.ReadLine());
          a = Math.Abs(m[i]);
          while(a > 0) {
              summa += a%10;
              a /= 10;
          }
          Console.WriteLine(summa);
          summa = 0;
      }
  }
}


