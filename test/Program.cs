using System;
using System.Text;

namespace test
{
    class Program
    {
		static void Main()
		{
			Console.WriteLine("Введите строку: ");
			StringBuilder a = new StringBuilder(Console.ReadLine());
			Console.WriteLine("Исходная строка: " + a);
			Console.WriteLine("Введите заданныe подстроку: ");
			string x = Console.ReadLine();
			for (int i = 0; i < a.Length;)
				if (char.IsPunctuation(a[i])) a.Remove(i, 1);
				else ++i;
			string str = a.ToString();
			str = str.Trim();
			string[] s = str.Split(' ');
			Console.WriteLine("Искомые слова: ");
			for (int i = 0; i < s.Length; ++i)
				if (s[i].IndexOf(x) != -1) Console.WriteLine(s[i]);
		}

	}
}
