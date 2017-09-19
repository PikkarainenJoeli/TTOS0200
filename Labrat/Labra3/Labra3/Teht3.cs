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
           

            TV myTV = new TV();
                Console.WriteLine("TV");
                myTV.Volume = 50;
                myTV.Channel = 1;
                myTV.IsOn = true;
                myTV.DimensionX = 20;
                myTV.DimensionY = 10;


            while (myTV.IsOn)
            {
                myTV.showProdcast(myTV);
                myTV.useRemote(myTV);
            }


            Console.WriteLine("End of MAIN");
        }

    }

    public class TV
    {
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

        public void showProdcast(TV myTV)
        {
            Console.Clear();
            for(int i =0;i < myTV.DimensionX; i++) { Console.Write("*"); }
            Console.WriteLine("");
            for (int i = 0; i < myTV.DimensionY; i++)
            {
                if(i == myTV.DimensionY/2)
                {
                    Console.Write("");
                    for (int j = 0; j < (myTV.DimensionX-8)/3; j++) { Console.Write(" "); }
                    Console.Write(" ");
                    Console.WriteLine("Prodcast "+ myTV.Channel);
                }
                else { Console.WriteLine(""); }
            }
            for (int i = 0; i < myTV.DimensionX; i++) { Console.Write("*"); }Console.WriteLine("");
        }

            public void useRemote(TV myTV)
            {
            
                int remoteButton;
                bool goodButton;

                    if(myTV.IsOn == false)
                {
                    myTV.IsOn = true;
                }
                    Console.WriteLine("REMOTE COMMANDS");
                    Console.WriteLine("0 turnoff");
                    Console.WriteLine("1 volume: " + myTV.Volume);
                    Console.WriteLine("2 channel: " + myTV.Channel);

                while (goodButton = int.TryParse(Console.ReadLine(), out remoteButton) == false);
           
            switch (remoteButton)
                {
                case 0:
                    myTV.IsOn = false;
                    break;

                case 1:
                    Console.Write("Set Volume ");
                    myTV.Volume = int.Parse(Console.ReadLine());
                        break;

                case 2:
                    Console.Write("Set Channel ");
                    myTV.Channel = int.Parse(Console.ReadLine());
                    break;
            }
          
            }

        
    }
}
