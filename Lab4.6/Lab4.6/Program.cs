using System;
using System.Text.RegularExpressions;
namespace Lab4._6
{
    class Program
    {
        static void Main(string[] args)
        {
           string text= Console.ReadLine();
            Regex regex = new Regex(@"(-?(?<=[ =+*\/^-])\d+)|(\A\d+)");
            MatchCollection numbers = regex.Matches(text);
            int []num = new int[3];
            
               
                for (int i = 0,count=0; i < 3 && count <numbers.Count; i++, count++)
                {
                    num[i] = int.Parse(numbers[count].Value); 
                   
                }
               
            
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
