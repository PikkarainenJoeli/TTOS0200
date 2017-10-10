using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Renkaat");

            int menuSelector = int.Parse(Console.ReadLine());

            switch (menuSelector)
            {

                case 1:
                    Teht1.tyresMain();
                    break;

            }
        }
    }
}
