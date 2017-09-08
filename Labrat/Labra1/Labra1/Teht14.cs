using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht14
    {
        public static void CourseStars(){

            Console.WriteLine("Anna kurssi arvostelut: ");
            int[] reviewes = new int[5];

            for(int i = 0;i < reviewes.Length; i++)
            {
                reviewes[i] = int.Parse(Console.ReadLine());
               
                if(reviewes[i] > 5 || reviewes[i] < 0)
                {
                    Console.WriteLine("Arvosteluraja on 0 - 5 ");
                    i--;
                }
            }

            for(int i = 0; i < reviewes.Length; i++)
            {
                
                Console.Write("Arvostelu " + i);

                for (int j = 0; j < reviewes[i]; j++)
                {                 
                    Console.Write("*");
                }

                Console.WriteLine(" ");

            }

            }
    }
}
