/* 2
Дана последовательность. Определить минимальную длину подпоследовательности,
состоящей из нулей. */

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



