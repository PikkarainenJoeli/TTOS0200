using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    class Teht4
    {


        static public void EmployeeMain()
        {



            Employee John = new Employee();
            John.Name = "John";
            John.Salary = 2000;
            John.Profession = "Mechanic";

            Employee Mary = new Employee();
            Mary.Name = "Mary";
            Mary.Salary = 2400;
            Mary.Profession = "Fund Manager";

            Boss Tim = new Boss(500, "Audi");
            Tim.Name = "Tim";
            Tim.Salary = 3500;
            Tim.Profession = "Master Mechanic";


            Console.WriteLine("Name    Profession   Salary     Car      Bonus");

            Worker[] workerArray = new Worker[3];
            workerArray[0] = Tim;
            workerArray[1] = Mary;
            workerArray[2] = Tim;

            List<Worker> listWorkers = workerArray.ToList();
            
           /* for(int i = 0;i> workerArray.Length;i++)

            foreach(Boss w in listWorkers)
            {
                if(listWorkers.Find())
                Console.WriteLine(w.Name + w.Profession + w.Salary + w.Car + w.Bonus);             
            } 

            Worker.InitTable();
          */
        }

    }

    public class Worker
    {
        
        
        int i = 0;
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Profession { get; set; }
        public List<string> workerNames = new List<string>();
        

        public static List<List<string>> InitTable()
        {

        BindingFlags bindingFlags = BindingFlags.Public |
        BindingFlags.NonPublic |
        BindingFlags.Instance |
        BindingFlags.Static;

            List<List<string>> Table = new List<List<string>>();
            Table.Add(new List<string>());
            foreach (FieldInfo field in typeof(Worker).GetFields(bindingFlags))
            {
                Console.WriteLine();

            }

            
            return Table;
        }

    }

    public class Employee : Worker
    {
        public string Status = "Employee";       
    }

    public class Boss : Worker
    {
        public string Status = "Boss";
        public int Bonus { get; set; }
        public string Car { get; set; }

        public Boss(int Bonus,string Car)
        {
            Console.WriteLine(Bonus);
            int bonari;
            bonari = this.Bonus;
            Console.WriteLine(bonari);
        }
    }

}
