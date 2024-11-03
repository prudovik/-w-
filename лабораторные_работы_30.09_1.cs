/* 1
Дана последовательность. Определить максимальный размер
подпоследовательности, состоящей из одинаковых элементов. */

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

