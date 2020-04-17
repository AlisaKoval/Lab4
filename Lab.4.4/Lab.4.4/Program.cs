using System;

namespace Lab._4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k=0;
            string[] text = new string[7];
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = Console.ReadLine()+" ";
            }
            Console.WriteLine("The first way");
            int n=0;
            int min=100;
            for (int i = 0; i < text.Length; i++)
            {
                string text1 = text[i].ToString();
                
                for (int j=1;j<=text1.Length-4;j++)
                {
                    
                    if(text1[j]=='.'&& text1[j+1]=='c'&&text1[j+2]=='o'&& text1[j + 3] == 'm'&&text1[j-1]!=' '||text1[j+1]=='C'||text1[j+2]=='O'||text1[j+3]=='M')
                    {
                        if (j != text1.Length - 4)
                        {
                            if (text1[j + 4] == ' ' || text1[j + 4] == ',' || text1[j + 4] == '.')
                            {
                                Console.WriteLine(text[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine(text[i]);
                        }
                    }
                   
                }
                n = 0;
                for (int l=0;l<text1.Length;l++)
                {
                    
                    if (text1[l] == ' ')
                    {
                        n++;
                    }

                }
                if (n <= min)
                {
                    k = i;
                    min = n;
                }
            }
            Console.WriteLine("min string -- {0}",text[k]);
            Console.WriteLine("The first way");
            int value = 0;
            for(int i=0;i<text.Length;i++)
            {
                value = (text[i].Length - text[i].Replace(" ", "").Length);
                if (value < min)
                {
                    k = i;
                    min = value;
                }
                if(text[i].IndexOf(".com ",StringComparison.OrdinalIgnoreCase)>=0|| text[i].IndexOf(".com,", StringComparison.OrdinalIgnoreCase) >= 0|| text[i].IndexOf(".com.", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    Console.WriteLine(text[i]);
                }
            }
            Console.WriteLine("Min string -- {0}",text[k]);
        }
    }
}
