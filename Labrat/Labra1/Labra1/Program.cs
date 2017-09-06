using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Labra1
    {
        public static void Menu()
        {
            int menuSelector;
            Console.Clear();
            Console.WriteLine("Valitse tehtävä numerolla 1-X   0 = Exit");
            Console.WriteLine(1 + " ShowNumbers");
            Console.WriteLine(2 + " CourseGrade");
            Console.WriteLine(3 + " SumAndAverage");
            Console.WriteLine(4 + " AgeGroup");
            Console.WriteLine(5 + " SecondsToHMS");
            Console.WriteLine(6 + " FuelCalculator");

            menuSelector = System.Convert.ToInt32(int.Parse(Console.ReadLine()));




            switch (menuSelector)
            {

                case 0:
                    Console.WriteLine("Mikä tahansa näppäin poistumiseen");
                    Environment.Exit(0);
                    break;

                case 1:
                    Teht1.ShowNumbers();
                    break;

                case 2:
                    Teht2.CourseGrade();
                    break;

                case 3:
                    Teht3.SumAndAverage();
                    break;

                case 4:
                    Teht4.AgeGroup();
                    break;

                case 5:
                    Teht5.SecondsToHMS();
                    break;

                case 6:
                    Teht6.FuelCalculator();
                    break;
            }
            Console.WriteLine("Paina mitä vain näppäintä");
            Console.ReadLine();
            Menu();
        }//Menu() end



        static void Main(string[] args)
        {
            Menu();
        }
  }
}

