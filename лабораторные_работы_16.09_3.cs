/* 3
Определить количество элементов, являющихся локальными минимумами. */

using System;
class Zadachatri {
  static void Main() {
      int a = Convert.ToInt32(Console.ReadLine()), kolvo = 0, n1, n2, n3;
      n1 = Convert.ToInt32(Console.ReadLine());
      n2 = Convert.ToInt32(Console.ReadLine());
      for(int i = 1; i < a-1; i++){
          n3 = Convert.ToInt32(Console.ReadLine());
          if(n2 < n1){
              if(n2 < n3) kolvo += 1;
          }
          n1 = n2;
          n2 = n3;
      }
    Console.WriteLine(kolvo);
  }
}

