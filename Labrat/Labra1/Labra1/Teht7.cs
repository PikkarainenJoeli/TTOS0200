using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht7
    {
        public static void LeapYear()
        {
            int year;
            bool isLeapYear;
            isLeapYear = false;
            Console.WriteLine("Vuosi luku:");
            year = int.Parse(Console.ReadLine());

            //Console.WriteLine(year % 4);
            //Console.WriteLine(year % 100);
           // Console.WriteLine(year % 400);
            
            if ((year % 4 == 0 && year % 100 != 0)||(year % 400 == 0))
            {
                isLeapYear = true;
            }
            else
            {
                isLeapYear = false;
            }
           
            

            Console.WriteLine(isLeapYear);
        }
    }
}
