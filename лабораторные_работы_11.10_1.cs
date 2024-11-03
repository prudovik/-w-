/* 1
Дана последовательность целых положительных элементов. Необходимо
каждое числовое значение последовательности перевернуть и удалить
все нечетные цифры в элементе. */

using System;
class Zadacha {
    static void Main() {
        int a = Convert.ToInt32(Console.ReadLine()), k, chislo = 0, chet = 0;
        while(a > 0) {
            k = a;
            while(k > 0){
                if ((k % 10) % 2 == 0) {
                    chet += 1;
                    chislo = chislo*10 + k%10;
                }
                k /= 10;
            }
            if(chet == 0) Console.WriteLine("Не было четных цифр");
            else Console.WriteLine(chislo);
            chislo = 0;
            chet = 0;
            a = Convert.ToInt32(Console.ReadLine());
        }
    }
}



