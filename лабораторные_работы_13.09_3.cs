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