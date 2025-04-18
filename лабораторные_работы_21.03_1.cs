/* 1
Есть класс машины, в котором имеются поля год выпуска, марка и чистота.
Есть класс гараж, хранящий список объектов класса машины. Есть класс мойка, в котором реализуется
метод помывки машины. Необходимо реализовать помывку машин с помощью делегата. */

using System;
using System.Collections.Generic;
delegate void Cleaning(Cars a);
class Cars {
    private string _name;
    private string _year;
    private bool _clean;
    public string Name {
        get => _name;
        set => _name = value;
    }
    public string Year {
        get => _year;
        set => _year = value;
    }
    public bool Clean {
        get => _clean;
        set => _clean = value;
    }
}

class Garage {
    private List<Cars> _list;
    public List<Cars> list {
        get => _list;
        set => _list = value;
    }
    public void AddCar(Cars car) {
        list.Add(car);
    }
}
class Cleaner {
    public void Clear(Cars a) {
        if(a.Clean == false) { a.Clean = true; Console.WriteLine("Машина вымыта"); }
        else Console.WriteLine("Машина уже чистая, мойка не нужна");
    }
}
class Program {
  static void Main() {
    Cleaner a = new Cleaner();
    Cleaning cleaner = a.Clear;
    Garage garage = new Garage();
    List<Cars> list1 = new List<Cars>();
    garage.list = list1;
    Console.Write("Кол-во машин: ");
    int n = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < n; i++) {
        Cars c = new Cars();
        Console.Write("Введите название машины: ");
        string k = Console.ReadLine();
        Console.Write("Введите год выпуска машины: ");
        string l = Console.ReadLine();
        Console.Write("Выберите состояние машины - 1) Чистая, 0) Грязная: ");
        int m = Convert.ToInt32(Console.ReadLine());
        c.Name = k; c.Year = l;
        if(m == 1) c.Clean = true; else c.Clean = false;
        garage.AddCar(c);
    }
    for(int i = 0; i < n; i++) {
        Console.Write($"Машина {i+1}: ");
        cleaner(garage.list[i]);
    }
  }
}






