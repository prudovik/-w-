/* 3
Дана последовательность. Определить максимальную сумму подпоследовательностей
из четных чисел. */

using System;
class Zadachatri {
  static void Main() {
      int n, a1, summam = -1000000, summa = 0;
      n = Convert.ToInt32(Console.ReadLine());
      for(int i = 0; i < n; i++) {
          a1 = Convert.ToInt32(Console.ReadLine());
          if(a1 % 2 == 0) {
              summa += a1;
              
          }
          else {
              if(summam < summa) summam = summa;
              summa = 0;
          }
      }
      if((summa != 0) && (summam < summa)) summam = summa;
    Console.WriteLine(summam);
  }
}




