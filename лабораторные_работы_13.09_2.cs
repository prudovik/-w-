/* 2
Даны две переменные, необходимо вывести значение минимальной из них. */

using System;
class Zadachadva {
  static void Main() {
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int minimalnoe = (a + b - Math.Abs(a-b))/2;
    Console.WriteLine(minimalnoe);
  }
}
