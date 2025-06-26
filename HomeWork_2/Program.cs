using HomeWork_2;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal[] animals = new Animal[2] {new Cat("Барсик", 3), new Dog(4)};
        Test(animals);

        static void Test(Animal[] pet)
        {
            string? input = "";

            while (input != "0")
            {
                Console.Clear();
                Console.WriteLine("------------------------------Главное Меню------------------------------");
                Console.WriteLine("1 - Посмотреть данные о питомцах");
                Console.WriteLine("2 - Покормить питомцев");
                Console.WriteLine("3 - Наказать питомцев");
                Console.WriteLine("4 - Дать имя питомцу");
                Console.WriteLine("0 - Выход");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        foreach (Animal p in pet)
                        {
                            Console.WriteLine();
                            p.Say();
                            p.HealthCheckUp();
                            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить.");
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        foreach (Animal p in pet)
                        {
                            string? input1 = "";
                            int foodCount = 0;
                            p.Say();
                            p.HealthCheckUp();
                            Console.WriteLine("\nХотите покормить этого питомца? " +
                                "Если да, то введите занчение от 1 до 100, если нет - выберете 0");
                            input1 = Console.ReadLine();
                            while (!int.TryParse(input1, out foodCount) || foodCount < 0 || foodCount > 100)
                            {
                                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                                input1 = Console.ReadLine();
                            }
                            p.Feed(foodCount);
                            if (foodCount > 0)
                            {
                                Console.WriteLine("Вы покормили своего питомца.");
                            }
                            else if(foodCount == 0)
                            {
                                Console.WriteLine("Вы не стали кормить вашего питомца.");
                            }
                            Console.WriteLine("Текущее состояние питомца: ");
                            p.Say();
                            p.HealthCheckUp();
                            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить.");
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        foreach (Animal p in pet)
                        {
                            string? input2 = "";
                            int punchCount = 0;
                            p.Say();
                            p.HealthCheckUp();
                            Console.WriteLine("\nХотите наказать этого питомца? " +
                                "Если да, то введите занчение от 1 до 100, если нет - выберете 0");
                            input2 = Console.ReadLine();
                            while (!int.TryParse(input2, out punchCount) || punchCount < 0 || punchCount > 100)
                            {
                                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
                                input = Console.ReadLine();
                            }
                            p.Punish(punchCount);
                            if (punchCount > 0)
                            {
                                Console.WriteLine("Вы наказали своего питомца.");
                            }
                            else if (punchCount == 0)
                            {
                                Console.WriteLine("Вы не стали наказывать вашего питомца.");
                            }
                            Console.WriteLine("Текущее состояние питомца: ");
                            p.Say();
                            p.HealthCheckUp();
                            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить.");
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                        break;
                    case "4":
                        foreach (Animal p in pet)
                        {
                            string? input3 = "";

                            if (!string.IsNullOrEmpty(p.GetName()))
                            {
                                Console.WriteLine($"Имя {p} уже задано. Имя питомца {p.GetName()}");
                                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить.");
                                Console.WriteLine();
                                Console.ReadKey();
                                continue;                                
                            }
                            else
                            {
                                do
                                {
                                    Console.WriteLine($"Введите имя для {p}");
                                    input3 = Console.ReadLine();

                                    if (string.IsNullOrEmpty(input3))
                                    {
                                        Console.WriteLine("Имя не может быть пустым. Пожалуйста, введите имя.");
                                    }
                                } while (string.IsNullOrEmpty(input3));

                                p.SetName(input3);
                            }
                            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить.");
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте еще.");
                        Console.ReadKey();
                        break;
                }
            }
            ;
        }
    }
}