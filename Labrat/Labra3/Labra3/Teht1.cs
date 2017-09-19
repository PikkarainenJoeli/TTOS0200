using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Teht1
    {
        public void KiuasMain()
        {
            Console.Clear();
            Kiuas minunKiuas = new Kiuas();
            bool isGood;

            float temperature;
            float humidity;
            bool isOn;
            string isOnString;

            Console.WriteLine("Kiuas");

            Console.Write("Aseta kiukaan lämpötila:");
            while (isGood = float.TryParse(Console.ReadLine(), out temperature) == false);
            minunKiuas.Temperature = temperature;

            Console.Write("Aseta kiukaan kosteus:");
            while (isGood = float.TryParse(Console.ReadLine(), out humidity) == false);
            minunKiuas.Humidity = humidity;

            Console.Write("Laitetaanko kiuas päälle? y/n");
            do
            {
                isOnString = Console.ReadLine();
            }
            while((isOnString.Equals("y") != true) && isOnString.Equals("n") != true);
            
            if (isOnString.Equals("y")){
                minunKiuas.IsOn = true;
            }else minunKiuas.IsOn = false;


            Kiuas show = new Kiuas();
            show.ShowStats(minunKiuas);
        }

    }

    public class Kiuas
    {
        public bool IsOn { get; set; }
        public float Temperature { get; set; }


        float humidity;
        

        public float Humidity
        {
            get { return humidity; }
            set
            {
                humidity = value;
                if (humidity < 0 || humidity > 100)
                {
                    humidity = 0;
                }

            }
        }

        internal void ShowStats(Kiuas kiuas)
        {
        Console.WriteLine("Kiukaan lämpötila: " + kiuas.Temperature);
        Console.WriteLine("Kiukaan kosteus: " + kiuas.Humidity);
        Console.WriteLine("Kiuas päällä: " + kiuas.IsOn);
        }
    }
}
