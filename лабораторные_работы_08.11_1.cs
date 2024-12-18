/* 1
Подается зубчатый массив, задаваемый функцией. Определить номера строк,
элементы которых образуют равномерно убывающую последовательность. */

using System;
class Zadacha {
    static int[][] Massiv(int a){
        int[][] m = new int[a][];
        for(int i = 0; i < a; i++){
            int chislo = Convert.ToInt32(Console.ReadLine());
            m[i] = new int[chislo];
            for(int k = 0; k < chislo; k++){
                m[i][k] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return m;
    }
    static void Main(){
        int razmer = Convert.ToInt32(Console.ReadLine());
        int[][] massiv = Massiv(razmer);
        for(int m = 0; m < razmer; m++){
            int raznost = 0;
            int check = 0;
            for(int n = 0; n < massiv[m].Length-2; n++){
                raznost = massiv[m][n] - massiv[m][n+1];
                if((massiv[m][n+1] - massiv[m][n+2] == raznost) && (raznost>0)) check += 1;
            }
            if(check == massiv[m].Length-3) Console.WriteLine($"Номер строки: {0}", m+1);
            
        }
    }
}