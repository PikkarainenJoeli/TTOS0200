using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Employee");
            Console.Write("Select task:");
            int menuSelector = int.Parse(Console.ReadLine());

            switch (menuSelector)
            {
                case 1:
                    Teht4.EmployeeMain();
                    break;
            }
        }
    }
}
