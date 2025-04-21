/* 1
Необходимо реализовать обобщенный класс, который позволяет хранить в массиве
объекты любого типа. В данном классе определить методы для добавления
данных в массив и удаление по индексу. */

using System;
class Massive<T> {
    public T[] massive = new T[0];
    public void Get(int ind) {
        Console.WriteLine(massive[ind]);
    }
    public void Add(T o) {
        T[] m1 = new T[massive.Length + 1];
        for(int i = 0; i < massive.Length; i++) {
            m1[i] = massive[i];
        }
        m1[m1.Length - 1] = o;
        massive = m1;
    }
    public void Del(int a) {
        T[] m1 = new T[massive.Length - 1];
        int k = 0;
        for(int i = 0; i < massive.Length; i++) {
            if(i == a) continue;
            else { m1[k] = massive[i]; k++; }
        }
        massive = m1;
    }
}
class Program {
  static void Main() {
    Massive<object> m = new Massive<object>();
    int a = 123; string b = "aaa"; double c = 1.23;
    m.Add(a); m.Add(b); m.Add(c);
    m.Get(0); m.Get(1); m.Get(2);
    m.Del(1);
    Console.WriteLine("после удаления второго элемента: "); m.Get(0); m.Get(1);
  }
}




