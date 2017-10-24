using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valitse tehtävä");
            Console.WriteLine("1. Tiedostoon kirjoittaminen");
            Console.WriteLine("2. Nimien lukeminen");
            Console.WriteLine("3. Numeroiden tallennus");

            try
            {
                int menuSelector = int.Parse(Console.ReadLine());

                switch (menuSelector)
                {
                    case 1:
                        Teht1.WritingToFileMain();
                        break;

                    case 2:
                        Teht2.ReadingNamesMain();
                        break;

                    case 3:
                        Teht3.SavingNumbersMain();
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Ei ole numero");
            }



        }
    }
}
