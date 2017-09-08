using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht12
    {
        static public void ReversedArray()
        {
            int[] numbers = new int[5];
            Console.WriteLine("Anna viisi lukua");
            for (int i = 0; i < numbers.Length; i++){
                numbers[i] = int.Parse(Console.ReadLine());

            }

            for(int i = 0;i < numbers.Length; i++)
            {
            
                Console.WriteLine(numbers[numbers.Length - i -1]);
            }

        }
    }
}
