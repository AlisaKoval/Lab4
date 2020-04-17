using System;

namespace gronsfeld
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
            for (int i = 0, j = 0; i < startText.Length; i++, j++)
            {
                if (j == startkey.Length)
                {
                    j = 0;
                }
                finKey += startkey[j];
            }
            string finText = "";
            int startIndex = 0;
            int shift = 0;
            for (int i = 0; i < startText.Length; i++)
            {
                startIndex = ABC.IndexOf(startText[i]);
                shift = int.Parse(finKey[i].ToString());
                if (startIndex + shift < ABC.Length)
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
                finIndex = ABC.IndexOf(text[i]);
                shift1 = int.Parse(key[i].ToString());
                if (finIndex - shift1 >= 0)
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
        }
    }
}
