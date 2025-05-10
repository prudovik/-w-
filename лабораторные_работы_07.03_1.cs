/* 1 
Дан список из экземпляров класса телефон, где каждая запись характеризуется
номером, ФИО владельца и оператором подключения. Необходимо с помощью
элемента коллекции словарь определить частоту использования оператора связи. */

using System;
using System.Collections.Generic;
class Phone {
    private string _number;
    private string _name;
    private string _oper;
    public string Name {
        get => _name;
        set => _name = value;
    }
    public string Number {
        get => _number;
        set => _number = value;
    }
    public string Oper {
        get => _oper;
        set => _oper = value;
    }
}
class Program {
  static void Main() {
    List<Phone> list = new List<Phone>();
    Console.Write("Введите количество телефонов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < n; i++) {
        Console.Write($"Введите номер {i+1}: ");
        string a = Console.ReadLine();
        Console.Write($"Введите ФИО {i+1}: ");
        string b = Console.ReadLine();
        Console.Write($"Введите оператора {i+1}: ");
        string c = Console.ReadLine();
        Phone p = new Phone();
        p.Name = b; p.Number = a; p.Oper = c;
        list.Add(p);
    }
    Dictionary<string, int> dict = new Dictionary<string, int>();
    for(int i = 0; i < list.Count; i++) {
        if(!(dict.ContainsKey(list[i].Oper))) dict[list[i].Oper] = 1;
        else dict[list[i].Oper]++;
    }
    foreach(var a in dict) {
        Console.WriteLine($"{a.Key} встречается {a.Value} раз");
    }
  }
}








