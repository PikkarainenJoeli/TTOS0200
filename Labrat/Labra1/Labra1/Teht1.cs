using System;

namespace Labra1
{

    public class Teht1
    {
        public static void ShowNumbers()
        {
            int number;

            Console.WriteLine("Tehtävä 1: Anna numero");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("Numero: " + number + " Yksi");
                    break;
                case 2:
                    Console.WriteLine("Numero: " + number + " Kaksi");
                    break;
                case 3:
                    Console.WriteLine("Numero: " + number + " Kolme");
                    break;
            }
            
        }
    }
}