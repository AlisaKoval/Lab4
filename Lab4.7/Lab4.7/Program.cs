using System;

namespace Lab4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] PlayList = new string[10];
            PlayList[0] = "Gentle Giant - Free Hand [06:15]";
            PlayList[1] = "Supertramp - Child Of Vision [07:27]";
            PlayList[2] = "Camel - Lawrence [10:46]";
            PlayList[3] = "Yes - Don't Kill The Whale [03:55]";
            PlayList[4] = "1OCC - Notell Hotel [04:58]";
            PlayList[5] = "Nektar - King Of Twilinght [04:16]";
            PlayList[6] = "The Flower Kings - Monsters & Men [21:19]";
            PlayList[7] = "Focus - Le Clochard [01:59]";
            PlayList[8] = "Pendragon - Fallen Dream And Angel [05:23]";
            PlayList[9] = "Kaipa - Remains Of The Day (08:02)";
            int sum = 0;
            int[] time = new int[10];
            for (int i=0;i<PlayList.Length;i++)
            {
                string List = PlayList[i];
                int indexMin = PlayList[i].IndexOf(':') - 1;
                string minstring = Convert.ToString(List[indexMin-1]) + Convert.ToString( List[indexMin]);
               int  minut = int.Parse(minstring);
                minut *= 60;
                int indexSec = PlayList[i].IndexOf(':') + 1;
                string secstring = Convert.ToString(List[indexSec]) + Convert.ToString(List[indexSec + 1]);
                int sec = int.Parse(secstring);
                sum = sum+ minut+sec;
                time[i] = minut + sec;
            }
            Console.WriteLine("Время звучания песен={0}ч {1}мин {2}сек", sum / 3600, sum/60 - sum / 3600 * 60,sum - sum / 60 * 60);
            int min = 100;
            int max = 0;
            int IndexMax = 0;
            int IndexMin = 0;
            for(int i=0;i<PlayList.Length;i++)
            {
                string List = PlayList[i];
                int indexMin = PlayList[i].IndexOf(':') - 1;
                string minstring = Convert.ToString(List[indexMin - 1]) + Convert.ToString(List[indexMin]);
                int minute = int.Parse(minstring);
                if(minute<min)
                {
                    min = minute;
                    IndexMin = i;
                }
                if (minute>max)
                {
                    max = minute;
                    IndexMax = i;
                }
            }
            Console.WriteLine("Самая короткая песня:{0}; Самая длинная песня:{1}", PlayList[IndexMin], PlayList[IndexMax]);
            int differance = 100;
            int song1 = 0;
            int song2 = 0;
            for(int i=0;i<time.Length;i++)
            {
                for(int j=0; j<time.Length;j++)
                {
                    if(i==j)
                    {
                        continue;
                    }
                    if(Math.Abs(time[i]-time[j])<differance)
                    {
                        differance = Math.Abs(time[i] - time[j]);
                        song1 = i;
                        song2 = j;
                    }
                }
            }
            Console.WriteLine("Песни с минимальной разницей во времени звучания: {0}  и  {1}", PlayList[song1], PlayList[song2]);
            Console.ReadKey();
        }

    }
}
