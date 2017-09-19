using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Teht4
    {
        public void CarMain()
        {
            Console.WriteLine("Car");
            Car myCar = new Car();
            myCar.Name = "Toyota";
            myCar.Speed = 0;
            myCar.Tyres = 4;

            myCar.PrintData(myCar);
           string dataString = myCar.ToString(myCar);
            Console.WriteLine(dataString);
            
            Console.ReadLine();
        }
    }

    public class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData(Car myCar)
        {
            Console.WriteLine("Printdata:");
            Console.WriteLine("NAME "+myCar.Name);
            Console.WriteLine("SPEED " + myCar.Speed);
            Console.WriteLine("Tyres " + myCar.Tyres);
        }

        public string ToString(Car myCar)
        {           
            Console.WriteLine("ToString:");        
            return String.Format("{0} {1} {2}", myCar.Name, myCar.Speed, myCar.Tyres);
            
        }
    }
}
