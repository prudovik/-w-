/* 1
Необходимо с помощью лямбда-выражений вычислить сумму, произведение, разность и деление
между двумя переменными. */

using System;
delegate void Sum(int a, int b);
delegate void Sub(int a, int b);
delegate void Mul(int a, int b);
delegate void Div(int a, int b);
class Program {
  static void Main() {
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Sum sum = (a, b) => Console.WriteLine($"Сумма {a} и {b} = {a+b}");
    Sub sub = (a, b) => Console.WriteLine($"Разность {a} и {b} = {a-b}");
    Mul mul = (a, b) => Console.WriteLine($"Произведение {a} и {b} = {a*b}");
    Div div = (a, b) => {
        if(b != 0) Console.WriteLine($"Частное {a} и {b} = {a/b}");
        else Console.WriteLine("Деление на 0 невозможно.");
    };
    sum(m, n); sub(m, n); mul(m, n); div(m, n);
  }
}

