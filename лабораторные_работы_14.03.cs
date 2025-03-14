/* 1
Дан класс, состоящий из двух элементов. В нем реалтзованы методы сложение, вычитание,
умножение, деление. Есть делегат и два объекта класса. Для первого делегат
содержит группу операций сложение, разность полученной суммы со вторым
элементом объекта, произведение полученного результата на второй элемент
объекта. Для второго объекта - целочисленное деление, сумма результата со вторым
элементом, произведение результата на второй элемент. */

using System;
delegate void Op();
class A {
    private int _a;
    private int _b;
    public int a {
        get => _a;
        set => _a = value;
    }
    public int b {
        get => _b;
        set => _b = value;
    }
    public void Add() {
        a = a+b;
    }
    public void Sub() {
        a = a-b;
    }
    public void Mul() {
        a = a*b;
    }
    public void Div() {
        if(b != 0) a = a/b;
        else Console.WriteLine("ошибка");
    }
}
class Program {
  static void Main() {
      A m = new A(); A n = new A();
      Console.Write("Элемент 1 объекта 1 ");
      int m1 = Convert.ToInt32(Console.ReadLine()); m.a = m1;
      Console.Write("Элемент 2 объекта 1 ");
      int m2 = Convert.ToInt32(Console.ReadLine()); m.b = m2;
      Console.Write("Элемент 1 объекта 2 ");
      int n1 = Convert.ToInt32(Console.ReadLine()); n.a = n1;
      Console.Write("Элемент 2 объекта 2 ");
      int n2 = Convert.ToInt32(Console.ReadLine()); n.b = n2;
      Op op1; Op op2;
      Op add1 = m.Add;
      Op sub1 = m.Sub;
      Op mul1 = m.Mul;
      Op add2 = n.Add;
      Op mul2 = n.Mul;
      Op div2 = n.Div;
      op1 = add1; op1 += sub1; op1 += mul1;
      op2 = div2; op2 += add2; op2 += mul2;
      op1(); op2();
      Console.WriteLine($"Результат операций над объектом 1 - {m.a}");
      Console.WriteLine($"Результат операций над объектом 1 - {n.a}");
  }
}










