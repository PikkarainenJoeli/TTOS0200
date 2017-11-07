using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9
{
    class Teht3
    {
        class Fisher
        {
            public string Name { get;}
            public string Phone { get;}
            public List<Fish> Fishes = new List<Fish>();

            public Fisher(string name,string phone)
            {
                Name = name;
                Phone = phone;
              
            }

            public void goFishing(int times)
            {
                int randomFish;
                Random rnd = new Random();
                for (int i = 0; i < times; i++)
                {
                    
                    randomFish = rnd.Next(1, 3);

                    Fish anotherFish = new Fish(randomFish);
                    Fishes.Add(anotherFish);
                }
                
            }

            public void sortFishes()
            {
                Fishes.Sort(delegate(Fish x,Fish y)
                {
                    if (x.Weight == null && y.Weight == null) return 0;
                    else if (x.Weight == null) return -1;
                    else if (y.Weight == null) return 1;
                    else return y.Weight.CompareTo(x.Weight);
                });
            }



        }

        class Fish
        {
           
            public string Species { get; set; }
            public int Length { get; set; }
            public int Weight { get; set; }

            public string Location { get; set; }
            public string Place { get; set; }

            public Fish(int rnd)
            {
                //Console.WriteLine(rnd);
                if (rnd == 1)
                {
                    
                    Species = "Pike";
                    Length = 100;
                    Weight = 1000;
                    Location = "Jyväskylä";
                    Place = "The Lake of Jyväskylä";
                }
                else if (rnd == 2)
                {
                    
                    Species = "Salmon";
                    Length = 80;
                    Weight = 800;
                    Location = "River Teno";
                    Place = "The Northern edge of Finland";
                }

            }

        }

        public static void FishingMain()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Kalastusta");
                Fisher kalstaja1 = new Fisher("Kirsi Kernel", "020 - 12345678");
                kalstaja1.goFishing(3);

                foreach (Fish f in kalstaja1.Fishes)// ennen järjestelyä
                {
                    Console.WriteLine("{0} Lenght {1}cm Weight {2}g {3} {4}", f.Species, f.Length, f.Weight, f.Location, f.Place);

                }
                Console.WriteLine("");
                kalstaja1.sortFishes();


                foreach (Fish f in kalstaja1.Fishes)// järjestelyn jälkeen
                {
                    Console.WriteLine("{0} Lenght {1}cm Weight {2}g {3} {4}", f.Species,f.Length,f.Weight,f.Location,f.Place);                   
                    
                }


            }

            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
        }

    }
}
