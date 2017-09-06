using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht4
    {
        public static void AgeGroup()
        {
            int age;
            Console.WriteLine("Anna ikäsi: ");
            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Alaikä");
            }

            else if (age > 18 && age < 65) {
                Console.WriteLine("Keski-ikä");
            }
            else if(age > 65)
            {
                Console.WriteLine("Seniori");
            }
            

        }

    }
}
