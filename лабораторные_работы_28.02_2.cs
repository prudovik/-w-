/* 2
На вход подается список из целых положительных элементов. Необходимо
выдать элементы, с помощью которых составлен список, и частоту появления
каждого элемента. */

using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        List<int> list = new List<int>();
        Console.Write("Введите количество элементов списка: ");
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < n; i++) {
            Console.Write($"Введите элемент {i+1}: ");
            int a = Convert.ToInt32(Console.ReadLine());
            list.Add(a);
        }
        list.Sort();
        /* задание 1
        HashSet<int> set = new HashSet<int>();
        foreach(int i in list) set.Add(i);
        foreach(int i in set) Console.Write($"{i} ");
        Console.WriteLine("- элементы, составляющие список.");
        /* задание 2 
        foreach(int a in set) {
            int count = 0;
            foreach(int b in list) {
                if(a == b) count += 1;
            }
            Console.WriteLine($"Количество появлений {a}: {count}");
        }
  }
}
