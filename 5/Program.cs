using System;
using static System.Console;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            WriteLine("Введите предложение: ");
            // уюираем из строки эти символы и записываем в массив. пропускаем из записи пробелы, чтобы не было проблем дальше
            string[] textArray = Console.ReadLine().Split(' ', ',', '.', '-', '!', '?');

            Write("Введите символ, который будет находить слова (которые содержат его на конце) и удалять: ");
            char removeChar = char.Parse(ReadLine());
            // textArray = textArray.Where(p => p.EndsWith(removeChar)).ToArray();

            Console.WriteLine("\nЭти слова были удалены: ");
            foreach(string text in textArray)
            {
                if(text.EndsWith(removeChar)) WriteLine(text);
            }

            Read();
        }
    }
}
