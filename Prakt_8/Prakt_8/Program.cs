using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Prakt_8
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть текст: ");
            string inputText = Console.ReadLine();

            string pattern = @"\b\d{2}[-./]\d{2}[-./]\d{4}\b";

            Regex regex = new Regex(pattern);

            Match match = regex.Match(inputText);

            if (match.Success)
            {
                Console.WriteLine("Перша знайдена дата в тексті:");
                Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Дати не знайдено в тексті.");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для виходу.");
            Console.ReadKey();
        }
    }
}
