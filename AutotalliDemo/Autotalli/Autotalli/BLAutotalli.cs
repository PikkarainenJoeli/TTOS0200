using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotalli
{

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Yearm { get; set; }
        public int KM { get; set; }
        public float Price { get; set; }
        public string URL { get; set; }


    }

    public static class Carage
    {
        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>();

            //Guin testaaamista vasrten keksitään muutama auto
            Car car1 = new Car();
            car1.Brand = "Volvo";
            car1.Model = "V70";
            car1.Yearm = 2007;
            car1.KM = 200000;
            car1.Price = 7000;
            car1.URL = "VolvoV70.png";
            cars.Add(car1);

            Car car2 = new Car() {Brand="Audi", Model="A4",Yearm=2010,KM=100000,Price=19900,URL="AudiA4.png"};
            cars.Add(car2);

            Car car3 = new Car() { Brand = "Saab", Model = "99", Yearm = 2000, KM = 1000000, Price = 900, URL=""};
            cars.Add(car3);




            return cars;
        }
    }


    public class BLAutotalli
    {

    }

}
