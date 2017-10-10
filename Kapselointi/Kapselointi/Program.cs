using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapselointi
{
    class Thing
    {
        //julkinen jäsenmuuttuja != ominaisuus
        //public string Name;

        //parempi vaihtoehto, ominaisuus AutoImplementdProperty
        //public string Name { get; set; }
        //ToString -methodi käyttää jäsenmuuttujaa tai propertyä
        private string name;

        public Thing()
        {
            name = "No body here";
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
                            

        public override string ToString()
        {
            //return "Nimeni on: " + Name;
            // mutta mielummin jos on sisäinen muuttuja niin käytetään sitä
            return "nimeni on " + name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Thing t = new Thing();
            t.Name = "jotain";
            Console.WriteLine(t.Name);
            Console.WriteLine(t.ToString());*/

            //Student olion testaus

            Student s = new Student();
            s.FirstName = "Esa";
            s.LastName = "Salmik";

            Student s2 = new Student("Jaska" , "Jokunen");
            //luodaan kokoelma Student-olioita, käytetään List<>
            List<Student> students = new List<Student>();
            students.Add(s);
            students.Add(s2);

            students.Add(new Student("Arska","Aaltonen"));
            students.Add(new Student("Arska", "Aaltonen"));

            //Näytetään oppilaat

            //forilla
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }
            Console.WriteLine("");
            foreach(Student stud in students)
            {
                Console.WriteLine(stud.ToString());
            }
            Console.WriteLine("");

            //Testataa Group luokka
            Group luokka = new Group();
            luokka.Name = "TTV16S1";
            luokka.Students.Add(new Student("Anna", "Aurinko"));
            Console.WriteLine(luokka.ToString());
            
        }
    }
}
