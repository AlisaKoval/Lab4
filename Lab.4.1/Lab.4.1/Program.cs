using System;

namespace Lab._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first way");
            string str = Console.ReadLine();
            
            bool yes;
            for (int i = 0; i < str.Length; i++)
            {

                yes = true;
                for (int j = str.Length - 1; j >=0; j--)
                {
                    if (i != j)
                    {
                        if (str[i] == str[j])
                        {
                            yes = false;
                            break;
                        }
                    }
                    
                }
                if (yes)
                {
                    Console.Write(str[i]);
                }
            }    
                Console.WriteLine();
                Console.WriteLine("The second way");
            for (int i = 0; i < str.Length; i++)
            {
                if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
                {
                    Console.Write(str[i]);
                }

            }
            Console.ReadKey();
        }
    }
}
