using System;

namespace Lab._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first way");
            string text = Console.ReadLine();
            int n = 1;
            for (int i = 0; i < text.Length; i++)
            {
                if (i == (text.Length - 1))
                {
                    Console.Write(".");
                    break;
                }
                if (text[i] == ' ' || text[i] == ',' || text[i] == '.' || text[i] == '-')
                {
                    Console.Write(text[i]);
                    continue;
                }
                    if (text[i + 1] == ' ' | text[i + 1] == ',' | text[i + 1] == '.' | text[i+1] == '-' )
                {
                    if (text[i] != ' ' && text[i] != ',' && text[i] != '-' && text[i] != '.')
                    {
                        Console.Write(text[i] + "(" + n + ")");
                        n++;
                    }
                }
                else 
                {
                    Console.Write(text[i]);
                }
               
            }
            Console.WriteLine();
            Console.WriteLine("The second way");
            
            char[] r= { ',', '.', '-' ,' ' };

            for (int i = 0, c = 1; i < text.Length; i = text.IndexOfAny(r, i) + 1)
            {
                if (text[i] == ' ' || text[i] == ',' || text[i] == '.' || text[i] == '-')
                {

                    continue;
                }
                else
                {
                    text = text.Insert(text.IndexOfAny(r, i), "(" + c + ")");
                    c++;
                }
            }   


                Console.WriteLine(text);
            
                Console.ReadKey();
            
        }
    }
}
