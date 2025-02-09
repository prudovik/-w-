/* 1 
Дана база данных - телефонный справочник с ФИО, номером телефона (может быть
несколько у одного человека), город, оператор связи, год подключения.
Осуществить выборку по ФИО, оператору, номеру телефона. */

using System;
class Phone {
    private string _number;
    private string _city;
    private string _operator;
    private string _year;
    public string Number {
        get => _number;
        set => _number = value;
    }
    public string City {
        get => _city;
        set => _city = value;
    }
    public string Operator {
        get => _operator;
        set => _operator = value;
    }
    public string Year {
        get => _year;
        set => _year = value;
    }
}
class Person {
    private string _name;
    private Phone[] _nums;
    public string Name {
        get => _name;
        set => _name = value;
    }
    public Phone[] Nums {
        get => _nums;
        set => _nums = value;
    }
}
class Program {
    static Phone[] Massive(int n) {
        Phone[] m = new Phone[n];
        for(int i = 0; i < n; i++) {
            int k = i+1;
            Console.Write($"Введите номер телефона {k}: ");
            string number = Console.ReadLine();
            Console.Write($"Введите город {k}: ");
            string city = Console.ReadLine();
            Console.Write($"Введите оператора {k}: ");
            string oper = Console.ReadLine();
            Console.Write($"Введите год подключения {k}: ");
            string year = Console.ReadLine();
            m[i] = new Phone();
            m[i].Number = number; m[i].City = city;
            m[i].Operator = oper; m[i].Year = year;
        }
        return m;
    }
  static void Main() {
      Person[] mper = new Person[1];
      int choice = 0; bool check = true;
      while(choice != 5) {
          Console.WriteLine("1. Ввод данных");
          Console.WriteLine("2. Выборка по ФИО");
          Console.WriteLine("3. Выборка по оператору");
          Console.WriteLine("4. Выборка по номеру телефона");
          Console.WriteLine("5. Выход");
          choice = Convert.ToInt32(Console.ReadLine());
          switch (choice) {
              case 5: break;
              case 1:
                check = false;
                Console.Write("Введите количество человек: ");
                int n = Convert.ToInt32(Console.ReadLine());
                mper = new Person[n];
                for(int i = 0; i < n; i++) {
                    int k = i+1;
                    mper[i] = new Person();
                    Console.Write($"Введите ФИО человека {k}: ");
                    string name = Console.ReadLine();
                    Console.Write($"Введите количество телефонов человека {k}: ");
                    int q = Convert.ToInt32(Console.ReadLine());
                    mper[i].Name = name; mper[i].Nums = Massive(q);
                }
                break;
              case 2:
                if(check) {
                    Console.WriteLine("Введите данные");
                    break;
                }
                else {
                    Console.Write("Введите ФИО: ");
                    string vname = Console.ReadLine();
                    bool check1 = true;
                    for(int i = 0; i < mper.Length; i++) {
                        if(mper[i].Name == vname) {
                            check1 = false;
                            Console.WriteLine("Список номеров человека с этим ФИО:");
                            foreach(var k in mper[i].Nums) {
                                Console.WriteLine($"{k.Number}");
                            }
                        }
                    }
                    if(check1) Console.WriteLine("В базе данных нет человека с таким ФИО");
                    break;
                }
              case 3:
                if(check) {
                    Console.WriteLine("Введите данные");
                    break;
                }
                else {
                    Console.Write("Введите оператора: ");
                    string voper = Console.ReadLine();
                    bool check2 = true;
                    for(int i = 0; i < mper.Length; i++) {
                        foreach(var k in mper[i].Nums) {
                            if(k.Operator == voper) {
                                check2 = false;
                                Console.WriteLine($"{mper[i].Name} - {k.Number}");
                            }
                        }
                    }
                    if(check2) Console.WriteLine("В базе данных нет номеров с таким оператором");
                    break;
                }
              case 4:
                if(check) {
                    Console.WriteLine("Введите данные");
                    break;
                }
                else {
                    Console.Write("Введите номер телефона: ");
                    string vnum = Console.ReadLine();
                    bool check3 = true;
                    for(int i = 0; i < mper.Length; i++) {
                        foreach(var k in mper[i].Nums) {
                            if(k.Number == vnum) {
                                check3 = false;
                                Console.WriteLine($"Человек, которому пренадлежит этот номер - {mper[i].Name}");
                            }
                        }
                    }
                    if(check3) Console.WriteLine("В базе данных нет человека с таким номером");
                    break;
                }
          }
          
      }
  }
}