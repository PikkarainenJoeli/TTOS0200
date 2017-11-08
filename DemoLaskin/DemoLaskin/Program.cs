using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLaskin
{
    interface ICalculator
    {
        int Add(int number1, int number2);
        int Multiply(int number1, int number2);

        int Divide(int number1,int number2);

        
    }
    public class MyCalculator : ICalculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Divide(int number1, int number2)
        {
            if (number2 == 0)
                return 0;
            else

            return number1 / number2;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Testataan oma laskin
            MyCalculator calculator = new MyCalculator();
            int number1 = 10;
            int number2 = 20;

            Console.WriteLine("lukujen {0} ja {1} summa on: {3}",number1,number2,calculator.Add(number1,number2));

        }
    }
}
