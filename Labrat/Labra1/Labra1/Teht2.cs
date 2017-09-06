using System;

namespace Labra1
{

    public class Teht2
    {
        public static void CourseGrade()
        {
            int score;

            Console.WriteLine("Opiskelija pisteet:");
            score = int.Parse(Console.ReadLine());

            if (score == 0 || score == 1)
            {
                Console.WriteLine("Arvosana: 0");
            }

            else if (score == 2 || score == 3)
            {
                Console.WriteLine("Arvosana: 1");
            }

            else if (score == 4 || score == 5)
            {
                Console.WriteLine("Arvosana: 2");
            }
            else if (score == 6 || score == 7)
            {
                Console.WriteLine("Arvosana: 3");
            }
            else if (score == 8 || score == 9)
            {
                Console.WriteLine("Arvosana: 4");
            }
            else if (score == 10 || score == 12)
            {
                Console.WriteLine("Arvosana: 5");
            }

            else
            {
                Console.WriteLine("Huono pistemäärä");
            }

            

        }
    }
}
