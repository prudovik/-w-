/* Чистый волновой алгоритм */

using System;
class Program {
    static bool Step(int[,] m, int i, int j) {
        if(m[i,j] == -1) return false;
        else return true;
    }
    static int[,] Matrix(int n, int m1) {
        int[,] m = new int[n+2,m1+2];
        for(int i = 1; i < n+1; i++) {
            for(int j = 1; j < m1+1; j++) {
                Console.WriteLine($"Есть ли камень между {i} и {j}? (0 - нет, да - 1): ");
                m[i,j] = Convert.ToInt32(Console.ReadLine());
                if(m[i,j] != 0) m[i,j] = -1; /* камень */
            }
        }
        for(int i = 0; i < n+2; i++) {
            m[i,0] = -1; m[i,m1+1] = -1;
        }
        for(int j = 0; j < m1+2; j++) {
            m[0,j] = -1; m[n+1,j] = -1;
        }
        return m;
    }
  static void Main() {
    Console.Write("Размер поля по горизонтали: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Размер поля по вертикали: ");
    int l = Convert.ToInt32(Console.ReadLine());
    int[,] m = Matrix(k,l);
    Console.WriteLine("Начальная клетка:");
    Console.Write("Строка: "); int n1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбец: "); int n2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Конечная клетка:");
    Console.Write("Строка: "); int m1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Столбец: "); int m2 = Convert.ToInt32(Console.ReadLine());
    if(Step(m,n1+1,n2)) m[n1+1, n2] = 1;
    if(Step(m,n1-1,n2)) m[n1-1, n2] = 1;
    if(Step(m,n1,n2+1)) m[n1, n2+1] = 1;
    if(Step(m,n1,n2-1)) m[n1, n2-1] = 1;
    int c = 1;
    bool check = true;
    while(m[m1,m2] == 0) {
        for(int i = 0; i < k+1; i++) {
            for(int j = 0; j < l+1; j++) {
                if(m[i,j] == c) {
                    if(Step(m,i+1,j)) {m[i+1, j] = m[i,j]+1; check = false;}
                    if(Step(m,i-1,j)) {m[i-1, j] = m[i,j]+1; check = false;}
                    if(Step(m,i,j+1)) {m[i, j+1] = m[i,j]+1; check = false;}
                    if(Step(m,i,j-1)) {m[i, j-1] = m[i,j]+1; check = false;}
                }
            }
        }
        if(check) break;
        c += 1;
        check = true;
    }
    if(m[m1,m2] == 0 || m[m1,m2] == -1) Console.WriteLine("Нет пути");
    else Console.WriteLine($"Минимальный путь равен {m[m1,m2]}");
  }
}







