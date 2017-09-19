using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht8
    {

        public static void BiggestNum()
        {
            int[] numbers;
            numbers = new int[3];

            int biggestNumber;
            biggestNumber = int.MinValue;
            Console.WriteLine("Anna kolme numeroa:");

            for(int i =0;i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                
                if(numbers[i] > biggestNumber)
                {
                    biggestNumber = numbers[i];
                }
                
            }

            Console.WriteLine("Suurin numero:" + biggestNumber);


        }
    }
}
