/* 1
Найти результат выражения, представленного в виде постфиксной записи */


using System;
using System.Collections;
class Program {
    static void Main() {
        string n = Console.ReadLine();
        string[] a = n.Split(new Char[] {' '});
        Stack stack = new Stack();
        bool check = true;
        string nums = "1234567890"
        while(check) {
            for(int i = 0; i < a.Length; i++) {
                if(stack.Count > 2) {
                    check = false; break;
                }
                else if(stack.Count == 2) {
                    int check1 = 0;
                    foreach(char k in nums) {
                        foreach(char l in (string)stack.Peek()) {
                            if(k == l) check1+= 1;
                        }
                    }
                    if(check1 != (string)stack.Peek().Length) {
                        check = false;
                        break;
                    }
                    int oper = stack.Pop();
                    int check1 = 0;
                    foreach(char k in nums) {
                        foreach(char l in (string)stack.Peek()) {
                            if(k == l) check1+= 1;
                        }
                    }
                    if(check1 != (string)stack.Peek().Length) {
                        check = false;
                        break;
                    }
                }
            }
        }
        if(check == false) Console.Write("Ошибка.");
    }
}








