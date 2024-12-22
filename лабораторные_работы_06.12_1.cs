/* 1
Есть класс, имеющий два поля типа инт. В нем три конструктора: первый
инициализирует значения полей в ноль если нет параметров, второй - принимает один
параметр (второй - ноль), третий - принимает оба параметра. В классе есть четыре
метода, включающих вывод: первый - сложение переменных, второй - вычитание,
третий - деление, четвертый - умножение. Создать три объекта с использованием
разных конструкторов и использовать для них методы (вычитание дважды). */
using System;
class Operatsii {
    public int A;
    public int B;
    public Operatsii() {
        A = 0;
        B = 0;
    }
    public Operatsii(int a) {
        A = a;
        B = 0;
    }
    public Operatsii(int a, int b) {
        A = a;
        B = b;
    }
    public void Slozhenie() {
        Console.Write("Сумма: ");
        Console.WriteLine(A + B);
    }
    public void Vychitanie() {
        Console.Write("Разность 1: ");
        Console.WriteLine(A - B);
        Console.Write("Разность 2: ");
        Console.WriteLine(B - A);
    }
    public void Delenie() {
        if(B != 0) {Console.Write("Частное: "); Console.WriteLine(A / B);}
        else Console.WriteLine("Деление на ноль невозможно");
    }
    public void Umnozhenie() {
        Console.Write("Произведение: ");
        Console.WriteLine(A * B);
    }
}
class Program {
  static void Main() {
      int a = Convert.ToInt32(Console.ReadLine());
      int b = Convert.ToInt32(Console.ReadLine());
      int c = Convert.ToInt32(Console.ReadLine());
      Operatsii n1 = new Operatsii();
      Operatsii n2 = new Operatsii(a);
      Operatsii n3 = new Operatsii(b, c);
      n1.Slozhenie();
      n1.Vychitanie();
      n1.Delenie();
      n1.Umnozhenie();
      n2.Slozhenie();
      n2.Vychitanie();
      n2.Delenie();
      n2.Umnozhenie();
      n3.Slozhenie();
      n3.Vychitanie();
      n3.Delenie();
      n3.Umnozhenie();
  }
}




