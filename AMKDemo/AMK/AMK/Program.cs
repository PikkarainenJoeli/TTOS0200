using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK
{
    public class AMK
    {
        /*          AMK                 *AMK:lla on tukintoja
         *              \
         *          TUTKINTO        *Tutkinnolla on opintojaksoja
         *             |      
         *      OPINTOJAKSO          *Opintojaksolla on opettajia ja opiskelijoita
         *      /           \           ja ominaisuuksia
         *  OPETTAJA       OPISKELIJA   *Näillä on ominaisuuksia
         *   
         * 
         */

        //AMK ominaisuudet
        public string lyhenne { get; set; }
        public List<Tutkinto> tutkinnot = new List<Tutkinto>();

        public AMK()
        {
            

                
        }

        public void AddDegree(Tutkinto degree)
        {
            tutkinnot.Add(degree);
        }

    }

    public class Tutkinto
    {


        //Tutkinnon ominaistuudet
        public List<Opintojakso> jaksot = new List<Opintojakso>();
        public string Nimi { get; set; }
        public int OP { get; set; }

            public Tutkinto()
        {
            
        }

        public void AddCourse(Opintojakso jakso)
        {
            this.jaksot.Add(jakso);
        }
    }

    public class Opintojakso
    {
        //Opintojakson ominaisuudet
        public List<Opiskelija> opi = new List<Opiskelija>();
        public List<Opettaja> ope = new List<Opettaja>();
        public string Nimi { get; set; }
        public string Tunnus { get; set; }
        public int OP { get; set; }


        public Opintojakso()
        {
            
        }

        public void AddStudent(Opiskelija opi)
        {
            this.opi.Add(opi);
        }

        public void AddTeacher(Opettaja ope)
        {
            this.ope.Add(ope);
        }

        public int CountStudents()
        {
            int count = opi.Count;                 
            return count;
        }
    }

    public class Opiskelija
    {
        //Opiskelija ominaisuudet
        public string Nimi { get; set; }
        public string Tunnus { get; set; }
        public Opiskelija()
        {
 
        }
    }

    public class Opettaja
    {
        public string Nimi { get; set; }
        public Opettaja()
        {

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Tehdään testi dataa

                Opiskelija opiskelija1 = new Opiskelija();
                opiskelija1.Nimi = "Jaakko";
                opiskelija1.Tunnus = "ABC123";

                Opettaja opettaja1 = new Opettaja();
                opettaja1.Nimi = "Esa";


                Opintojakso olioOhj = new Opintojakso();
                olioOhj.Nimi = "Olioohjelmointi";
                olioOhj.OP = 5;
                olioOhj.Tunnus = "TTOS0200";
                olioOhj.AddStudent(opiskelija1);
                olioOhj.AddTeacher(opettaja1);



                Tutkinto TTV = new Tutkinto();
                TTV.Nimi = "Tieto- ja Viestintätekniikka";
                TTV.OP = 240;
                TTV.AddCourse(olioOhj);

                AMK JAMK = new AMK();
                JAMK.lyhenne = "JAMK";
                JAMK.AddDegree(TTV);

                Console.WriteLine("~ AMK järjestelmä ~");

                //testiä
                //Console.WriteLine(olioOhj.opi[olioOhj.opi.Count - 1].Nimi);
                //Console.WriteLine(JAMK.tutkinnot[0].jaksot[0].opi[0].Tunnus);

                Console.WriteLine("Opiskelijoita on:" + olioOhj.CountStudents());
                //testiä



            }
            catch (Exception ex)
            {

                Console.WriteLine("Poikkeus pääohjelmassa " + ex.Message);
            }
            

        }
    }
}
