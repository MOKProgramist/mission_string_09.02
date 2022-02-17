using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание: вывести слова начинающиеся с прописной буквы (А)

            Console.WriteLine("Введите предложение: ");
            // уюираем из строки эти символы и записываем в массив. пропускаем из записи пробелы, чтобы не было проблем дальше
            string[] textArray = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            // создаем массив по словам отдельным
            // string[] msv = textArray.Split(new char[] { ' ', ',', '.', '!', '?', '-' });
            Console.WriteLine("\nВот что я нашел: ");
            
            for(int i = 0; i < textArray.Length; i++)
            {
                char item = textArray[i][0] ;
                // проверяем прописную букву
                // Console.WriteLine(item);
                if (Char.IsUpper(item)) Console.WriteLine(textArray[i]);
            }

            Console.ReadLine();
        }
    }
}
