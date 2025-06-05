/* 1
Дана строка, в которой присутствуют открывающиеся и закрывающиеся круглые,
квадратные и фигурные скобки. Необходимо определить, правильно ли расставлены
скобки. */

using System;
using System.Collections.Generic;
class Program {
  static void Main() {
    string n = Console.ReadLine();
    Stack<char> stack = new Stack<char>();
    bool check = true;
    foreach (char ch in n) {
        if (ch == '(' || ch == '[' || ch == '{') {
            stack.Push(ch);
        }
        else if (ch == ')' || ch == ']' || ch == '}') {
            if (stack.Count == 0) {
                check = false;
                break;
            }
            char ch2 = stack.Pop();
            if ((ch == ')' && ch2 != '(') || (ch == ']' && ch2 != '[') || (ch == '}' && ch2 != '{')) {
                check = false;
                break;
            }
        }
    }
    if (stack.Count > 0) {
        check = false;
    }
    if (check) {
        Console.WriteLine("Скобки расставлены правильно.");
    }
    else {
        Console.WriteLine("Скобки расставлены неправильно.");
    }
    if(stack.Count != 0) {
        Console.WriteLine("Остались незакрытые скобки.");
    }
  }
}