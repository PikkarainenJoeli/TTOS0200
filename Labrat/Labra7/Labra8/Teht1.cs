using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7
{
    class Teht1
    {

        public static void WritingToFileMain()
        {
            Console.WriteLine("Anna nimet");
            List<string> nameList = new List<string>();
            string filu = "Teht1filu.txt";
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(filu);

            string tempName;

            do
            {
                tempName = Console.ReadLine();
                nameList.Add(tempName);
                
            }
            while (tempName != "");


            try
            {
                Console.WriteLine("Nimien määrä annettu: "+nameList.Count);
                for (int j = 0; j < nameList.Count; j++)
                {
                    Console.WriteLine("Kirjoitetaan teidostoon: " +nameList[j]);
                    outputFile.WriteLine(nameList[j]);
                }
                outputFile.Close();

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedostoa ei löytynyt");
            }

 //------------------------------------------------------------------------

            try
            {
                
                string text = System.IO.File.ReadAllText("filu");
                Console.WriteLine("Tiedoston sisältö: ");
                Console.WriteLine(text);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

        }

    }
}
