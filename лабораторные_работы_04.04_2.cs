/* 2
Дан список, состоящий из слов. Необходимо с помощью лямбда-выражений реализовать выборку слов,
которые начинаются на символ а. */

using System;
using System.Collections.Generic;
delegate void Words(List<string> l);
class Program {
    static void Main() {
        List<string> list = new List<string>();
        Console.Write("Введите количество слов в списке: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++) {
            Console.Write($"Введите слово {i+1}: ");
            string a = Console.ReadLine();
            list.Add(a);
        }
        Words words = l => {
            Console.Write("Список слов, начинающихся на a (латинскую): ");
            foreach(string a in l) if(a[0] == 'a') Console.Write($"{a} ");
        };
        words(list);
    }
}

