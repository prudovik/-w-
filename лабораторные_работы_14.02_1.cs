/* 1 
Дан базовый класс с полем наименование и три класса-наследника:
окружность с полем радиус, квадрат с полем длина стороны и
равносторонний треугольник с полем длина стороны. Все три класса являются
наследниками интерфейса с методами определение периметра и определение
площади. Необходимо в основной программе создать три объекта и выдать для
каждого из них периметр и площадь. */
using System;

class Base {
    private string _name;
    public string Name {
        get => _name;
        set => _name = value;
    }
}

interface IMeths {
    double Perimeter();
    double Square();
}

class Circle : Base, IMeths {
    private double _rad;
    public double Rad {
        get => _rad;
        set => _rad = value;
    }
    public double Perimeter() {
        return 2*3.14*Rad;
    }
    public double Square() {
        return 3.14*Rad*Rad;
    }
}

class RegRectangle : Base, IMeths {
    private double _sider;
    public double Sider {
        get => _sider;
        set => _sider = value;
    }
    public double Perimeter() {
        return 4*Sider;
    }
    public double Square() {
        return Sider*Sider;
    }
}

class RegTriangle : Base, IMeths {
    private double _sidet;
    public double Sidet {
        get => _sidet;
        set => _sidet = value;
    }
    public double Perimeter() {
        return 3*Sidet;
    }
    public double Square() {
        return (Math.Sqrt(3)/2.0)*Sidet*Sidet;
    }
}

class Program {
  static void Main() {
    Circle ob1 = new Circle();
    RegRectangle ob2 = new RegRectangle();
    RegTriangle ob3 = new RegTriangle();
    Console.Write("Введите название окружности: ");
    string name1 = Console.ReadLine();
    ob1.Name = name1;
    Console.Write("Введите название квадрата: ");
    string name2 = Console.ReadLine();
    ob2.Name = name2;
    Console.Write("Введите название равностороннего треугольника: ");
    string name3 = Console.ReadLine();
    ob3.Name = name3;
    Console.Write($"Введите значение радиуса фигуры {ob1.Name}: ");
    double a1 = Convert.ToDouble(Console.ReadLine());
    ob1.Rad = a1;
    Console.Write($"Введите значение стороны фигуры {ob2.Name}: ");
    double a2 = Convert.ToDouble(Console.ReadLine());
    ob2.Sider = a2;
    Console.Write($"Введите значение стороны фигуры {ob3.Name}: ");
    double a3 = Convert.ToDouble(Console.ReadLine());
    ob3.Sidet = a3;
    Console.WriteLine($"Периметр фигуры {ob1.Name} = {ob1.Perimeter()}");
    Console.WriteLine($"Площадь фигуры {ob1.Name} = {ob1.Square()}");
    Console.WriteLine($"Периметр фигуры {ob2.Name} = {ob2.Perimeter()}");
    Console.WriteLine($"Площадь фигуры {ob2.Name} = {ob2.Square()}");
    Console.WriteLine($"Периметр фигуры {ob3.Name} = {ob3.Perimeter()}");
    Console.WriteLine($"Площадь фигуры {ob3.Name} = {ob3.Square()}");
  }
}


