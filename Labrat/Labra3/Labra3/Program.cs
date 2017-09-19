using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Program
    {

        static void Menu()
        {
            int menuSelector;
            bool GoodInt;

            
           do {
                Console.Clear();
                Console.WriteLine("1 Kiuas");
                Console.WriteLine("2 Pesukone");
                Console.WriteLine("3 TV");
                Console.WriteLine("4 Car");
                Console.WriteLine("5 Students");
                Console.Write("Valitse tehtävä:");
                while (GoodInt = int.TryParse(Console.ReadLine(), out menuSelector) == false) ;
                

                switch (menuSelector)
                {
                    case 1:
                        Teht1 kiuas = new Teht1();
                        kiuas.KiuasMain();
                        break;

                    case 2:
                        Teht2 wash = new Teht2();
                        wash.WashingMain();
                        break;

                    case 3:
                        Teht3 tv = new Teht3();
                        tv.TVMain();
                        break;

                    case 4:
                        Teht4 car = new Teht4();
                        car.CarMain();
                        break;

                    case 5:
                        Teht5 students = new Teht5();
                        students.StudentsMain();
                        break;


                }
            } while (menuSelector != 0);
            


        }






        static void Main()
        {
            Menu();
        }

   
    }
}

