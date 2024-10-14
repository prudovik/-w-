/* 1
Дана последовательность. Определить максимальный размер
подпоследовательности, состоящей из одинаковых элементов. */
/*
using System;
class Zadachaodin {
  static void Main() {
      int razm = 0, n, a1, a2, raz = 1;
      n = Convert.ToInt32(Console.ReadLine());
      a1 = Convert.ToInt32(Console.ReadLine());
      for(int i = 1; i < n; i++) {
          a2 = Convert.ToInt32(Console.ReadLine());
          if(a2 == a1) {
              raz += 1;
              if(raz > razm) razm = raz;
              a1 = a2;
          }
          else {
              if(raz > razm) razm = raz;
              raz = 1;
              a1 = a2;
          }
      }
    Console.WriteLine(razm);
  }
}
*/

/* 2
Дана последовательность. Определить минимальную длину подпоследовательности,
состоящей из нулей. */
/* 
using System;
class Zadachadva {
  static void Main() {
      int razm = 10000, n, a1, raz = 0;
      n = Convert.ToInt32(Console.ReadLine());
      for(int i = 0; i < n; i++) {
          a1 = Convert.ToInt32(Console.ReadLine());
          if(a1 == 0) {
              raz += 1;
          }
          else {
              if((raz < razm) && (raz != 0)) razm = raz;
              raz = 0;
          }
      }
      if(razm == 10000) razm = 0;
      if((raz != 0) && (raz < razm)) razm = raz;
    Console.WriteLine(razm);
  }
}
*/

/* 3
Дана последовательность. Определить максимальную сумму подпоследовательностей
из четных чисел. */
/*
using System;
class Zadachatri {
  static void Main() {
      int n, a1, summam = -10000, summa = 0;
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
*/