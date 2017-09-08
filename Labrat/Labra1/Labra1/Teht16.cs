using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht16
    {
        public static void GuessRandom()
        {
            Random rnd = new Random();
            int myGuess;
            myGuess = -1;
            int guessed;
            guessed = 0;
            int rndmNumber = rnd.Next(0, 100);
            Console.WriteLine("NUMERO:" + rndmNumber);

            while(myGuess != rndmNumber)
            {
               myGuess = int.Parse(Console.ReadLine());

                if(myGuess > rndmNumber)
                {
                    Console.WriteLine("Arvauksesi on suurempi");
                }

                if (myGuess < rndmNumber)
                {
                    Console.WriteLine("Arvauksesi on pienempi");
                }

                guessed++;
            }

            Console.WriteLine("Arvasit oikein " + guessed+ " Arvauksella");
        }
    }
}
