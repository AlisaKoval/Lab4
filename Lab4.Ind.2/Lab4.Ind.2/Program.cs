using System;


namespace Lab4.Ind._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine("The first way");
            char[] textchar = text.ToCharArray();
            int k = 0;
            char[] letters = "ABCDEFGHIJKLMNOPRSTVUQWXYZ".ToCharArray();
            for (int i = 0; i < textchar.Length; i++)
            {

                if (textchar[i] == ' ' || textchar[i] == ',' || textchar[i] == '.')
                {

                    if (i - k - 1 < 6)
                    {
                        for (int l = 0; l < letters.Length; l++)
                        {
                            if (k == 0 && textchar[0] == letters[l])
                            {
                                textchar[0] = '_';
                            }
                            else if (textchar[k + 1] == letters[l])
                            {
                                textchar[k + 1] = '_';

                            }
                        }



                    }
                    k = i;
                }
            }
            for (int j = 0; j < textchar.Length; j++)
            {
                Console.Write(textchar[j]);
            }
            Console.WriteLine();
            Console.WriteLine("The second way");
            string[] word = text.Split(' ');
            string resultText = "";
            for (int i = 0; i < word.Length; i++)
            {
                char[] wordchar = word[i].ToCharArray();
                if (wordchar.Length < 6&& char.IsUpper(wordchar[0]))
                {
                    wordchar[0] = '_';
                }
                word[i] = string.Join("", wordchar);
                resultText = resultText+ word[i]+" ";
            }
            Console.WriteLine(resultText);
        }
    }
}
