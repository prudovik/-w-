/* 1 (2)
Описать класс Поезд, содержащий поля название пункта назначения, номер поезда,
время отправления. Описать класс Станция, содержащий поля название станции,
список поездов, проходящих через станцию. Написать программу, осуществляющую
ввод данных класса Поезд и вывод информации о поездах, отправляющихся после
введенного времени (через меню) */

using System;
class Poezd {
    private string _punkt;
    private int _nomer;
    private string _vremya; /* Формат - чч:мм */
    public string Punkt {
        get => _punkt;
        set => _punkt = value;
    }
    public int Nomer {
        get => _nomer;
        set => _nomer = value;
    }
    public string Vremya {
        get => _vremya;
        set => _vremya = value;
    }
}
class Stanciya : Poezd {
    private string _nazvanie;
    private Poezd[] _spisok;
    public string Nazvanie {
        get => _nazvanie;
        set => _nazvanie = value;
    }
    public Poezd[] Spisok {
        get => _spisok;
        set => _spisok = value;
    }
}
class Program {
    static Poezd[] Zapolnenie(int n) {
        Poezd[] massiv = new Poezd[n];
        for(int i = 0; i < n; i++) {
            int k = i + 1;
            Console.Write($"Введите пункт назначения поезда {k}: ");
            string a = Console.ReadLine();
            Console.Write($"Введите номер поезда {k}: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите время отправления поезда {k}: ");
            string c = Console.ReadLine();
            massiv[i] = new Poezd();
            massiv[i].Punkt = a; massiv[i].Nomer = b; massiv[i].Vremya = c;
        }
        return massiv;
    }
  static void Main() {
      int vybor = 0;
      Poezd[] m = new Poezd[1];
      bool check1 = true;
      while(vybor != 3) {
          Console.WriteLine("Меню");
          Console.WriteLine("1. Ввод данных о поездах");
          Console.WriteLine("2. Вывод поездов, отправляющихся после заданного времени");
          Console.WriteLine("3. Выход");
          vybor = Convert.ToInt32(Console.ReadLine());
          switch (vybor) {
              case 3: break;
              case 1:
                Console.Write("Введите количество поездов: ");
                int n = Convert.ToInt32(Console.ReadLine());
                m = Zapolnenie(n);
                check1 = false;
                break;
              case 2:
                bool check = true;
                if(check1 == false) {
                    Console.Write("Введите время: ");
                    string v1 = Console.ReadLine();
                    TimeOnly v = new TimeOnly(Convert.ToInt32(v1.Substring(0, 2)), Convert.ToInt32(v1.Substring(3)));
                    for(int i = 0; i < m.Length; i++) {
                        TimeOnly mv = new TimeOnly(Convert.ToInt32(m[i].Vremya.Substring(0, 2)), Convert.ToInt32(m[i].Vremya.Substring(3)));
                        if(mv > v) {
                            check = false;
                            Console.WriteLine($"{m[i].Punkt}, {m[i].Nomer}, {m[i].Vremya}");
                        }
                    }
                  if(check) Console.WriteLine($"Нет поездов, отправляющихся после {v}");
                  break;}
                else {Console.WriteLine("Введите данные о поездах"); break;}
          }
      }
  }
}