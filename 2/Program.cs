using System;
using System.Text;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string textArray = Console.ReadLine();

            Console.Write("Введите длину слова (будут выведены слова не больше чем число): ");
            uint lengthWord = uint.Parse(Console.ReadLine());
            // создаем массив по словам отдельным
            string[] msv = textArray.Split(new char[] { ' ', ',', '.', '!', '?', '-' });
            Console.WriteLine("\nВот что я нашел: ");
            foreach (var item in msv)
            {
                // проверка на пустоту и размер слова
                if (item.Length < lengthWord && !String.IsNullOrWhiteSpace(item)) Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
