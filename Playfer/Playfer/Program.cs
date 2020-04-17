using System;
using System.Text;
namespace Playfer
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] matrix = new char[25] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Введите кодовое слово:");
            string password = Console.ReadLine();
            string newPassword = "";
            for (int i = 0; i < password.Length; i++)
            {
                char[] charNew = new char[password.Length];
                charNew[i] = password[i];
                if (password.IndexOfAny(charNew) > i || password.IndexOfAny(charNew) < i)
                {
                    continue;
                }
                else
                {
                    newPassword += password[i];
                }
            }
            int n = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < newPassword.Length; j++)
                {

                    if (matrix[i] == newPassword[j])
                    {
                        n++;
                        int t = i;
                        while (t < matrix.Length - n)
                        {

                            matrix[t] = matrix[t + 1];
                            t++;
                        }
                    }
                }
            }
            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                if (i >= newPassword.Length)
                {
                    matrix[i] = matrix[i - newPassword.Length];
                }
                else
                {
                    matrix[i] = newPassword[i];
                }
            }
            char[,] resMatrix = new char[5, 5];
            int k = 0;
            for (int i = 0; i < resMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resMatrix.GetLength(1); j++)
                {

                    resMatrix[i, j] = matrix[k];
                    k++;
                   
                }
            }
            Console.WriteLine("Введите текст для шифрования:");
            string text = Console.ReadLine();
            text = text.Replace(" ", "");
            if (text.Length / 2 == 1)
            {
                text = text + "x";
            }
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newText += text[i];
                }
                else
                {
                    if (i == text.Length - 1)
                    {
                        newText = newText + text[i];
                    }
                    else
                    {
                        newText = newText + text[i] + " ";

                    }
                }
            }

            string[] bin = newText.Split(' ');
            for (int i = 0; i < bin.Length; i++)
            {
                if (bin[i][0] == bin[i][1])
                {
                    bin[i] = bin[i][0] + "x";
                }
            }
            int index_i0 = 0;
            int index_i1 = 0;
            int index_j0 = 0;
            int index_j1 = 0;
            char[,] resBin = new char[bin.Length, 2];
            for (int f = 0; f < bin.Length; f++)
            {
                for (int i = 0; i < resMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resMatrix.GetLength(1); j++)
                    {
                        if (bin[f][0] == resMatrix[i, j])
                        {
                            index_i0 = i;
                            index_j0 = j;
                        }
                        if (bin[f][1] == resMatrix[i, j])
                        {
                            index_i1 = i;
                            index_j1 = j;
                        }
                    }
                }


                if (index_i0 == index_i1)
                {
                    if (index_j0 == 4)
                    {
                        index_j0 = -1;
                    }
                    if (index_j1 == 4)
                    {
                        index_j1 = -1;
                    }
                    resBin[f, 0] = resMatrix[index_i0, index_j0 + 1];
                    resBin[f, 1] = resMatrix[index_i1, index_j1 + 1];
                }
                else if (index_j0 == index_j1)
                {
                    if (index_i0 == 4)
                    {
                        index_i0 = -1;
                    }
                    if (index_j1 == 4)
                    {
                        index_j1 = -1;
                    }
                    resBin[f, 0] = resMatrix[index_i0 + 1, index_j0];
                    resBin[f, 1] = resMatrix[index_i1 + 1, index_j1];
                }
                else
                {
                    resBin[f, 0] = resMatrix[index_i0, index_j1];
                    resBin[f, 1] = resMatrix[index_i1, index_j0];

                }
            }
        
            string kod = "";
            for(int i=0;i<resBin.GetLength(0);i++)
            {
                for(int j=0;j<resBin.GetLength(1);j++)
                {
                    kod = kod + resBin[i, j];
                }
            }
            Console.WriteLine("Зашифрованный текст: {0}",kod);
            Console.WriteLine();
            Console.WriteLine("Введите зашифрованный текст");
            string oldKod = Console.ReadLine();
            string newOldKod = "";
            for (int i = 0; i < oldKod.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newOldKod += oldKod[i];
                }
                else
                {
                    if (i == oldKod.Length - 1)
                    {
                        newOldKod = newOldKod + oldKod[i];
                    }
                    else
                    {
                        newOldKod = newOldKod + oldKod[i] + " ";

                    }
                }
            }
            matrix= new char[25]{ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Введите кодовое слово:");
            string oldPassword = Console.ReadLine();
            string newOldPassword = "";
            for (int i = 0; i < oldPassword.Length; i++)
            {
                char[] charNew = new char[oldPassword.Length];
                charNew[i] = oldPassword[i];
                if (oldPassword.IndexOfAny(charNew) > i || oldPassword.IndexOfAny(charNew) < i)
                {
                    continue;
                }
                else
                {
                    newOldPassword += oldPassword[i];
                }
            }
            int n0 = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < newOldPassword.Length; j++)
                {

                    if (matrix[i] == newOldPassword[j])
                    {
                        n0++;
                        int t = i;
                        while (t < matrix.Length - n0)
                        {

                            matrix[t] = matrix[t + 1];
                            t++;
                        }
                    }
                }
            }
            for (int i = matrix.Length - 1; i >= 0; i--)
            {
                if (i >= newOldPassword.Length)
                {
                    matrix[i] = matrix[i - newOldPassword.Length];
                }
                else
                {
                    matrix[i] = newOldPassword[i];
                }
            }
            char[,] oldResMatrix = new char[5, 5];
            int k0 = 0;
            for (int i = 0; i < oldResMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < oldResMatrix.GetLength(1); j++)
                {

                    oldResMatrix[i, j] = matrix[k0];
                    k0++;

                }
            }
            string[] oldBin = newOldKod.Split(' ');
           
            int oldIndex_i0 = 0;
            int oldIndex_i1 = 0;
            int oldIndex_j0 = 0;
            int oldIndex_j1 = 0;
            char[,] resText = new char[oldBin.Length, 2];
            for (int f = 0; f < oldBin.Length; f++)
            {
                for (int i = 0; i < oldResMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < oldResMatrix.GetLength(1); j++)
                    {
                        if (oldBin[f][0] == oldResMatrix[i, j])
                        {
                            oldIndex_i0 = i;
                            oldIndex_j0 = j;
                        }
                        if (oldBin[f][1] == oldResMatrix[i, j])
                        {
                           oldIndex_i1 = i;
                            oldIndex_j1 = j;
                        }
                    }
                }


                if (oldIndex_i0 == oldIndex_i1)
                {
                    if (oldIndex_j0 == 0)
                    {
                        oldIndex_j0 = 5;
                    }
                    if (oldIndex_j1 == 0)
                    {
                        oldIndex_j1 = 5;
                    }
                    resText[f, 0] = oldResMatrix[oldIndex_i0, oldIndex_j0 - 1];
                    resText[f, 1] = oldResMatrix[oldIndex_i1, oldIndex_j1 - 1];
                }
                else if (oldIndex_j0 == oldIndex_j1)
                {
                    if (oldIndex_i0 == 0)
                    {
                        oldIndex_i0 = 5;
                    }
                    if (oldIndex_j1 == 0)
                    {
                        oldIndex_j1 = 5;
                    }
                    resText[f, 0] = oldResMatrix[oldIndex_i0 - 1, oldIndex_j0];
                    resText[f, 1] = oldResMatrix[oldIndex_i1 - 1, oldIndex_j1];
                }
                else
                {
                    resText[f, 0] = oldResMatrix[oldIndex_i0, oldIndex_j1];
                    resText[f, 1] = oldResMatrix[oldIndex_i1, oldIndex_j0];

                }
            }

            string oldText = "";
            for (int i = 0; i < resText.GetLength(0); i++)
            {
                for (int j = 0; j < resText.GetLength(1); j++)
                {
                    oldText = oldText + resText[i, j];
                }
            }
            Console.WriteLine("Зашифрованный текст: {0}", oldText);
        }
    }
}
