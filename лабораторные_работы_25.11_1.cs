/* 1 
На вход подается строка. Необходимо определить  символ, который чаще всего
встречается в комбинации a*b. Регистр не учитывается. */

using System;
class ZadachaOdin {
  static void Main() {
      char simvol = ' ', maxsimvol = ' ';
      string aaa = "";
      int maxkolvo = 0, kolvo = 0;
      string a = Console.ReadLine();
      a = a.ToLower();
      for(int i = 0; i < a.Length - 2; i++){
          string s = a;
          if(s[i] == 'a' && s[i+2] == 'b') {
              simvol = s[i+1];
              aaa = string.Concat('a', simvol);
              aaa = string.Concat(aaa, 'b');
              s = s.Replace(aaa, "");
              kolvo = (a.Length - s.Length)/3;
              if(kolvo > maxkolvo) {
                  maxkolvo = kolvo;
                  maxsimvol = simvol;
              }
          }
      }
      Console.WriteLine(maxsimvol);
  }
}