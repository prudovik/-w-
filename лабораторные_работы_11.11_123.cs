/* 1 
 На вход подается строка, состоящая из слов, между которыми от одного
до нескольких пробелов. Выполнить следующие задачи:
1) Удалить все лишние пробелы, оставив по одному;
2) Выдать все слова-палиндромы;
3) Подсчитать количество слов, у которых первый и последний символы
совпадают в любых начертаниях. */

using System;
class ZadachaOdin {
  static void Main() {
    string a = Console.ReadLine();
    int kolvo = 0;
    bool p = true;
    string[] slova = a.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
    a = string.Join(" ", slova);
    Console.WriteLine(a); /* 1) */
    for(int i = 0; i < slova.Length; i++){
        string s = slova[i].ToLower();
        p = true;
        for(int k = 0; k < s.Length; k++){
            if(s[k] != s[s.Length - k - 1]) p = false;
        }
        if(p) Console.WriteLine(slova[i]); /* 2) */
    }
    for(int i = 0; i < slova.Length; i++) {
        string s1 = slova[i].ToLower();
        if(s1[0] == s1[s1.Length-1]) kolvo += 1; /* 3) */
    }
    Console.WriteLine(kolvo);
  }
}
