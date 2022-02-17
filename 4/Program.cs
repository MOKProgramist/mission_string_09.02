using System;
using System.Linq;
using static System.Console;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание: вывести слова которые содержат цифру

            Console.WriteLine("Введите предложение: ");
            // уюираем из строки эти символы и записываем в массив. пропускаем из записи пробелы, чтобы не было проблем дальше
            string[] textArray = Console.ReadLine().Split(' ', ',', '.', '-', '!', '?');

            Console.WriteLine("\nВот что я нашел: ");

            for (int i = 0; i < textArray.Length; i++)
            {
                // разбиваем слово на символы
                foreach (char arg in textArray[i])
                {
                    if (char.IsNumber(arg))
                    {
                        WriteLine(textArray[i]);
                        break;
                    }
                }
            }

            ReadLine();
        }
    }
}
