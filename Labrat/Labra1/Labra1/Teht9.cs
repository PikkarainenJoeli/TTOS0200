using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht9
    {
        public static void Summing()
        {
            int number;
            int sum;
            sum = 0;
            number = 1;
            
            Console.WriteLine("Anna summattavat luvut ja 'nolla' ");

            while (number != 0)
            {
                //Console.WriteLine(sum);

                number = int.Parse(Console.ReadLine());
         
                    sum += number;
                
            }

            Console.WriteLine("summa: " + sum);
        }
    }
}
