using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.checknums 2.elevator  3.amplifier");
            int selector = int.Parse(Console.ReadLine());

            switch (selector)
            {
                case 1:
            Teht1 check = new Teht1();
            check.CheckNumberMain();
                    break;

                case 2:
            Teht2 hissi = new Teht2();
            hissi.ElevatorMain();
                    break;

                case 3:
             Teht3 amplifier = new Teht3();
             amplifier.AmplifierMain();
                   break;
        }
            
        }
    }
}
