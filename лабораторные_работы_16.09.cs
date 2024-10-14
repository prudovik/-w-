/* 1
Дана последовательность из n элементов. Определить количество элементов
меньше нуля. */
/*
using System;
class Zadachaodin {
  static void Main() {
      int n = Convert.ToInt32(Console.ReadLine()), kolvo = 0;
    Console.WriteLine(kolvo);
  }
}
*/

/* 2
Определить среди элементов второй максимальный элемент. */
/*
using System;
class Zadachadva {
  static void Main() {
      int a = Convert.ToInt32(Console.ReadLine()), ma = 0, n, ma2 = 0;
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
*/

/* 3
Определить количество элементов, являющихся локальными минимумами. */
/*
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
*/
