using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9
{
    public class Dice
    {
        public int diceSides { get; set; }
        int number { get; }
        public List<int> newNumbers = new List<int>();
        public int[] valuesCounts = new int[] { 0, 0, 0, 0, 0, 0 };

        

        public Dice(int sides)
        {
            diceSides = sides;
        }

      
        public float getNewNumbers(int numbers)
        {
            float total = 0;
            float average = 0;          
            Random rnd = new Random();
            int tempNumber;

            for (int i = 0; i < numbers; i++)
            {             
                tempNumber = rnd.Next(1,this.diceSides);
                newNumbers.Add(tempNumber);
                total += tempNumber;

                if (tempNumber == 1)
                {
                    valuesCounts[0]++;
                }
                else if(tempNumber ==2)
                {
                    valuesCounts[1]++;
                }
                else if (tempNumber ==3)
                {
                    valuesCounts[2]++;
                }
                else if (tempNumber ==4)
                {
                    valuesCounts[3]++;
                }
                else if (tempNumber ==5)
                {
                    valuesCounts[4]++;
                }
                else if (tempNumber ==6)
                {
                    valuesCounts[5]++;
                }

            }
            average = total / numbers;
            //Console.WriteLine("Total: " + total + " Average: "+ average.ToString("0.00"));
            return average;
        }

        

    }


    class Teht1
    {
        public static void DiceMain()
        {
            int numbers;
            Console.Write("Monta numeroa arvotaan?: ");
            numbers = int.Parse(Console.ReadLine());

            Dice myDice = new Dice(6);
           float Average = myDice.getNewNumbers(numbers);

            for (int i = 0; i < myDice.valuesCounts.Length; i++)
            {
                Console.WriteLine(i + 1 +" : "+ myDice.valuesCounts[i]);
            }
            Console.WriteLine("Average: " + Average.ToString("0.00"));
        }
    }
}
