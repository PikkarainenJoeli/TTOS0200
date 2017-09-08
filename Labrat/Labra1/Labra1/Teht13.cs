using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht13
    {
        public static void SkiJumpScore()
        {
            int[] scores = new int[5];
            int smallest;
            int biggest;
            biggest = 0;
            smallest = 0;
            int total;
            total = 0;
            Console.WriteLine("Anna arvostelu pisteet (5): ");

            for(int i = 0; i < scores.Length; i++)
            {
                scores[i] = int.Parse(Console.ReadLine());

                if(i == 0)
                {
                    smallest = scores[i];
                    biggest = scores[i];
                }

                if (scores[i] < smallest)
                {
                    smallest = scores[i];
                }

                if (scores[i] > biggest)
                {
                    biggest = scores[i];
                }

                total += scores[i];
            }
            total = total - biggest - smallest;

            Console.WriteLine("smallest:" + smallest + " biggest:" + biggest + " total:" + total);

        }
    }
}
