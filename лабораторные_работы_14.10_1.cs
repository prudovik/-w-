/* 1
Дан массив из n элементов. Определить, все ли элементы
расположены в порядке возрастания. */

using System;
class Zadachaodin {
  static void Main() {
      int n = Convert.ToInt32(Console.ReadLine());
      int[] m = new int[n];
      int c = 0;
      for(int i = 0; i < n; i++){
          m[i] = Convert.ToInt32(Console.ReadLine());
          if(i != 0) {
              if(m[i] <= m[i-1]) c++;
          }
      }
      if(c != 0) Console.WriteLine("Нет");
      else Console.WriteLine("Да");
  }
}




