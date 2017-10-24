using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7
{
    class Teht2
    {
        public static void ReadingNamesMain()
        {
            string path = @"C:\Windows\Temp";
            int Aappo = 0;
            int Benkku = 0;
            int Jaakko = 0;
            int Cecilia = 0;
            int Otto = 0;
            try
            {
                if (File.Exists(path + @"\nimet.txt"))
                {
                    List<string> listLine = new List<string>();

                    string[] lines = System.IO.File.ReadAllLines(path + @"\nimet.txt");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                        switch (line)
                        {
                            case "Aappo":
                                Aappo++;
                                break;
                            case "Benkku":
                                Benkku++;
                                break;
                            case "Jaakko":
                                Jaakko++;
                                break;
                            case "Cecilia":
                                Cecilia++;
                                break;
                            case "Otto":
                                Otto++;
                                break;
                        }
                    }

                    Console.WriteLine("Aappo: " + Aappo);
                    Console.WriteLine("Benkku: " + Benkku);
                    Console.WriteLine("Jaakko: " + Jaakko);
                    Console.WriteLine("Cecilia: " + Cecilia);
                    Console.WriteLine("Otto: " + Otto);

                }
                else
                {
                    Console.WriteLine("File.Exist gives false");
                }
            }
               
            catch(FileNotFoundException)
            {
                Console.WriteLine("Tiedosto ei löydy");
            }

            
        }

    }
}
