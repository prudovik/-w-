/* 2
Определить количество элементов, значение которых оканчивается
на тройку. */

using System;
class Zadachadva {
  static void Main() {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] m = new int[n];
      int kolvo = 0;
      for(int i = 0; i < n; i++){
          m[i] = Convert.ToInt32(Console.ReadLine());
          if(Math.Abs(m[i])%10==3) kolvo += 1;
      }
      Console.WriteLine(kolvo);
  }
}



