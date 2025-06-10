/* Имеется база данных магазин, включающая в себя сведения о поставщиках,
товарах и о движении товаров в магазине. Поставщик описывается следующими
полями: наименование, контактный телефон, город, идентификатор.
О товаре известны артикул и наименование. Движение товара - артикул
товара, номер поставщика, дата, поступление или продажа. Далее идет
количество и стоимость одной единицы. С помощью языка запросов необходимо
определить: кол-во остатков товара в магазине; сгруппировать поставки
товара по дате, по поставщику; выдать движение товара,
сгрупированного по артикулу.*/

using System;
using System.Collections.Generic;
using System.Linq;
class Provider {
    public string Name { get; set; }
    public string Number { get; set; }
    public string City { get; set; }
    public string Id { get; set; }
}
class Product {
    public string Articul { get; set; }
    public string Name { get; set; }
}
class MovementOfGoods {
    public string Articul { get; set; }
    public string Id { get; set; }
    public string Date { get; set; }
    public string Quantity { get; set; }
    public string Status { get; set; }
    public decimal Price { get; set; }
}
class Program {
    static void Main() {
        List<Provider> providers = new List<Provider>();
        List<Product> products = new List<Product>();
        List<MovementOfGoods> movement = new List<MovementOfGoods>();
        bool check = false;
        while (!check) {
            Console.WriteLine("1. Ввод данных о поставщиках");
            Console.WriteLine("2. Ввод данных о товарах");
            Console.WriteLine("3. Ввод данных о передвижении товара");
            Console.WriteLine("4. Количество остатков товара в магазине");
            Console.WriteLine("5. Группировка товаров по дате поставки");
            Console.WriteLine("6. Группировка товаров по поставщику");
            Console.WriteLine("7. Группировка движения товара по артикулу");
            Console.WriteLine("0. Выход");
            Console.WriteLine("\nВыберите пункт: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
                    Console.WriteLine("Введите количество поставщиков: ");
                    int quantity_provide = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < quantity_provide; i++) {
                        Console.Write($"Введите имя поставщика {i + 1}: ");
                        string name = Console.ReadLine();
                        Console.Write($"Введите номер поставщика {i + 1}: ");
                        string number = Console.ReadLine();
                        Console.Write($"Введите город поставщика {i + 1}: ");
                        string city = Console.ReadLine();
                        Console.Write($"Введите идентификатор поставщика {i + 1}: ");
                        string id = Console.ReadLine();
                        providers.Add(new Provider { Name = name, Number = number, City = city, Id = id });
                    }
                    break;
                case 2:
                    Console.WriteLine("\nВведите количество товаров: ");
                    int quantity_product = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < quantity_product; i++) {
                        Console.Write($"Введите артикул товара {i + 1}: ");
                        string articul = Console.ReadLine();
                        Console.Write($"Введите название товара {i + 1}: ");
                        string name = Console.ReadLine();
                        products.Add(new Product { Articul = articul, Name = name });
                    }
                    break;
                case 3:
                    Console.WriteLine("\nВведите количество движений товара: ");
                    int quantity_movement = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < quantity_movement; i++) {
                        Console.Write("Артикул товара: ");
                        string articul = Console.ReadLine();
                        if (!products.Any(p => p.Articul == articul)) {
                            Console.WriteLine("Товара с таким артикулом нет");
                            continue;
                        }
                        Console.Write("Поставщик товара (идентификатор): ");
                        string id = Console.ReadLine();
                        if (!providers.Any(p => p.Id == id)) {
                            Console.WriteLine("Поставщика с таким иднетификатором нет");
                            continue;
                        }
                        Console.Write($"Введите дату: ");
                        string date = Console.ReadLine();
                        Console.Write($"Введите количество товара: ");
                        string quantity = Console.ReadLine();
                        string status;
                        while (true){
                            Console.Write("Введите статус товара (пришло/продано): ");
                            string userInput = Console.ReadLine().ToLower();
                            if (userInput == "пришло") {
                                status = "Пришло";
                                break;
                            }
                            else if (userInput == "продано") {
                                var balanceQuery = from m in movement
                                                   where m.Articul == articul
                                                   group m by m.Articul into g
                                                   select new {
                                                       In = (from x in g where x.Status == "Пришло" select Convert.ToInt32(x.Quantity)).Sum(),
                                                       Out = (from x in g where x.Status == "Продано" select Convert.ToInt32(x.Quantity)).Sum(),
                                                       Balance = (from x in g where x.Status == "Пришло" select Convert.ToInt32(x.Quantity)).Sum()
                                                               - (from x in g where x.Status == "Продано" select Convert.ToInt32(x.Quantity)).Sum()
                                                   };
                                int currentBalance = balanceQuery.FirstOrDefault()?.Balance ?? 0;
                                if (currentBalance <= 0) {
                                    Console.WriteLine("Ошибка: нельзя продать товар — его остаток равен 0.");
                                    Console.WriteLine("Выберите 'пришло', чтобы добавить товар на склад.");
                                }
                                else {
                                    status = "Продано";
                                    break;
                                }
                            }
                            else {
                                Console.WriteLine("Неверный статус. Введите 'пришло' или 'продано'");
                            }
                        }
                        Console.Write($"Введите цену товара: ");
                        decimal price = Convert.ToDecimal(Console.ReadLine());
                        movement.Add(new MovementOfGoods { Articul = articul, Id = id, Date = date, Quantity = quantity, Status = status, Price = price });
                    }
                    break;
                case 4:
                    Console.WriteLine("\nКоличество остатков товара в магазине");
                    var qantityShop = from m in movement
                                      group m by m.Articul into g
                                      select new {
                                          Article = g.Key,
                                          In = (from x in g where x.Status == "Пришло" select Convert.ToInt32(x.Quantity)).Sum(),
                                          Out = (from x in g where x.Status == "Продано" select Convert.ToInt32(x.Quantity)).Sum(),
                                          Balance = (from x in g where x.Status == "Пришло" select Convert.ToInt32(x.Quantity)).Sum()
                                                    - (from x in g where x.Status == "Продано" select Convert.ToInt32(x.Quantity)).Sum()
                                      };
                    foreach (var item in qantityShop) {
                        Console.WriteLine($"Артикул: {item.Article}, Приход: {item.In}, Расход: {item.Out}, Остаток: {item.Balance}");
                    }
                    break;
                case 5:
                    Console.WriteLine("\nГруппировка товаров по дате поставки");
                    var groupedByDate = from m in movement
                                        where m.Status == "Пришло"
                                        group m by m.Date into g
                                        select new {
                                            Date = g.Key,
                                            Items = g.ToList()
                                        };
                    foreach (var group in groupedByDate) {
                        Console.WriteLine($"\nДата: {group.Date}");
                        foreach (var item in group.Items) {
                            Console.WriteLine($" Артикул: {item.Articul}, Кол-во: {item.Quantity}, Цена: {item.Price}");
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("\nГруппировка товаров по поставщику");
                    var groupedByProvider = from m in movement
                                            where m.Status == "Пришло"
                                            join p in providers on m.Id equals p.Id
                                            group m by new { p.Id, p.Name } into g
                                            select new {
                                                ProviderName = g.Key.Name,
                                                TotalItems = g.Count(),
                                                TotalQuantity = (from x in g
                                                                 select Convert.ToInt32(x.Quantity)).Sum()
                                            };
                    foreach (var group in groupedByProvider) {
                        Console.WriteLine($"Поставщик: {group.ProviderName}, Поставок: {group.TotalItems}, Общее кол-во: {group.TotalQuantity}");
                    }
                    break;
                case 7:
                    Console.WriteLine("\nГруппировка движения товара по артикулу");
                    var groupedByArticle = from m in movement
                                           group m by m.Articul into g
                                           select new {
                                               Article = g.Key,
                                               Movements = g.ToList()
                                           };
                    foreach (var group in groupedByArticle) {
                        Console.WriteLine($"\nАртикул: {group.Article}");
                        foreach (var item in group.Movements) {
                            Console.WriteLine($" Поставщик ID: {item.Id}, Дата: {item.Date}, Статус: {item.Status}, Количество: {item.Quantity}, Цена: {item.Price}");
                        }
                    }
                    break;
                case 0:
                    check = true;
                    break;
                default:
                    break;
            }
        }
    }
}