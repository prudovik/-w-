/* 4
Определить среднее арифметическое четных элементов массива. */

using System;
class Zadachachetyre {
  static void Main() {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] m = new int[n];
      double kolvo = 0, summa = 0, srarifm = 0;
      for(int i = 0; i < n; i++){
          m[i] = Convert.ToInt32(Console.ReadLine());
          if(m[i]%2==0) {
              kolvo += 1;
              summa += m[i];
          }
      }
      if(kolvo > 0) srarifm = summa / kolvo;
      Console.WriteLine(srarifm);
  }
}

