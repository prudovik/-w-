/* 1
Дан массив из n элементов. Определить, все ли элементы
расположены в порядке возрастания. */
/*
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
*/

/* 2
Определить количество элементов, значение которых оканчивается
на тройку. */
/*
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
*/

 
/* 3
Для каждого элемента найти сумму цифр. */
/* 
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
*/

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


