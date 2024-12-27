/* 1 
Дан двумерный массив. Необходимо поменять местами строку, содержащую
минимальный элемент со строкой, содержащей максимальный. */

using System;
class ZadachaOdin {
  static void Main() {
      int maxi = -100000, mini = 100000;
      int strokamaxi = 0, strokamini = 0, n = 0;
      int a = Convert.ToInt32(Console.ReadLine());
      int b = Convert.ToInt32(Console.ReadLine());
      int[,] massiv = new int[a, b];
      for(int k = 0; k < a; k ++){
          for(int l = 0; l < b; l++){
              massiv[k, l] = Convert.ToInt32(Console.ReadLine());
          }
      }
      for(int k = 0; k < a; k ++){
          for(int l = 0; l < b; l++){
              if(massiv[k, l] < mini){
                  mini = massiv[k,l];
                  strokamini = k;
              }
              if(massiv[k, l] > maxi){
                  maxi = massiv[k,l];
                  strokamaxi = k;
              }
          }
      }
      for(int l = 0; l < b; l++){
          n = massiv[strokamini, l];
          massiv[strokamini, l] = massiv[strokamaxi, l];
          massiv[strokamaxi, l] = n;
      }
  }
}
