/* 1 */
/* На вход подаются две переменные. Необходимо поменять их значения
местами, не используя третью. */
/*
using System;
class Zadachaodin {
  static void Main() {
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    a += b;
    b = a - b;
    a -= b;
    Console.WriteLine(a);
    Console.WriteLine(b);
  }
}
*/

/* 2
Даны две переменные, необходимо вывести значение минимальной из них. */
/*
using System;
class Zadachadva {
  static void Main() {
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int minimalnoe = (a + b - Math.Abs(a-b))/2;
    Console.WriteLine(minimalnoe);
  }
}
*/
/* 3
Есть n грядок размером l в ширину и m в высоту. Расстояние от колодца
до первой грядки - k. Необходимо определить длину пути обхода всех грядок. */

using System;
class Zadachatri {
    static void Main() {
        int n, l, m, k, a;
        n = Convert.ToInt32(Console.ReadLine());
        l = Convert.ToInt32(Console.ReadLine());
        m = Convert.ToInt32(Console.ReadLine());
        k = Convert.ToInt32(Console.ReadLine());
        a = 2*n*(m+l) + 2*n*k + n*m*(n-1);
        Console.WriteLine(a);
    }
}