using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vk44
{
    public struct Rider
    {
        public string Name;
        public int Starts;
        public int Winnings;
        public float WinPercent;
    }

    class Program
    {

        static void ReadFile2()
        {
            try
            {//luetaan .csv tiedostosta tiedot ja tallennetaan structiin
                string parser = ";" ;
                //luetaan kaikki rivit muuttujaan
                string[] rows = System.IO.File.ReadAllLines(@"D:\H8897\tilasto2017.csv");
                Rider rider;
                int rowsCount = rows.Length;
                Console.WriteLine("riders:" + rowsCount);

                //Käydään muistiin luetut rivit läpi
                for (int i = 0; i < rowsCount; i++)
                {
                    string[] words = rows[i].Split(parser.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                    //tietueita on kahdenlaisia V1:Enimi + Snimi V2: Enimi + Väliosa + Snimi
                    if (int.TryParse(words[2], out int p))
                    {
                        rider.Name = words[0] + " " + words[1];
                        rider.Starts = int.Parse(words[2]);
                        rider.Winnings = int.Parse(words[3]);
                        rider.WinPercent = (100F * rider.Winnings / rider.Starts);
                    }
                    else
                    {
                        rider.Name = words[0] + " " + words[1] + " " + words[2];
                        rider.Starts = int.Parse(words[3]);
                        rider.Winnings = int.Parse(words[4]);
                        rider.WinPercent = (100F * rider.Winnings / rider.Starts);
                    }

                    //Näytetään tulos
                    Console.WriteLine("{0}: {1} startit {2} voitot {3} voitto prosentti {4}",i,rider.Name,rider.Starts,rider.Winnings,rider.WinPercent);
                }
                Console.WriteLine("end");

            }
            catch (Exception)
            {

                throw;
            }
        }



        static void ReadFile1()
        {
            try
            {// luetaan tideosto läpi rivi kerrallaan
                int count = 0;
                string line;

                System.IO.StreamReader stream = new System.IO.StreamReader(@"D:\H8897\tilasto2017.txt");

                while ( (line = stream.ReadLine()) != null )
                {
                   
                    Console.WriteLine(count + " " + line);
                    count++;
                }
                stream.Close();
                Console.WriteLine(count);
            }



            catch (Exception)
            {

                throw;
            }

        }


        static void Main(string[] args)
        {

            try
            {
                //ReadFile1();
                ReadFile2();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
            }

        }
    }
}
