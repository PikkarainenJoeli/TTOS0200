using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht3
    {
        

        public static void SumAndAverage()
        {
            int[] numbers;
            int sum;
            int average;
            sum = 0;
            numbers = new int[3];
            Console.WriteLine("Anna kolme numeroa:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                sum += numbers[i];
            }
            average = sum / numbers.Length;

            Console.WriteLine("Summa: " + sum + " Keskiarvo: " + average);

        }

        

    }
}
