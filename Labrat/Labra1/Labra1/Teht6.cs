using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht6
    {
        public static void FuelCalculator()
        {
            double distance;
            double fuel;
            double price;
            const double usagePer100 = 7.2;
            const double pricePerLiter = 5.595;
            Console.WriteLine("Ajettu matka: ");
            
            distance = float.Parse(Console.ReadLine());

            fuel = distance / 100 * usagePer100;
            Console.WriteLine(fuel);

 
            price = fuel * pricePerLiter;
           
            Console.WriteLine("Bensaa Kului: " + fuel + " l  Maksoi:" + price + " e");


        }

    }
}
