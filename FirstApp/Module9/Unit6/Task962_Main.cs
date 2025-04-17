using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp.Module9.Unit6.Task962
{
    public class Main_Task962
    {
        public static void Main()
        {
            List<string> namesOfEmployeesList = new List<string>();
            namesOfEmployeesList.Add("Егоров");
            namesOfEmployeesList.Add("Смирнов");
            namesOfEmployeesList.Add("Виноградов");
            namesOfEmployeesList.Add("Ярцев");
            namesOfEmployeesList.Add("Орехин");
            namesOfEmployeesList.Add("Груздев");
            namesOfEmployeesList.Add("Сизых");
            namesOfEmployeesList.Add("Петренко");
            namesOfEmployeesList.Add("Перов");
            namesOfEmployeesList.Add("Павловский");
            namesOfEmployeesList.Add("Орих");
            namesOfEmployeesList.Add("Сизов");
            namesOfEmployeesList.Add("Груздев");
            namesOfEmployeesList.Add("Петров-Даль");

            NumberReader_Task962 numberReader = new NumberReader_Task962();
            numberReader.NumberEnteredEvent += ShowNumber;

            while (true)
            {
                try
                {
                    numberReader.Read(namesOfEmployeesList);
                }
                catch (ExitRequestedException_Task962 ex)
                {
                    Console.WriteLine(ex.Message); // "Вы ввели: q. Запрос пользователя: выход!"
                    return; // Выходим из метода и цикла
                }
                catch (EmergencyInputStringLocalException_Task962 ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (EmergencyInputNumberLocalException_Task962 ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
            }

            Console.WriteLine("Программа завершена...");
        }

        static void ShowNumber(int number, List<string> list)
        {
            //Console.Clear();

            switch (number)
            {
                case 1:
                    Console.WriteLine("Введено значение: 1. Выбран 1-й вариант сортировки списка: от А до Я");
                    list.Sort();
                    Console.WriteLine("Первый вариант сортировки выполнен!");
                    break;
                case 2:
                    Console.WriteLine("Введено значение: 2. Выбран 2-й вариант сортировки списка: от Я до А");
                    list.Sort();
                    list.Reverse();
                    Console.WriteLine("Второй вариант сортировки выполнен!");
                    break;
            }

            // Выводим список после сортировки
            Console.WriteLine("nРезультат сортировки: ");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }
    }

    class NumberReader_Task962
    {
        public delegate void NumberEnteredDelegate_Task962(int number, List<string> list);
        public event NumberEnteredDelegate_Task962 NumberEnteredEvent;

        internal void Read(List<string> list)
        {

            Console.WriteLine();
            Console.WriteLine("Необходимо ввести значение, либо \"1\", либо \"2\" (если нужно выйти из дальнейшего выполнения задания - введите \"q\")");

            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number != 1 && number != 2) throw new FormatException();
            string input = Console.ReadLine();
            ExitRequestedExpertiseException_Task962.Expertise(input);
            EmergencyInputStringOrIntExpertiseException_Task962.Expertise(input);
            int number = Convert.ToInt32(input);
            EmergencyInputNumberExpertiseException_Task962.Expertise(number);

            NumberEntered(number, list);
        }

        protected virtual void NumberEntered(int number, List<string> list)
        {
            NumberEnteredEvent?.Invoke(number, list);
        }
    }
}

