using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht5
    {
        public static void SecondsToHMS(){
            int seconds;

            
            Console.WriteLine("Anna aika sekunteina: ");
            seconds = int.Parse(Console.ReadLine());

            TimeSpan time = TimeSpan.FromSeconds(seconds);

            string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s", time.Hours, time.Minutes, time.Seconds);
            Console.WriteLine(answer);


        }
    }
}
