// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно
// ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

using System;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        // Устанавка кодировки консоли на UTF-8
        Console.OutputEncoding = Encoding.UTF8;

        string[] initialArray;

        while (true)
        {
            Console.WriteLine("Введите строки для массива, разделенные запятой:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ошибка! Ввод не должен быть пустым. Попробуйте снова.");
                continue;
            }

            // Разделение данных в массиве запятыми
            initialArray = input.Split(',');

            // Убираем пробелы в начале и конце каждой строки, если они есть
            for (int i = 0; i < initialArray.Length; i++)
            {
                initialArray[i] = initialArray[i].Trim();
            }

            // Проверка на пустой массив после удаления пробелов
            if (initialArray.Length == 0 || (initialArray.Length == 1 && initialArray[0] == ""))
            {
                Console.WriteLine("Ошибка! Массив не должен быть пустым. Попробуйте снова.");
            }
            else
            {
                break;
            }
        }

        // Определяем размер нового массива
        int count = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера и заполняем его
        string[] resultArray = new string[count];
        int index = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                resultArray[index] = initialArray[i];
                index++;
            }
        }

        // Выводим результат
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Новый массив данных, длина которых < или = 3 символам:");
        Console.WriteLine("[" + string.Join(", ", resultArray) + "]");
        Console.WriteLine("-------------------------------------------------------");
    }
}