/* 1
Дан массив из трех массивов. Определить количество нечетных
элементов в каждой его строке. */

using System;
class Zadacha {
    static int[] Massiv(int n){
        int[] m = new int[n];
        for(int i = 0; i < n; i++) {
            m[i] = Convert.ToInt32(Console.ReadLine());
        }
        return m;
    }
    static int KolvoNech(int[] k){
        int kolvo = 0;
        for(int i = 0; i < k.Length; i++){
            if(k[i] % 2 != 0) kolvo += 1;
        }
        return kolvo;
    }
  static void Main() {
    int[][] massiv = new int[3][];
    int a = Convert.ToInt32(Console.ReadLine());
    massiv[0] = Massiv(a);
    int b = Convert.ToInt32(Console.ReadLine());
    massiv[1] = Massiv(b);
    int c = Convert.ToInt32(Console.ReadLine());
    massiv[2] = Massiv(c);
    Console.WriteLine("Количество нечетных в первой строке: " + KolvoNech(massiv[0]));
    Console.WriteLine("Количество нечетных во второй строке: " + KolvoNech(massiv[1]));
    Console.WriteLine("Количество нечетных в третьей строке: " + KolvoNech(massiv[2]));
  }
}