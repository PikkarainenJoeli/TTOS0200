using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Teht5
    {
        public void StudentsMain()
        {
            string name1 = "abc";
            Student Heikki = new Student();
            Student Maisa = new Student();
            Student Ossi = new Student();
            Student Kaisa = new Student();
       
            Heikki.Name = "Heikki";
            Heikki.ID = "L9201";
            Heikki.Group = "ABC17K1";
            Heikki.GradeAverage = 4.5;
            //Student.names[0] = Heikki.Name;

            Maisa.Name = "Maisa";
            Maisa.ID = "L9202";
            Maisa.Group = "ABC17K1";
            Maisa.GradeAverage = 4.0;

            Ossi.Name = "Ossi";
            Ossi.ID = "L9203";
            Ossi.Group = "ABC17K3";
            Ossi.GradeAverage = 3.7;

            Kaisa.Name = "Kaisa";
            Kaisa.ID = "L9205";
            Kaisa.Group = "ABC17K2";
            Kaisa.GradeAverage = 3.9;

            Console.WriteLine("NAMEEES 0 "+Student.names[0]);

            List<List<string>> students = new List<List<string>>();

            BindingFlags bindingFlags = BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static;

            students.Add(new List<string>());
            foreach (FieldInfo field in typeof(Student).GetFields(bindingFlags))
            {
                Console.WriteLine(field.GetValue(Heikki));                   
                students[0].Add(field.GetValue(Heikki).ToString());
            }

            /*List architecture planned, every students data is a list in a list [ID,Name, Group]
             
            ID |  Name | Group | Course Avrg.
     Name1
     Name2

            */


                      
            students.Add(new List<string>());
            students[1].Add(Maisa.ID);
            students[1].Add(Maisa.Name);
            students[1].Add(Maisa.Group);
            students[1].Add(Maisa.GradeAverage.ToString());

            students.Add(new List<string>());
            students[2].Add(Ossi.ID);
            students[2].Add(Ossi.Name);
            students[2].Add(Ossi.Group);
            students[2].Add(Ossi.GradeAverage.ToString());

            students.Add(new List<string>());
            students[3].Add(Kaisa.ID);
            students[3].Add(Kaisa.Name);
            students[3].Add(Kaisa.Group);
            students[3].Add(Kaisa.GradeAverage.ToString());

           
            



          

            Console.WriteLine("ID     NAME    GROUP  Course avrg. ");
            for (int i = 0; i < students.Count; i++)
            {
                for(int j = 0; j < students[i].Count; j++)
                {
                    Console.Write(students[i][j] + " ");
                }
                Console.WriteLine("");

            }
            Console.ReadLine();
            

        }
    }
  


    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Group { get; set; }
        public double GradeAverage { get; set; }

        static public string[] names = new string[100];
         int i;
        public string this[int i]
        {
            get
            {
                Console.WriteLine(i);
                return names[i];
                i++;
            }
            set
            {
                names[i] = Name;
            }
           
        }

    }
}
