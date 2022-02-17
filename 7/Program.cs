using System;
using System.Linq;
using System.Collections.Generic;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку состоящую из слов разделённых пробел  sads ом" );
            string text = (Console.ReadLine());
            List<string> slova = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            int i = 0;
            do
            {
                if (slova[i].Length == 1)
                {
                    slova.RemoveAt(i);
                    --i;
                }
                ++i;
            }
            while (i < slova.Count());
            Console.Write(string.Join(", ", slova));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
