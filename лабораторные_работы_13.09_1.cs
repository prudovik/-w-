/* 1 */
/* На вход подаются две переменные. Необходимо поменять их значения
местами, не используя третью. */

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
