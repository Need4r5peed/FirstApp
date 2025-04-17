using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstApp.Module9.Unit6.Task962
{
    // Добавляем новое исключение
    public class ExitRequestedException_Task962: FormatException
    {
        public string ExitRequestedInputString { get; }

        public ExitRequestedException_Task962(string yourInput, string yourTextOfException) :
            base($"Вы ввели: {yourInput}. Запрос пользователя: {yourTextOfException}!")
            => ExitRequestedInputString = yourInput;
    }

    public static class ExitRequestedExpertiseException_Task962
    {
        public static void Expertise(string yourInput)
        {
            if (yourInput.ToLower() == "q" || yourInput.ToLower() == "й")
                throw new ExitRequestedException_Task962(yourInput, "выход");
        }
    }

    public class EmergencyInputStringLocalException_Task962 : FormatException
    {
        //Свойство с модификатором общего доступа, хранящее строковое значение "Проблемный строковый ввод",
        //выполняющее доступ к получению этого значения.
        public string EmergencyInputString { get; }

        //Конструктор с общим модификаторо доступа, принимающий строковый параметр "Ввод и строковый параметр "Исключение",
        //инициализирующий свойство "Проблемный строковый ввод".
        //Возвращает базовое сообщение из свойства "Message"
        public EmergencyInputStringLocalException_Task962(string yourInput, string yourTextOfException)
            : base(FormatMessage(yourInput, yourTextOfException))
            => EmergencyInputString = yourInput;
        //Статический метод с общим модификаторо доступа,принимающий строковый параметр "Ввод и строковый параметр "Исключение",
        //выполняющий комплектацию сообщения для свойства "Message".
        //Возвращает строковое значение созданного сообщения.
        private static string FormatMessage(string input, string error)
        {
            // 1) Создаём объект StackTrace, который захватывает текущий стек вызовов (состоящий из стековых кадров (stack frame)).
            var stackTrace = new StackTrace();
            // 2) Выполняем поиск нужного кадра (с методом - где произошло исключение)
            for (int i = 0; i < stackTrace.FrameCount; i++)
            {
            // 2) Берём 1-й кадр (0 кадр - текущий кадр или последний вызов)
                var frame = stackTrace.GetFrame(i);
            // 4) Получаем MethodInfo из кадра стека (может быть null, если стек недоступен).
                var method = frame?.GetMethod();
            // 5) Извлекаем имя метода или "unknown", если метод неизвестен.
                string methodName = method?.Name ?? "unknown";
            // 6) Извлекаем имя класса или "unknown", если метод неизвестен.
                string className = method?.DeclaringType?.Name ?? "unknown";

            // 7) Фильтр. Пропускаем служебные методы, конструкторы и системные классы
                if (methodName == ".ctor" || methodName == "Throw" || className.Contains("System"))
                    continue;
            // 8) Создаём и возвращаем сообщение из полученных данных
                return $"В методе \"{className}.{methodName}\" вы ввели: {input}. Ошибка: {error}!";
            }

            // 9) Запасной вариант: создаём и возвращаем сообщение из данных, если поиск не дал результатаов
            return $"В методе \"{"unknown"}.{"unknown"}\" вы ввели: {input}. Ошибка: {error}!";
        }
    }

    public class EmergencyInputNumberLocalException_Task962 : FormatException
    {
        public int EmergencyInputNumber { get; }

        public EmergencyInputNumberLocalException_Task962(int yourInput, string yourTextOfException)
            : base(FormatMessage(yourInput, yourTextOfException))
            => EmergencyInputNumber = yourInput;

        private static string FormatMessage(int input, string error)
        {
            // 1) Создаём объект StackTrace, который захватывает текущий стек вызовов (состоящий из стековых кадров (stack frame)).
            var stackTrace = new StackTrace();
            // 2) Выполняем поиск нужного кадра (с методом - где произошло исключение)
            for (int i = 0; i < stackTrace.FrameCount; i++)
            {
                // 2) Берём 1-й кадр (0 кадр - текущий кадр или последний вызов)
                var frame = stackTrace.GetFrame(i);
                // 4) Получаем MethodInfo из кадра стека (может быть null, если стек недоступен).
                var method = frame?.GetMethod();
                // 5) Извлекаем имя метода или "unknown", если метод неизвестен.
                string methodName = method?.Name ?? "unknown";
                // 6) Извлекаем имя класса или "unknown", если метод неизвестен.
                string className = method?.DeclaringType?.Name ?? "unknown";

                // 7) Фильтр. Пропускаем служебные методы, конструкторы и системные классы
                if (methodName == ".ctor" || methodName == "Throw" || className.Contains("System"))
                    continue;
                // 8) Создаём и возвращаем сообщение из полученных данных
                return $"В методе \"{className}.{methodName}\" вы ввели: {input}. Ошибка: {error}!";
            }

            // 9) Запасной вариант: создаём и возвращаем сообщение из данных, если поиск не дал результатаов
            return $"В методе \"{"unknown"}.{"unknown"}\" вы ввели: {input}. Ошибка: {error}!";
        }
    }

    // Класс начальной проверки ввода строки
    public static class EmergencyInputStringOrIntExpertiseException_Task962
    {
        public static void Expertise(string yourInput)
        {
            try
            {
                // Правило 1:
                if (string.IsNullOrWhiteSpace(yourInput))
                    throw new EmergencyInputStringLocalException_Task962(
                        yourInput, 
                        "Слишком пусто"
                        );

                // Правило 2:
                if (yourInput.Any(char.IsWhiteSpace))
                    throw new EmergencyInputStringLocalException_Task962(
                        yourInput, 
                        "Содержит пробельные символы"
                        );

                // Правило 3:
                var forbiddenChars = new[] { ',', '.', '\"', '\'', '/', '|', '\\', '<', '>', '?', '!' };
                if (yourInput.Any(c => forbiddenChars.Contains(c)))
                    throw new EmergencyInputStringLocalException_Task962(
                        yourInput, 
                        $"Содержит запрещённые символы: {forbiddenChars}"
                        );

                // Правило 4:
                if (!yourInput.Any(char.IsDigit))
                    throw new EmergencyInputStringLocalException_Task962(
                        yourInput, 
                        "Нет цифр"
                        );

                // Правило 5:
                if (yourInput.Any(char.IsDigit) && yourInput.Contains(' '))
                    throw new EmergencyInputStringLocalException_Task962(
                        yourInput, 
                        "Цифры с пробелами"
                        );
            }
            catch (Exception ex) when (ex is not EmergencyInputStringLocalException_Task962)
            {
                throw new FormatException("Непредвиденная ошибка при обработке ввода", ex);
            }

        }
    }

    // Класс проверки ввода числа
    public static class EmergencyInputNumberExpertiseException_Task962
    {
        public static void Expertise(int yourInput)
        {
            // Правило 1:
            if (yourInput == 1 || yourInput == 2)
                return;

            // Правило 2:
            if (yourInput == 0)
                throw new EmergencyInputNumberLocalException_Task962(
                    yourInput,
                    "Вы ввели 0"
                    );

            // Правило 3:
            if (yourInput >= 3 && yourInput <= 9)
                throw new EmergencyInputNumberLocalException_Task962(
                    yourInput,
                    "Не та цифра"
                    );

            // Правило 4:
            if (yourInput >= -9 && yourInput <= -1)
                throw new EmergencyInputNumberLocalException_Task962(
                    yourInput, "" +
                    "Вы ввели отрицательное число"
                    );

            // Правило 5:
            throw new EmergencyInputNumberLocalException_Task962(
                yourInput,
                "Ваш ввод содержит слишком длинное число"
                );
        }
    }
}

