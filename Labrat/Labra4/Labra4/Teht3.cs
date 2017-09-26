using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Teht3
    {
        public void AmplifierMain()
        {
           
            Console.Write("Set Volume:");
            Amplifier.Volume = int.Parse(Console.ReadLine());
            Console.WriteLine("volume:" + Amplifier.Volume);
        }

    }

    public class Amplifier
    {
        private static int volume;
        public static int Volume
        {
            get { return volume; }
            set
            {
                if (value < 0)
                {
                    volume = 0;
                }
                else if(value > 100)
                {
                    volume = 100;
                }
                else
                {
                    volume = value;
                }
            }
        }

    }
}
