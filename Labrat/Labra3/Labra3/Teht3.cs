using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Teht3
    {
        public void TVMain()
        {
            Console.WriteLine("TV");

            TV myTV = new TV();              
                myTV.Volume = 50;
                myTV.Channel = 1;
                myTV.IsOn = true;
                myTV.DimensionX = 20;
                myTV.DimensionY = 10;
            TV.TVArray[0] = myTV; // initialize this inside the class.

            TV myBiggerTV = new TV();
            myBiggerTV.Volume = 100;
            myBiggerTV.Channel = 2;
            myBiggerTV.IsOn = true;
            myBiggerTV.DimensionX = 40;
            myBiggerTV.DimensionY = 20;         

            Console.Write("Mitä TVtä katsotaan? ");          
 
            TV SelectedTV = myBiggerTV;
            
            var selected = Console.ReadLine();

                           
            Console.WriteLine("TVArray: "+TV.TVArray[0].Volume);
            Console.ReadLine();




            while (SelectedTV.IsOn)
            {
                TV.showProdcast(SelectedTV);
                TV.useRemote(SelectedTV);
            }
           
            Console.WriteLine("End of MAIN");
        }

    }

    public class TV
    {
        static public TV[] TVArray =  new TV[10];

        public int DimensionX {get;set;}
        public int DimensionY { get; set; }

        public bool IsOn { get; set; }
        public int Channel { get; set; }

        int volume;
        public int Volume {
            get { return volume; }

            set
            {
                volume = value;
                if(volume > 100)
                { volume = 100; }
                else if(volume < 0)
                { volume = 0; }
            }

        }

        public static void showProdcast(TV UsedTV)
        {
            Console.Clear();
            for(int i =0;i < UsedTV.DimensionX; i++) { Console.Write("*"); }
            Console.WriteLine("");
            for (int i = 0; i < UsedTV.DimensionY; i++)
            {
                if(i == UsedTV.DimensionY/2)
                {
                    Console.Write("");
                    for (int j = 0; j < (UsedTV.DimensionX-8)/3; j++) { Console.Write(" "); }
                    Console.Write(" ");
                    Console.WriteLine("Prodcast "+ UsedTV.Channel);
                }
                else { Console.WriteLine(""); }
            }
            for (int i = 0; i < UsedTV.DimensionX; i++) { Console.Write("*"); }Console.WriteLine("");
        }

            public static void useRemote(TV UsedTV)
            {
            
                int remoteButton;
                bool goodButton;

                    if(UsedTV.IsOn == false)
                {
                UsedTV.IsOn = true;
                }
                    Console.WriteLine("REMOTE COMMANDS");
                    Console.WriteLine("0 turnoff");
                    Console.WriteLine("1 volume: " + UsedTV.Volume);
                    Console.WriteLine("2 channel: " + UsedTV.Channel);

                while (goodButton = int.TryParse(Console.ReadLine(), out remoteButton) == false);
           
            switch (remoteButton)
                {
                case 0:
                    UsedTV.IsOn = false;
                    break;

                case 1:
                    Console.Write("Set Volume ");
                    UsedTV.Volume = int.Parse(Console.ReadLine());
                        break;

                case 2:
                    Console.Write("Set Channel ");
                    UsedTV.Channel = int.Parse(Console.ReadLine());
                    break;
            }
          
            }

        
    }
}
