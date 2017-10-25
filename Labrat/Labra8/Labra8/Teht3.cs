using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7
{
    class Teht3
    {
        public static void SavingNumbersMain()
        {
            
            System.IO.StreamWriter IntFile = new System.IO.StreamWriter("Integers.txt");
            System.IO.StreamWriter DoubFile = new System.IO.StreamWriter("Doubles.txt");
            string number;
            double i;
            int j;

            do
            {
                number = Console.ReadLine();
                //Console.WriteLine(number);
                //Console.WriteLine("dub "+Double.TryParse(number, out i));
                //Console.WriteLine("int "+int.TryParse(number, out j));

            if(int.TryParse(number,out j))
                {
                    IntFile.WriteLine(number);
                    Console.WriteLine("tallennetaan integer");
                }
            else if(Double.TryParse(number, out i))
                {
                    DoubFile.WriteLine(number);
                    Console.WriteLine("tallennetaan double");
                }

            }

            while (Double.TryParse(number,out i) || int.TryParse(number, out j));

            IntFile.Close();
            DoubFile.Close();
        }
    }
}
