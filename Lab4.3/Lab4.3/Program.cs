using System;

namespace Lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first way");
            int n = 0;
            string text = Console.ReadLine() + " ";
            
            char[] newtext= new char[text.Length];
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    for (int j = 0; n < newtext.Length - i - 1; j++)
                    {
                        newtext[n] = text[i + j];
                        n++;
                    }
                }
                else if (text[i - 1] == ' ')
                {
                    for (int j = 0; n < newtext.Length - i - 1; j++)
                    {
                        if (n == newtext.Length - 1)
                        {
                            break;
                        }
                        if (text[i + j] == '.')
                        {
                            newtext[n] = text[i + j + 1];
                            newtext[newtext.Length - 1] = text[i + j];
                            n++;
                            break;
                        }
                        newtext[n] = text[i + j];
                        n++;
                    }
                }



            }
            for (int i = 0; i < newtext.Length; i++)
            {
                Console.Write(newtext[i]);
            }
            Console.WriteLine();
            Console.WriteLine("The second way");
            string[] text1 = text.Split(' ','.');
            String[] newstring = new string[text1.Length];
            
                for (int j = 0; j < text1.Length; j++)
                {
                    newstring[j] = text1[text1.Length-1-j];
                    
                }
            
            string newText = string.Join(" ", newstring);
            Console.WriteLine(newtext);
            Console.ReadKey();
        }
    }
}
