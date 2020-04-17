using System;
using System.Text.RegularExpressions;
namespace Lab4.Ind._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text=Console.ReadLine();
            Regex regex = new Regex(@"\(\d{3}\)\d{3}-?\d{2}-?\d{2}");
            MatchCollection numbers = regex.Matches(text);
            if (numbers.Count > 0)
            {
                foreach (Match match in numbers)
                    Console.Write(match.Value + "; ");
            }
            Console.ReadKey();
        }
    }
}
