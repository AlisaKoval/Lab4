using System;

namespace Vernama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для шифрования:");
            string text = Console.ReadLine();
            Console.WriteLine("Введите ключ (длина ключа - длина текста)");
            string key = Console.ReadLine();
            string bintext = "";
            for (int i = 0; i < text.Length; i++)
            {
                bintext = bintext+"0"+ Convert.ToString(text[i], 2);
            }
            string binkey = "";
            for (int i = 0; i < key.Length; i++)
            {
                binkey= binkey+"0"+ Convert.ToString(key[i], 2);
            }
            string binkod = "";
            for (int i = 0; i < bintext.Length; i++)
            {
                if (bintext[i] == binkey[i])
                {
                    binkod += "0";
                }
                else
                {
                    binkod += "1";
                }

            }
            string reskod = "";
            string newbinkod = "";
            for (int i = 0; i < binkod.Length; i++)
            {
                if (i==0)
                {
                    newbinkod += binkod[i];
                }
                else if (i % 8 == 0)
                {
                    newbinkod = newbinkod+" "+binkod[i];
                }
                else
                {
                    newbinkod += binkod[i];
                }
            }
            string[] newbinkod1 = newbinkod.Split(' ');
            for (int i = 0; i < newbinkod1.Length; i++)
            {
                int integer = Convert.ToInt32(newbinkod1[i], 2);
                 reskod = reskod + Convert.ToString(integer) + " ";
            }
            Console.WriteLine("Зашифрованный текст:{0}", reskod);
            Console.WriteLine();
            Console.WriteLine("Введите зашифрованный текст:");
            string oldKodInteger = Console.ReadLine();
            Console.WriteLine("Введите ключ");
            string oldkey = Console.ReadLine();
            string [] oldKodInteger1 = oldKodInteger.Split(' ');
            string oldkodbin = "";
            for (int i = 0; i < oldKodInteger1.Length; i++)
            {
                int integer = Convert.ToInt32(oldKodInteger1[i]);
                string integerstr = Convert.ToString(integer, 2);
                while (integerstr.Length<8)
                {
                    integerstr = "0" + integerstr;
                }
                
                oldkodbin+=integerstr;
            }
            string oldbinkey = "";
            for (int i = 0; i < key.Length; i++)
            {
                oldbinkey = oldbinkey + "0" + Convert.ToString(oldkey[i], 2);
            }
            string oldbinkod = "";
            for (int i = 0; i < oldbinkey.Length; i++)
            {
                if (oldkodbin[i] == oldbinkey[i])
                {
                    oldbinkod += "0";
                }
                else
                {
                    oldbinkod += "1";
                }

            }
            string oldtext = "";
            string oldbinkod1 = "";
            for (int i = 0; i < oldbinkod.Length; i++)
            {
                if (i == 0)
                {
                    oldbinkod1 += oldbinkod[i];
                }
                else if (i % 8 == 0)
                {
                    oldbinkod1 = oldbinkod1 + " " + oldbinkod[i];
                }
                else
                {
                    oldbinkod1 += oldbinkod[i];
                }
            }
            string[] oldbinkod2 = oldbinkod1.Split(' ');
           
            for (int i = 0; i < oldbinkod2.Length; i++)
            {
                int integer = Convert.ToInt32(oldbinkod2[i], 2);
                oldtext = oldtext + Convert.ToChar(integer);
            }
            Console.WriteLine("Расшифрованный текст: {0}", oldtext);
        } 
    }
}
