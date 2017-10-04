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
            Thing t = new Thing();
            t.Name = "jotain";
            Console.WriteLine(t.Name);
            Console.WriteLine(t.ToString());
        }
    }
}
