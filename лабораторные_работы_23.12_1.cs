/* 1 
Есть класс люди с полями ФИО и год рождения. Имеются два класса-наследника: студенты
(массив оценок) и преподаватели (массив наименований предметов). Написать программу с меню,
имеющим следующие пункты: заполнение, печать данных, выборка студентов по году рождения,
выборка преподаваталей по наименованию дисциплины, выход. */

using System;
class Lyudi {
    private string _fio;
    private int _god;
    public string Fio {
        get => _fio;
        set => _fio = value;
    }
    public int God {
        get => _god;
        set => _god = value;
    }
}
class Student : Lyudi {
    private int[] _otsenki;
    public int[] Otsenki {
        get => _otsenki;
        set => _otsenki = value;
    }
}
class Prepodavatel : Lyudi {
    private string[] _predmety;
    public string[] Predmety {
        get => _predmety;
        set => _predmety = value;
    }
}
class Program {
    static int[] Zapoln1(int n) {
        int[] m = new int[n];
        for(int i = 0; i < n; i++) {
            Console.Write("Введите оценку: ");
            m[i] = Convert.ToInt32(Console.ReadLine());
        }
        return m;
    }
    static string[] Zapoln2(int n) {
        string[] m = new string[n];
        for(int i = 0; i < n; i++) {
            Console.Write("Введите предмет: ");
            m[i] = Console.ReadLine();
        }
        return m;
    }
    static Student[] ZapSt(int n) {
        Student[] m = new Student[n];
        for(int i = 0; i < n; i++) {
            int ind = i + 1;
            Console.Write($"Введите ФИО студента {ind}: ");
            string a = Console.ReadLine();
            Console.Write($"Введите год рождения студента {ind}: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите количество оценок студента {ind}: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] o = Zapoln1(k); 
            m[i] = new Student();
            m[i].Fio = a; m[i].God = b; m[i].Otsenki = o;
        }
        return m;
    }
    static Prepodavatel[] ZapPr(int n) {
        Prepodavatel[] m = new Prepodavatel[n];
        for(int i = 0; i < n; i++) {
            int ind = i + 1;
            Console.Write($"Введите ФИО преподавателя {ind}: ");
            string a = Console.ReadLine();
            Console.Write($"Введите год рождения преподавателя {ind}: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите количество предметов преподавателя {ind}: ");
            int k = Convert.ToInt32(Console.ReadLine());
            string[] o = Zapoln2(k); 
            m[i] = new Prepodavatel();
            m[i].Fio = a; m[i].God = b; m[i].Predmety = o;
        }
        return m;
    }
    
  static void Main() {
      int vybor = 0;
      Prepodavatel[] m2 = new Prepodavatel[1];
      Student[] m1 = new Student[1];
      bool p1 = false, p2 = false;
      while(vybor != 5) {
           Console.WriteLine("Меню");
          Console.WriteLine("1. Заполнение");
          Console.WriteLine("2. Печать данных");
          Console.WriteLine("3. Выборка студентов по году рождения");
          Console.WriteLine("4. Выборка преподаваталей по наименованию дисциплины");
          Console.WriteLine("5. Выход");
          vybor = Convert.ToInt32(Console.ReadLine());
          switch(vybor) {
              case 5: break;
              case 1:
                Console.WriteLine("1. Заполнить данные о студентах");
                Console.WriteLine("2. Заполнить данные о преподавателях");
                int vyb2 = Convert.ToInt32(Console.ReadLine());
                switch (vyb2) {
                    case 1:
                    Console.Write("Введите количество студентов: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    m1 = ZapSt(n1);
                    p1 = true;
                    break;
                    case 2:
                    Console.Write("Введите количество преподавателей: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    m2 = ZapPr(n2);
                    p2 = true;
                    break;
                }
                break;
              case 2:
                Console.WriteLine("1. Печать данных о студентах");
                Console.WriteLine("2. Печать данных о преподавателях");
                int vyb3 = Convert.ToInt32(Console.ReadLine());
                switch (vyb3) {
                    case 1:
                    if(p1 == false) {
                        Console.WriteLine("Заполните массив студентов");
                        break;
                    }
                    else {
                        for(int i = 0; i < m1.Length; i++) {
                            int k = i+1;
                            Console.WriteLine($"ФИО студента {k}: {m1[i].Fio}");
                            Console.WriteLine($"Год рождения студента {k}: {m1[i].God}");
                            Console.WriteLine($"Оценки студента {k}: {m1[i].Otsenki}");
                            
                        }
                        break;
                    }
                    case 2:
                    if(p2 == false) {
                        Console.WriteLine("Заполните массив преподавателей");
                        break;
                    }
                    else {
                        for(int i = 0; i < m1.Length; i++) {
                            int k = i+1;
                            Console.WriteLine($"ФИО преподавателя {k}: {m2[i].Fio}");
                            Console.WriteLine($"Год рождения преподавателя {k}: {m2[i].God}");
                            Console.WriteLine($"Дисциплины преподавателя {k}: {m2[i].Predmety}");
                            
                        }
                        break;
                    }
                }
                break;
              case 3:
                Console.Write("Введите год: ");
                int vgod = Convert.ToInt32(Console.ReadLine());
                bool pgod = true;
                for(int i = 0; i < m1.Length; i++) {
                    if(m1[i].God == vgod) {
                        pgod = false;
                        Console.WriteLine($"{m1[i].Fio}, {m1[i].God}, {m1[i].Otsenki}");
                    }
                }
                if(pgod) Console.WriteLine("Нет студентов, родившихся в данный год");
                break;
              case 4:
                Console.Write("Введите дисциплину: ");
                string vdis = Console.ReadLine();
                bool pdis = true;
                for(int i = 0; i < m2.Length; i++) {
                    for(int j = 0; j < m2[i].Predmety.Length; j++) {
                        if(m2[i].Predmety[j] == vdis) {
                            pdis = false;
                            Console.WriteLine($"{m2[i].Fio}, {m2[i].God}, {m2[i].Predmety}");
                        }
                    }
                }
                if(pdis) Console.WriteLine("Нет преподавателей, ведущих данную дисциплину");
                break;
          }
      }
  }
}