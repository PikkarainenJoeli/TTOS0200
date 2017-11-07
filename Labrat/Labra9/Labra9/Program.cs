using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {             
                int menuSelector;
                int j;
                do
                {
                    Console.WriteLine("Valitse tehtävä");
                    Console.WriteLine("1. Noppa");
                    Console.WriteLine("2. Ostokset");
                    Console.WriteLine("3. Kalastus");
                    Console.WriteLine("4. Shapes");



                    menuSelector = int.Parse(Console.ReadLine());

                    switch (menuSelector)
                    {
                        case 1:
                            Teht1.DiceMain();
                            break;

                        case 2:
                            Teht2.ProductMain();
                            break;

                        case 3:
                            Teht3.FishingMain();
                            break;

                        case 4:
                            Teht4.ShapesMain();
                            break;

                    }
                }
                while (menuSelector != 0);

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            

        }
    }
}
