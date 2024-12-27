/* 2
Есть класс, описывающий студента. Поля - ФИО, год рождения, курс. Создать массив из заданного
количества объектов этого класса. Выдать всех студентов, родившихся в заданный год,
заданного курса.*/
using System;
class Student {
    private string _fio;
    private int _god;
    private int _kurs;
    public string Fio {
        get => _fio;
        set => _fio = value;
    }
    public int God {
        get => _god;
        set => _god = value;
    }
    public int Kurs {
        get => _kurs;
        set => _kurs = value;
    }
}
class Program {
    static Student[] Zapolnenie(int n) {
        Student[] m = new Student[n];
        for(int i = 0; i < n; i++) {
            int k = i+1;
            Console.Write($"Введите ФИО студента {k}: ");
            string a = Console.ReadLine();
            Console.Write($"Введите год рождения студента {k}: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введите курс обучения студента {k}: ");
            int c = Convert.ToInt32(Console.ReadLine());
            m[i] = new Student();
            m[i].Fio = a; m[i].God = b; m[i].Kurs = c;
        }
        return m;
    }
  static void Main() {
      int vybor = 0;
      int check = 0;
      Student[] massiv = new Student[1];
      while(vybor != 5) {
          Console.WriteLine("Меню");
          Console.WriteLine("1. Заполнение");
          Console.WriteLine("2. Модификация");
          Console.WriteLine("3. Первая выборка (по году)");
          Console.WriteLine("4. Вторая выборка (по курсу)");
          Console.WriteLine("5. Выход");
          vybor = Convert.ToInt32(Console.ReadLine());
          switch(vybor) {
               case 5: break;
               case 1:
              if(check == 0) {
                  Console.Write("Введите количество студентов: ");
                  int kolvo = Convert.ToInt32(Console.ReadLine());
                  massiv = Zapolnenie(kolvo);
                  check = 1;
                  break;
              }
              else {
                  Console.WriteLine("Массив уже заполнен");
                  break;
              }
               case 2:
              if(check == 0) {
                  Console.WriteLine("Модификация невозможна");
                  break;
              }
              else {Console.Write("Введите ФИО студента: ");
              string fiomod = Console.ReadLine();
              int studmod = -1;
              for(int i = 0; i < massiv.Length; i++) {
                  if(massiv[i].Fio == fiomod) studmod = i;
              }
              if(studmod == -1) {
                  Console.WriteLine("Такого студента нет");
                  break;
              }
              else {
                  Console.WriteLine("Выберите параметр для изменения");
                  Console.WriteLine("1. ФИО");
                  Console.WriteLine("2. Год");
                  Console.WriteLine("3. Курс");
                  int vybormod = Convert.ToInt32(Console.ReadLine());
                  switch (vybormod) {
                      case 1:
                      Console.Write("Введите новое ФИО: ");
                      string fionew = Console.ReadLine();
                      massiv[studmod].Fio = fionew;
                      break;
                      case 2:
                      Console.Write("Введите новый год рождения: ");
                      int godnew = Convert.ToInt32(Console.ReadLine());
                      massiv[studmod].God = godnew;
                      break;
                      case 3:
                      Console.Write("Введите новый курс обучения: ");
                      int kursnew = Convert.ToInt32(Console.ReadLine());
                      massiv[studmod].Kurs = kursnew;
                      break;
                  }
                  break;
              }
              }
               case 3:
              if(check == 0) {
                  Console.WriteLine("Массив не заполнен");
                  break;
              }
              else {
                  Console.Write("Введите год: ");
                  int godvyb = Convert.ToInt32(Console.ReadLine());
                  int check2 = 0;
                  for(int i = 0; i < massiv.Length; i++) {
                      if(massiv[i].God == godvyb) {
                          Console.WriteLine($"{massiv[i].Fio}, {massiv[i].God}, {massiv[i].Kurs}");
                          check2 = 1;
                      }
                  }
                  if(check2 == 0) Console.WriteLine("Нет студентов, родившихся в данный год");
              
                  break;
              }
               case 4:
              if(check == 0) {
                  Console.WriteLine("Массив не заполнен");
                  break;
              }
              else {
                  Console.Write("Введите курс: ");
                  int kursvyb = Convert.ToInt32(Console.ReadLine());
                  int check2 = 0;
                  for(int i = 0; i < massiv.Length; i++) {
                      if(massiv[i].Kurs == kursvyb) {
                          Console.WriteLine($"{massiv[i].Fio}, {massiv[i].God}, {massiv[i].Kurs}");
                          check2 = 1;
                      }
                  }
                  if(check2 == 0) Console.WriteLine("Нет студентов, обучающихся на данном курсе");
              
                  break;
              
              
            }  
          }
      }
  }
}



