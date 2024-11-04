/* 1
Даны три массива размерностью n, m, p. В каждом массиве определить: 1) сумму
элементов, кратных трем; 2) произведение нечетных элементов; 3) количество
нулевых элементов. */

using System;
class Zadachi {
    static int[] Massiv(int a) {
        int[] massiv = new int[a];
        for(int i = 0; i < a; i++) {
            massiv[i] = Convert.ToInt32(Console.ReadLine());
        }
        return massiv;
    }
    static int SummaEl(int[] n) {
        int summa = 0;
        for(int i = 0; i < n.Length; i++) {
            if(n[i] % 3 == 0) summa += n[i];
        }
        return summa;
    }
    static int ProizvEl(int[] n) {
        int proizv = 1;
        for(int i = 0; i < n.Length; i++) {
            if(n[i] % 2 != 0) proizv *= n[i];
        }
        return proizv;
    }
    static int Noliki(int[] n) {
        int kolvo = 0;
        for(int i = 0; i < n.Length; i++) {
            if(n[i] == 0) kolvo += 1;
        }
        return kolvo;
    }
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine()), m, p;
    int[] massiv = Massiv(n);
    Console.WriteLine("Сумма: " + SummaEl(massiv));
    Console.WriteLine("Произведение: " + ProizvEl(massiv));
    Console.WriteLine("Количество: " + Noliki(massiv));
    m = Convert.ToInt32(Console.ReadLine());
    massiv = Massiv(m);
    Console.WriteLine("Сумма: " + SummaEl(massiv));
    Console.WriteLine("Произведение: " + ProizvEl(massiv));
    Console.WriteLine("Количество: " + Noliki(massiv));
    p = Convert.ToInt32(Console.ReadLine());
    massiv = Massiv(p);
    Console.WriteLine("Сумма: " + SummaEl(massiv));
    Console.WriteLine("Произведение: " + ProizvEl(massiv));
    Console.WriteLine("Количество: " + Noliki(massiv));
  }
}