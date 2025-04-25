/* 1
Есть база данных библиотеки, в которой описание книг будет с использованием структуры,
включающей следующие поля: ФИО автора, название, год издания, наименование издательства.
Для каждой книги имеется формуляр (даты выдачи и сдачи). Необходимо написать программу,
которая позволит заполнять базу данных и делать выборку книг, которые не были на руках
и книг, которые не сданы в библиотеку. */

using System;
using System.Collections.Generic;
struct Book {
    public string Author;
    public string Name;
    public int Year;
    public string Publisher;
    public string Issue;
    public string Return;
}
class Program {
  static void Main() {
    int a = 0;
    bool check = true;
    List<Book> list = new List<Book>();
    while(a != 4) {
        Console.WriteLine("1) Заполнение");
        Console.WriteLine("2) Книги, которые не были на руках");
        Console.WriteLine("3) Книги, которые были сданы в библиотеку");
        Console.WriteLine("4) Выход");
        a = Convert.ToInt32(Console.ReadLine());
        switch(a) {
            case 4: break;
            case 1:
                check = false;
                Console.Write("Количество книг: ");
                int n = Convert.ToInt32(Console.ReadLine());
                list.Clear();
                for(int i = 0; i < n; i++) {
                    Book book = new Book();
                    Console.Write($"Название книги {i+1}: ");
                    book.Name = Console.ReadLine();
                    Console.Write($"Автор книги {i+1}: ");
                    book.Author = Console.ReadLine();
                    Console.Write($"Год издания книги {i+1}: ");
                    book.Year = Convert.ToInt32(Console.ReadLine());
                    Console.Write($"Издательство: ");
                    book.Publisher = Console.ReadLine();
                    Console.Write("Книга выдавалась? 1) Да; 2) Нет: ");
                    int c = Convert.ToInt32(Console.ReadLine());
                    if(c == 1) {
                        Console.Write("Дата выдачи: ");
                        book.Issue = Console.ReadLine();
                        Console.Write("Книга сдана? 1) Да; 2) Нет: ");
                        c = Convert.ToInt32(Console.ReadLine());
                        if(c == 1) {
                            Console.Write("Дата сдачи: ");
                            book.Return = Console.ReadLine();
                        }
                    }
                    list.Add(book);
                }
                break;
            case 2:
                if(check) {
                    Console.Write("Заполните базу данных");
                    break;
                }
                else {
                    for(int i = 0; i < list.Count; i++) {
                        if(list[i].Issue == null) Console.Write($"{list[i].Name} ");
                    }
                    Console.Write("\n");
                    break;
                }
            case 3:
                if(check) {
                    Console.Write("Заполните базу данных");
                    break;
                }
                else {
                    for(int i = 0; i < list.Count; i++) {
                        if(list[i].Issue != null && list[i].Return == null) Console.Write($"{list[i].Name} ");
                    }
                    Console.Write("\n");
                    break;
                }
        }
    }
  }
}



