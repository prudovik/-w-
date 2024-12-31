/* 2
На вход подается строка. Определить максимальную длину подпоследовательности,
состоящей из троек элементов abc. */

using System;
class ZadachaDva {
    static void Main() {
        string stroka = Console.ReadLine();
        int dlina = 0, maxdlina = 0;
        for (int i = 0; i < stroka.Length; i++) {
            if (stroka[i] == 'a') {
                dlina += 1;
                i += 1;
                if (i < stroka.Length && stroka[i] == 'b') {
                    dlina += 1;
                    i += 1;
                    if (i < stroka.Length && stroka[i] == 'c') {
                        dlina += 1;
                    }
                    else {
                        maxdlina = maxdlina < dlina ? dlina : maxdlina;
                        dlina = 0;
                    }
                }
                else {
                    maxdlina = maxdlina < dlina ? dlina : maxdlina;
                    dlina = 0;
                }
            } 
            else {
                maxdlina = maxdlina < dlina ? dlina : maxdlina;
                dlina = 0;
            }
        }
        maxdlina = maxdlina < dlina ? dlina : maxdlina;
        Console.WriteLine(maxdlina);
    }
}

