using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapselointi
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string AsioID { get; set; }
        public Student()
        {

        }

        public Student(string fname,string lname)
        {
            FirstName = fname;
            LastName = lname;
        }

        public override string ToString()
        {
            return FirstName + " " +  LastName;
        }
    }

    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students;

        public Group()
        {
            Students = new List<Student>();
            //Luettaisiin tietokannasta oppilaiden tideot

            Students.Add(new Student("Pelle","Peloton"));
            Students.Add(new Student("Aku", "Ankka"));
            Students.Add(new Student("Mikki", "Hiiri"));
        }

        public override string ToString()
        {
            string retval = "";

            foreach(Student stud in Students)
            {
                retval += stud.ToString() + "\n";
            }
            return retval;
        }
    }
}
