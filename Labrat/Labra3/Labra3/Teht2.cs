using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Teht2
    {
        public void WashingMain()
        {
            Console.WriteLine("Pesukone");
            WashingMachine myWashingMachine = new WashingMachine();
            myWashingMachine.Name = "Electrolux 123";
            myWashingMachine.IsOn = false;
            myWashingMachine.IsWashing = false; //Console.ReadLine();
            myWashingMachine.Program = "Valkopyykki";

            Console.WriteLine("Nimi "+  myWashingMachine.Name);
            Console.WriteLine("Päällä " + myWashingMachine.IsOn);
            Console.WriteLine("Pesee " + myWashingMachine.IsWashing);
            Console.WriteLine("Pesuohjelma " + myWashingMachine.Program);

        }

    }

    public class WashingMachine
    {
        public string Name { get; set; }
        public bool IsOn { get; set; }  
        public string Program { get; set; }

       
    
        public bool isWashing;


        public bool IsWashing //{ get; set; }
        {
            get { return isWashing; }
            set
            {
                isWashing = value;
                if (IsOn == false)
                {
                    isWashing = false;
                }

            }
        }

    }
}
