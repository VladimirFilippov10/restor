using restaurant_.Domain.Entities;
using restaurant_.Domain;
using System;

namespace restaurant_
{
    internal class Program
    {
        public static char choice = ' '; // выбор
        public static char choiceCategory = ' '; // выбор
        public static ApplicationContext applicationContext = new ApplicationContext(); // создание экземпляра класса
        public static int quantityOrder = 1; // количество заказов
        public static int quantityOrderItem = 0; // количество  элементов заказов
        public static orderItem newOrderItem;
        public static order newOrder; // новый заказ
        //public static applicationContext.Categories = new List<category>(); // категории
        
        public static List<category> newCategory()
        {
            applicationContext.Categories = new List<category>();
            category category = new category(1);
            category.Name = "Завтраки";
            applicationContext.Categories.Add(category);

            category = new category(2);
            category.Name = "Обеды";
            applicationContext.Categories.Add(category);

            category = new category(3);
            category.Name = "Ужины";
            applicationContext.Categories.Add(category);

            category = new category(4);
            category.Name = "Закуски";
            applicationContext.Categories.Add(category);

            category = new category(5);
            category.Name = "Десерты";
            applicationContext.Categories.Add(category);
            return applicationContext.Categories;

        }
        public static List<product> newProduct() // инициализация продуктов
        {
            applicationContext.Products = new List<product>();
            //List<category> Categories = new List<category>();
            //Categories = applicationContext.Categories;

            product product = new product(1);
            product.Name = "Омлет с овощами";
            product.Description = "Нежный омлет с томатами, перцем и зеленью";
            product.Categories.Add(applicationContext.Categories[0]);
            product.ProteinPer100g = 8.5;
            product.FatPer100g = 5.2;
            product.CarbsPer100g = 3.7;
            product.Calories = 150;
            product.Price = 450;
            applicationContext.Products.Add(product);

            product = new product(2);
            product.Name = "Греческий салат";
            product.Description = "Свежий салат с огурцами, помидорами, оливками и сыром фета";
            product.Categories.Add(applicationContext.Categories[0]);
            product.ProteinPer100g = 4.3;
            product.FatPer100g = 6.8;
            product.CarbsPer100g = 2.5;
            product.Calories = 120;
            product.Price = 350;
            applicationContext.Products.Add(product);

            product = new product(3);
            product.Name = "Паста Карбонара";
            product.Description = "Итальянская паста с беконом, яйцом, пармезаном и сливками";
            product.Categories.Add(applicationContext.Categories[1]);
            product.ProteinPer100g = 12.3;
            product.FatPer100g = 9.8;
            product.CarbsPer100g = 45.6;
            product.Calories = 380;
            product.Price = 800;
            applicationContext.Products.Add(product);

            product = new product(4);
            product.Name = "Курица табака";
            product.Description = "Жареная курица с ароматными специями и лимоном";
            product.Categories.Add(applicationContext.Categories[1]);
            product.ProteinPer100g = 20.5;
            product.FatPer100g = 15.2;
            product.CarbsPer100g = 0.5;
            product.Calories = 280;
            product.Price = 750;
            applicationContext.Products.Add(product);

            product = new product(5);
            product.Name = "Лосось с овощами";
            product.Description = "Паровой лосось с запеченными овощами и зеленью";
            product.Categories.Add(applicationContext.Categories[2]);
            product.ProteinPer100g = 22.6;
            product.FatPer100g = 13.8;
            product.CarbsPer100g = 7.2;
            product.Calories = 320;
            product.Price = 1250;
            applicationContext.Products.Add(product);

            product = new product(6);
            product.Name = "Гуляш с картофелем";
            product.Description = "Тушеная говядина с луком, морковью и картофелем";
            product.Categories.Add(applicationContext.Categories[2]);
            product.ProteinPer100g = 18.9;
            product.FatPer100g = 11.5;
            product.CarbsPer100g = 20.3;
            product.Calories = 420;
            product.Price = 600;
            applicationContext.Products.Add(product);

            product = new product(7);
            product.Name = "Брускетта с помидорами";
            product.Description = "Хрустящий хлеб с помидорами, чесноком и базиликом";
            product.Categories.Add(applicationContext.Categories[3]);
            product.ProteinPer100g = 3.8;
            product.FatPer100g = 2.6;
            product.CarbsPer100g = 18.5;
            product.Calories = 150;
            product.Price = 475;
            applicationContext.Products.Add(product);

            product = new product(8);
            product.Name = "Оливки сырые";
            product.Description = "Отборные маринованные зеленые оливки";
            product.Categories.Add(applicationContext.Categories[3]);
            product.ProteinPer100g = 1.2;
            product.FatPer100g = 15.0;
            product.CarbsPer100g = 3.0;
            product.Calories = 120;
            product.Price = 250;
            applicationContext.Products.Add(product);

            product = new product(9);
            product.Name = "Тирамису";
            product.Description = "Итальянский десерт с маскарпоне, кофе и какао";
            product.Categories.Add(applicationContext.Categories[4]);
            product.ProteinPer100g = 5.7;
            product.FatPer100g = 11.3;
            product.CarbsPer100g = 25.6;
            product.Calories = 280;
            product.Price =500;
            applicationContext.Products.Add(product);

            product = new product(10);
            product.Name = "Фруктовое мороженое";
            product.Description = "Мороженое с клубникой, персиком и манго";
            product.Categories.Add(applicationContext.Categories[4]);
            product.ProteinPer100g = 3.2;
            product.FatPer100g = 6.5;
            product.CarbsPer100g = 30.8;
            product.Calories = 200;
            product.Price = 400;
            applicationContext.Products.Add(product);
            return applicationContext.Products;
        }
        public static void startMenu() // стартовое меню
        {
            Console.WriteLine();
            Console.WriteLine("Терминал для заказа");
            Console.WriteLine("Введите номер действия");
            Console.WriteLine("1. В зале");
            Console.WriteLine("2. С собой");
            Console.WriteLine("3. Просмотр заказов");
            Console.WriteLine();
            Console.WriteLine("[q – завершить работу]");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (choice == '1' || choice == '2') // создание нового заказа
            {
                //Console.WriteLine(quantityOrder);
                newOrder = new order(quantityOrder);
            }
            switch (choice)
            {
                case '1':
                    newOrder.Place = "В зале";
                    chooseCategories();
                    break;
                case '2':
                    newOrder.Place = "С собой";
                    chooseCategories();
                    break;
                case '3':
                    listOrder();
                    break;
                default:
                    Console.WriteLine("Ошибка ввода"); 
                    break;
            }
        }
        public static void listOrder() // вывод списка заказов доделать
        {
            Console.WriteLine();
            Console.WriteLine("Список заказов");
            Console.WriteLine();
            if (applicationContext.Order.Count != 0) // проверка на наличие заказов
            {
                Console.WriteLine("Номер\tМесто выдачи\tДата создания");
                foreach (var itemList in applicationContext.Order)// вывод заказов
                {
                    Console.WriteLine($"{itemList.orderNumber}\t{itemList.Place}\t{itemList.CreatedDate}");
                    Console.WriteLine("Наименование\tЦена за еденицу\tКоличество\tОбщая цена");
                    double totalPrice = 0;
                    foreach (var productItemList in itemList.orderItems) // вывод элементов
                    {
                        Console.WriteLine($"{productItemList.product.Name,-20}\t{productItemList.product.Price,15}\t{productItemList.quantity,10}\t{productItemList.productPrice,15}");
                        totalPrice += productItemList.productPrice;
                    }
                    Console.WriteLine("Итого".PadRight(60) + totalPrice + " руб.");
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Активных заказов нет"); 
            Console.WriteLine();

        }
        static void chooseCategories() // выбор категории
        {
            Console.WriteLine();
            Console.WriteLine("Терминал для заказа");
            Console.WriteLine("Введите категорию");
            foreach (var category in applicationContext.Categories) // выбор категории
            {
                Console.WriteLine(category.Id+". " + category.Name);
            }
            bottomMenu();
            choiceCategory = choice;
            if (choiceCategory == 'b')
                startMenu();
            else
                chooseProduct();
        }
        static /*List<product>*/void chooseProduct() // выбор продукта
        {
            Console.WriteLine();
            Console.WriteLine("Терминал для заказа");
            Console.WriteLine("Введите продукт");
            int idCategory = Convert.ToInt32(choiceCategory);
            switch (choiceCategory)
            {
                case '1':
                    idCategory = 1;
                    break;
                case '2':
                    idCategory = 2;
                    break;
                case '3':
                    idCategory = 3;
                    break;
                case '4':
                    idCategory = 4;
                    break;
                case '5':
                    idCategory = 5;
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }
            var productInCategory = applicationContext.Products.Where(p => p.Categories[0].Id == idCategory).ToList();
            int i = 1; // вывод блюд
            foreach (var product in productInCategory) // вывод продуктов по категорию
            {
                Console.WriteLine(i+". "+product.Name + "( " + product.Price+" руб.)");
                i++;
            }
            if (choice == 'b')
                chooseCategories();
            else
            {
                bottomMenu();
                quantityOrderItem += 1;
                newOrderItem = new orderItem(quantityOrderItem);
                if (choice != 'b')
                {
                    int choiceNumber = (int)Char.GetNumericValue(choice);
                    newOrderItem.product = productInCategory[choiceNumber - 1];
                    //newOrder.orderItems.Add(newOrderItem)
                    //return productInCategory;
                    quantitySelectionProduct();
                }
                else
                    chooseCategories();

            }


        }
        static void quantitySelectionProduct() // определение количества
        {
            Console.WriteLine();
            Console.WriteLine("Терминал для заказа");
            Console.WriteLine("Введите количество:");
            bottomMenu();

            if (choice != 'b')
            {
                //newOrderItem.quantity = Convert.ToInt32(choice.ToString());
                //newOrderItem.productPrice = newOrderItem.product.Price * newOrderItem.quantity; // расчёт общей стоимости
                //var alreadyThereIs = newOrder.orderItems.Where(x => x.product.Id == newOrderItem.product.Id).ToList();
                //newOrder.orderItems.Add(newOrderItem); // добавление блюда в заказ
                int quantity = Convert.ToInt32(choice.ToString());
                var existingItem = newOrder.orderItems.FirstOrDefault(x => x.product.Id == newOrderItem.product.Id);
                if (existingItem != null)
                {
                    existingItem.quantity += quantity;
                    existingItem.productPrice = existingItem.product.Price * existingItem.quantity; // пересчёт стоимости
                }
                else
                {
                    newOrderItem.quantity = quantity; 
                    newOrderItem.productPrice = newOrderItem.product.Price * newOrderItem.quantity; // расчёт общей стоимости
                    newOrder.orderItems.Add(newOrderItem);
                }
                choosingPath();
            }
            else
                chooseProduct();
        }
        public static void choosingPath() // выбор дальнейшего пути
        {
            Console.WriteLine();
            Console.WriteLine("Терминал для заказа");
            Console.WriteLine("Продукт успешно добавлен в заказ. Введите номер действия");
            Console.WriteLine("1.Продолжить выбор продуктов");
            bottomMenu();
            if (choice == '1')
            {
                chooseCategories(); // переход к добавлению других товаров
            }
            
        }
        static void bottomMenu() // нижнее меню
        {
            Console.WriteLine();
            Console.WriteLine("[b – назад, p – оформить заказ, c - отменить заказ, q – завершить работу]");
            choice = Console.ReadKey().KeyChar;
            bottomMenuCommands();
        }
        static void bottomMenuCommands() // функции нижнего меню
        {
            switch (choice)
            {
                case 'p':
                    placingAnOrder();
                    break;
                case 'c':
                    cancellations();
                    break;
            }

        }
        static void cancellations() // отмена заказа
        {
            Console.WriteLine();
            Console.WriteLine("Ваш заказ отменён!");
            Console.WriteLine("[m – в меню, q – завершить работу]");
            choice = Console.ReadKey().KeyChar;
            if (choice == 'm')
            {
                startMenu();// возврат к меню
            }
        }
        static void placingAnOrder() // оформление заказа
        {
            Console.WriteLine();
            Console.WriteLine("Терминал для заказа");
            Console.WriteLine("Ваш заказ сформирован");
            int quantityItem = 1;
            double totalPrice = 0;
            foreach (var productInOrder in newOrder.orderItems)
            {
                Console.WriteLine($"{quantityItem}. {productInOrder.product.Name,-30} x {productInOrder.quantity,-2} = {productInOrder.productPrice,5} руб.");
                quantityItem++;
                totalPrice += productInOrder.productPrice;
            }
            Console.WriteLine("Итого".PadRight(42) + totalPrice + " руб.");
            if (quantityOrder >= 99)
                quantityOrder = 0;
            newOrder.orderNumber = "A-" + quantityOrder;
            newOrder.CreatedDate = DateTime.Now;
            applicationContext.Order.Add(newOrder);
            quantityOrder++;
        }
        static void Main(string[] args)
        {
            applicationContext.Categories = newCategory();
            applicationContext.Products = newProduct();
            applicationContext.Order = new List<order>();
            do
            {
                startMenu();
                quantityOrderItem = 0;
            }
            while (choice != 'q');
        }
    }
}
