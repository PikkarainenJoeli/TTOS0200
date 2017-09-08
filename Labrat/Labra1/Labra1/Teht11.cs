using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht11
    {
        public static void Stars()
        {
            int stars;
            Console.WriteLine("Anna tähtien määrä: ");
            stars = int.Parse(Console.ReadLine());

            for(int i = 0; i < stars; i++)
            {
                

               for(int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
               
            }

        }
    }
}
