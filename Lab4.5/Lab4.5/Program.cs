using System;
using System.Text.RegularExpressions;
namespace Lab4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine("The first way");
            string[] word = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i=0;i<word.Length;i++)
            {
                
                
                    if (char.IsUpper(word[i][0]) && char.IsDigit(word[i][word[i].Length - 1]) && char.IsDigit(word[i][word[i].Length - 2]))
                    {
                        Console.Write(word[i] + ", ");
                    }
                
            }
            Console.WriteLine();
            Console.WriteLine("The second way");
            Regex regex = new Regex(@"\b[A-Z]\w*[0-9]{2}\b");
            MatchCollection words = regex.Matches(text);
            if (words.Count>0)
            {
                foreach (Match match in words)
                    Console.Write(match.Value + ", ");
            }
            Console.ReadKey();
        }

    }
}
