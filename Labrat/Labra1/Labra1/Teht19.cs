using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht19
    {
        public static string InString(char []word)
        {
            string inString = new string(word);
            return inString;
        }


        public static void HangMan()
        {
            char[] words = { 'k', 'i', 's', 's', 'a' };
            char[] progress = { '_', '_', '_', '_', '_' };
            char guess;
            char[] guessed = new char[24];
            int dead;
            dead = 0;
            Console.WriteLine("Arvaa kirjain");
            bool wasRight;
            while (InString(words) != InString(progress) && dead < 5)
            {
                wasRight = false;
                Console.Clear();
                Console.Write("Arvatut:");
                Console.WriteLine(dead + "/" + 5);

                for (int i = 0;i < dead; i++)
                {
                    Console.Write(guessed[i]);
                }

               
              
                Console.WriteLine("");

                for (int j = 0; j < words.Length; j++)
                {
                    Console.Write(progress[j]);

                }

                guess = Console.ReadKey().KeyChar;
                guessed[dead] = guess;

                for(int i = 0; i < words.Length; i++)
                {
                    if(guess == words[i])
                    {
                        progress[i] = words[i];
                        wasRight = true;

                    }
                    

                }

                if (wasRight == false)
                {
                    dead++;
                }
            }
           

            if(InString(words) == InString(progress))
            {
                Console.Clear();
                Console.WriteLine(words);
                Console.WriteLine("Voitit pelin");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(dead + "/" + 5);
                Console.WriteLine("Hävisit pelin");
            }

        }
    }
}
