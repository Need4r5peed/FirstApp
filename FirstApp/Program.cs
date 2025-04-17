using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Запустите программу, чтоб попасть в меню.

            while (true)
            {
                Console.WriteLine("Какое задание запустить? \n* Ведите номер задания без точек. К примеру, если задание \"9.6.1\", то нужно написать \"961\".");
                Console.WriteLine("Из примера,\n\"9\" - номер модуля;\n\"6\" - номер юнита;\n\"1\" - номер задания в юните.\n");
                Console.WriteLine("** Если вы хотите покинуть данное меню - введите \"q\".\n");
                Console.Write("Ваш ввод: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    // Выход из меню.
                    case "й":
                    case "Й":
                    case "q":
                    case "Q":
                        Console.WriteLine("Результат ввода: \"Нажмите ещё раз любую клавишу - чтобы выйти из консоли.\"\n");
                        break;
                    case "771":
                        // Запуск Задания 7.7.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module7.Unit7.Task771.Main_Task771.Main();
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "811":
                        // Запуск Задания 8.1.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module8.Unit1.Task811.Main_Task811.Main();
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "821":
                        // Запуск Задания 8.2.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module8.Unit2.Task821.Main_Task821.Main();
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "831":
                        // Запуск Задания 8.3.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module8.Unit3.Task831.Main_Task831.Main();
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "841":
                        // Запуск Задания 8.4.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module8.Unit4.Task841.Main_Task841.Main();
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "911":
                        // Запуск Задания 9.1.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module9.Unit1.Task911.Main_Task911.Main();
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "921":
                        // Запуск Задания 9.2.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module9.Unit2.Task921.Main_Task921.Main();
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "931":
                        // Запуск Задания 9.3.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module9.Unit3.Task931.Main_Task931.Main();
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "941":
                        // Запуск Задания 9.4.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module9.Unit4.Task941.Main_Task941.Main();
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "951":
                        // Запуск Задания 9.5.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module9.Unit5.Task951.Main_Task951.Main();
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "961":
                        // Запуск Задания 9.6.1
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module9.Unit6.Task961.Main_Task961.Main(); 
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    case "962":
                        // Запуск Задания 9.6.2
                        Console.Clear();
                        Console.WriteLine($"Результат выполнения задания {string.Join(".", choice.ToCharArray())}: \n");
                        Module9.Unit6.Task962.Main_Task962.Main(); 
                        Console.WriteLine($"\nЗадание {string.Join(".", choice.ToCharArray())} завершено! \n");
                        break;
                    default:
                        Console.WriteLine("Результат ввода: \"Неверный ввод\"\n");
                        break;
                }

                if (choice.ToLower() == "q" || choice.ToLower() == "й")
                {
                    break;
                }

                Console.WriteLine("\n########################################");
                Console.WriteLine("Далее => Нажмите на любую кнопку, чтоб повторить!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

