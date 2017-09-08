using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    /*
     Joeli Pikkarainen H8897 TTV15S4 
     olioihjelmoinni harjoituksia.
     */
     
    class Labra1
    {
        public  static void Menu()
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
            Console.WriteLine(7 + " LeapYear");
            Console.WriteLine(8 + " BiggestNum");
            Console.WriteLine(9 + " Summing");
            Console.WriteLine(10 + " Evens");
            Console.WriteLine(11 + " Starts");
            Console.WriteLine(12 + " ReversedArary");
            Console.WriteLine(13 + " SkiJumpScore");
            Console.WriteLine(14 + " CourseStars");
            Console.WriteLine(15 + " DrawTree");
            Console.WriteLine(16 + " GuessRandom");
            Console.WriteLine(17 + " SortArrays");
            Console.WriteLine(18 + " Palindrom");
            Console.WriteLine(19 + " HangMan");
            Console.WriteLine(20 + " Snake");

            bool GoodInt;
            while (GoodInt = int.TryParse(Console.ReadLine(), out menuSelector) == false) ;
            // estää huonojen arvojen syöttämisen.
            
            Console.WriteLine("Valitsit: "+menuSelector);


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

                case 7:
                    Teht7.LeapYear();
                    break;

                case 8:
                    Teht8.BiggestNum();
                    break;

                case 9:
                    Teht9.Summing();
                    break;

                case 10:
                    Teht10.Evens();
                    break;

                case 11:
                    Teht11.Stars();
                    break;

                case 12:
                    Teht12.ReversedArray();
                    break;

                case 13:
                    Teht13.SkiJumpScore();
                    break;

                case 14:
                    Teht14.CourseStars();
                    break;

                case 15:
                    Teht15.DrawTree();
                    break;

                case 16:
                    Teht16.GuessRandom();
                    break;

                case 17:
                    Teht17.SortArrays();
                    break;

                case 18:
                    Teht18.Palindrom();
                    break;

                case 19:
                    Teht19.HangMan();
                    break;

                case 20:
                    Teht20.Snake();
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

