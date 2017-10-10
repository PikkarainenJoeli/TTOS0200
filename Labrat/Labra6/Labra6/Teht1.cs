using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6
{
    class Teht1
    {
        public static void tyresMain()
        {
            Vechile Audi = new Vechile("Audi","A4",1,4); //rengas tyyppi 1, renkaitten määrä 4

            Vechile Porsche = new Vechile("Porsche", "911", 2, 2);

            Console.WriteLine("Car name: " + Audi.CarName + " Car Model: " + Audi.CarModel);


            for (int i = 0; i < Audi.tyres.Count;i++)
            {
                Console.WriteLine(Audi.tyres[i].TyreName + " "+ Audi.tyres[i].TyreModel + " "+ Audi.tyres[i].TyreSize);
            }

            Console.WriteLine("");

            Console.WriteLine("Car name: " + Porsche.CarName + " Car Model: " + Porsche.CarModel);

            for (int i = 0; i < Porsche.tyres.Count; i++)
            {
                Console.WriteLine(Porsche.tyres[i].TyreName + " " + Porsche.tyres[i].TyreModel + " " + Porsche.tyres[i].TyreSize);
            }
           

        }
    }
}

public class Tyres
{
    public string TyreName { get; set; }
    public string TyreModel { get; set; }
    public string TyreSize { get; set; }


}

public class Vechile
{
    public string CarName { get;}
    public string CarModel { get;}
    
    public List<Tyres> tyres = new List<Tyres>();

    public Vechile(string carName,string carModel,int tyreNumber,int numberOfWheels)
    {
        
        CarName = carName;
        CarModel = carModel;
         
        if (tyreNumber == 1) {

            for (int i = 0; i < numberOfWheels; i++)
            {
                tyres.Add(new Tyres() {TyreName="Nokia",TyreModel = "Hakkapeliitta",TyreSize = "205R16" });
            }
           

        }

        if (tyreNumber == 2)
        {
            for (int i = 0; i < numberOfWheels; i++)
            {
                tyres.Add(new Tyres() { TyreName = "GoodYear", TyreModel = "Very nice tires", TyreSize = "245/35 R20 91Y" });
            }
        }


    }
}
