using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht15
    {

        public static void DrawTree()
        {
            int height;
            int treeInc;
            treeInc = 1;
            bool isGood;
            Console.WriteLine("Anna puun korkeus: ");
            while(isGood = int.TryParse(Console.ReadLine(),out height)==false);
            
            
            for(int i =0;i < height -2; i++)
            {

                for (int j = 0; j < height +1 -i; j++) //välit
                {
                    Console.Write(" "); 
                }

                for (int k = 0; k < treeInc;k++) // oksat
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine(" ");
                treeInc += 2;
            }

            // kanta
            for(int l = 0;l < 2; l++)
            {
                for (int k = 0; k < height + 1; k++) // oksat
                {
                    Console.Write(" ");

                }

                    Console.WriteLine("*");


            }

        }
    }
}
