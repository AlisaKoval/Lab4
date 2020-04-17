using System;

namespace Lab4.Ind._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ABC = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            Console.WriteLine("Шифр Гронсфельда");
            Console.WriteLine("Введите текст");
            string startText = Console.ReadLine();
            bool enterKey = true;
            string startkey = "";
            do
            {
                Console.WriteLine("Введите ключ(из цифр)");
                 startkey = Console.ReadLine();
                if (int.Parse(startkey) == 0)
                {
                    Console.WriteLine("Ключ не должен быть равен нулю");
                }
                if (startkey.Length > startText.Length)
                {
                    startkey = startkey.Substring(0, startText.Length);
                }
                if (int.Parse(startkey) > 0)
                {
                    enterKey = false;
                }
            } while (enterKey == true);
            string finKey = "";
            for (int i =0,j=0;i<startText.Length;i++,j++)
            {
                if (j==startkey.Length)
                {
                    j = 0;
                }
                finKey += startkey[j];
            }
            string finText = "";
            int startIndex = 0;
            int shift = 0;
            for(int i=0;i<startText.Length;i++)
            {
                startIndex = ABC.IndexOf(startText[i]);
                shift = int.Parse(finKey[i].ToString());
                if( startIndex+shift<ABC.Length)
                {
                    finText += ABC[startIndex + shift];
                }
                else
                {
                    finText += ABC[startIndex + shift - ABC.Length];
                }
            }
            Console.WriteLine("Ваш текст:{0} \nВаш ключ:{1}", finText, finKey);
            Console.WriteLine("Введите зашифрованный текст");
            string text = Console.ReadLine();
            Console.WriteLine("Ввелите ключ(из цифр)");
            string key = Console.ReadLine();
            string firstText = "";
            int finIndex = 0;
            int shift1 = 0;
            for (int i = 0; i < text.Length; i++)
            {
                finIndex= ABC.IndexOf(text[i]);
                shift1 = int.Parse(key[i].ToString());
                if (finIndex - shift1 >=0)
                {
                    firstText += ABC[finIndex - shift1];
                }
                else
                {
                    firstText += ABC[finIndex - shift1 + ABC.Length];
                }
            }
            Console.WriteLine("Расшифрованный текст:{0}", firstText);
            Console.WriteLine();
            Console.WriteLine("Шифр Цезаря");
            Console.WriteLine("Введите текст");
            string Text = Console.ReadLine();
            enterKey = true;
            int Key = 0;
            do
            {
                Console.WriteLine("Введите ключ(число)");
                 Key = int.Parse(Console.ReadLine());
                if (Key == 0|| Key==32)
                {
                    Console.WriteLine("Ключ не должен быть равен нулю или количеству всех букв алфавита");
                }
                if (Key > 0)
                {
                    enterKey = false;
                }
            } while (enterKey == true);
            string fin_text = "";
            int start_Index = 0;
           
            for (int i = 0; i <Text.Length; i++)
            {
                start_Index = ABC.IndexOf(Text[i]);
                
                if (start_Index +Key < ABC.Length)
                {
                    fin_text += ABC[start_Index + Key];
                }
                else
                {
                    fin_text += ABC[start_Index + Key - ABC.Length];
                }
            }
            Console.WriteLine("Ваш текст:{0} \nВаш ключ:{1}", fin_text,Key);
            Console.WriteLine("Введите зашифрованный текст");
            string oldtext = Console.ReadLine();
            Console.WriteLine("Ввелите ключ(из цифр)");
            int oldkey = int.Parse(Console.ReadLine());
            string oldText = "";
            int fin_Index = 0;
           
            for (int i = 0; i < oldtext.Length; i++)
            {
                fin_Index = ABC.IndexOf(oldtext[i]);
               
                if (fin_Index - oldkey >= 0)
                {
                    oldText += ABC[fin_Index - oldkey];
                }
                else
                {
                    oldText += ABC[fin_Index -oldkey + ABC.Length];
                }
            }
            Console.WriteLine("Расшифрованный текст:{0}", oldText);
            Console.WriteLine();
            Console.WriteLine("Шифр Полибия");
            Console.WriteLine("Введите текст:");
            string text1 = Console.ReadLine();
            
            string newABC = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя123";
            
            char[,] square = new char[6, 6];
            int index = 0;
            for (int i = 0; i < 6 ;i++)
            {
                for (int j=0;j<6;j++)
                {
                    if ( index<newABC.Length)
                    {
                        square[i, j] = newABC[index];
                        index++;
                    }
                }
            }
            string fintext1 = "";
            for (int k = 0; k < text1.Length; k++)
            {
                for (int i=0;i<6;i++)
                {

                    for (int j = 0; j < 6; j++)
                    {
                        if (square[i, j] == text1[k])
                        {
                            if (i == 5)
                            {
                                i = 0;
                            }
                            fintext1 += square[i+1,j];
                        }
                       
                    }
                }
            }          
            Console.WriteLine("Зашифрованный текст:{0}",fintext1);
            Console.WriteLine("Введите зашифрованный текст:");
            string newtext1 = Console.ReadLine();
            string oldtext1 = "";
            for (int k = 0; k < text1.Length; k++)
            {
                for (int i = 0; i < 6; i++)
                {

                    for (int j = 0; j < 6; j++)
                    {
                        if (square[i, j] == newtext1[k])
                        {
                            if (i == 0)
                            {
                                i = 5;
                            }
                            oldtext1 += square[i - 1, j];
                        }

                    }
                }
            }
            Console.WriteLine("Расшифрованный текст:{0}", oldtext1);
            Console.ReadKey();

        }

    }
}
