using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht18
    {
        public static string Reverse(string word){
            string reversed;
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);

            reversed = new string(charArray);
            return reversed;

        }

        public static void Palindrom()
        {
            string word;
           
            Console.WriteLine("Kirjoita lause tai sana:");
            word = Console.ReadLine();

           if(word == Reverse(word))
            {
                Console.WriteLine("On palindromi");
            }
           else
            {
                Console.WriteLine("Ei ole palindromi");
            }

            
        }


    }
}
