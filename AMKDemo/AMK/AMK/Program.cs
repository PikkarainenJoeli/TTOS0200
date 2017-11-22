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
        public static int howManyStudents = 0;

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

        static public void moreStudents()
        {
            howManyStudents++;
        }

    }

    public class Opiskelija
    {
        //Opiskelija ominaisuudet
        public string Nimi { get; set; }
        public string Tunnus { get; set; }
        public Opiskelija()
        {
            Opintojakso.moreStudents();
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


                //opiskelijat
                Opiskelija opiskelija1 = new Opiskelija();
                opiskelija1.Nimi = "Jaakko";
                opiskelija1.Tunnus = "ABC123";


                Opiskelija opiskelija2 = new Opiskelija();
                opiskelija2.Nimi = "Jani";
                opiskelija2.Tunnus = "XYZ987";

                Opiskelija opiskelija3 = new Opiskelija();
                opiskelija3.Nimi = "Mikko";
                opiskelija3.Tunnus = "LOL567";


                //opettajat
                Opettaja opettaja1 = new Opettaja();
                opettaja1.Nimi = "Esa";

                Opettaja opettaja2 = new Opettaja();
                opettaja2.Nimi = "Anne";

                Opettaja opettaja3 = new Opettaja();
                opettaja3.Nimi = "Juha";

                //opinto jaksot
                Opintojakso olioOhj = new Opintojakso();
                olioOhj.Nimi = "Olioohjelmointi";
                olioOhj.OP = 5;
                olioOhj.Tunnus = "TTOS0200";
                olioOhj.AddStudent(opiskelija1);
                olioOhj.AddStudent(opiskelija2);
                olioOhj.AddStudent(opiskelija3);
                olioOhj.AddTeacher(opettaja1);

                Opintojakso Matikka = new Opintojakso();
                Matikka.Nimi = "Matematiikka1";
                Matikka.OP = 5;
                Matikka.Tunnus = "TTS0000";
                Matikka.AddStudent(opiskelija2);
                Matikka.AddStudent(opiskelija1);
                Matikka.AddStudent(opiskelija3);
                Matikka.AddTeacher(opettaja2);

                Opintojakso Fysiikka = new Opintojakso();
                Fysiikka.Nimi = "Fysiikka1";
                Fysiikka.OP = 5;
                Fysiikka.Tunnus = "TTSO9999";
                Fysiikka.AddStudent(opiskelija3);
                Fysiikka.AddStudent(opiskelija1);
                Fysiikka.AddStudent(opiskelija2);
                Fysiikka.AddTeacher(opettaja3);

                Opintojakso KyberTurv = new Opintojakso();
                KyberTurv.Nimi = "Tietoturvan perusteet";
                KyberTurv.OP = 5;
                KyberTurv.Tunnus = "TTSO1234";
                KyberTurv.AddStudent(opiskelija3);
                KyberTurv.AddStudent(opiskelija2);
                KyberTurv.AddStudent(opiskelija1);
                KyberTurv.AddTeacher(opettaja3);

                Opintojakso PalvelinOhj = new Opintojakso();
                PalvelinOhj.Nimi = "Palvelinohjelmointi";
                PalvelinOhj.OP = 5;
                PalvelinOhj.Tunnus = "TTSO5000";
                PalvelinOhj.AddStudent(opiskelija1);
                PalvelinOhj.AddStudent(opiskelija2);
                PalvelinOhj.AddStudent(opiskelija3);
                PalvelinOhj.AddTeacher(opettaja3);
                PalvelinOhj.AddTeacher(opettaja2);


                //tutkinnot
                Tutkinto TTV = new Tutkinto();
                TTV.Nimi = "Tieto- ja Viestintätekniikka";
                TTV.OP = 240;
                TTV.AddCourse(olioOhj);
                TTV.AddCourse(KyberTurv);
                TTV.AddCourse(PalvelinOhj);

                Tutkinto MDT = new Tutkinto();
                MDT.Nimi = "Media Tekniikka";
                MDT.OP = 240;
                MDT.AddCourse(PalvelinOhj);
                MDT.AddCourse(KyberTurv);
                MDT.AddCourse(olioOhj);


                Tutkinto Kyber = new Tutkinto();
                Kyber.Nimi = "Kyberturvallisuus";
                Kyber.OP = 240;
                Kyber.AddCourse(KyberTurv);
                Kyber.AddCourse(Matikka);
                Kyber.AddCourse(Fysiikka);



                //instituutti
                AMK JAMK = new AMK();
                JAMK.lyhenne = "JAMK";
                JAMK.AddDegree(TTV);
                JAMK.AddDegree(MDT);
                JAMK.AddDegree(Kyber);

                Console.WriteLine("~ AMK järjestelmä ~");

                //testiä
                //Console.WriteLine(olioOhj.opi[olioOhj.opi.Count - 1].Nimi);
                //Console.WriteLine(JAMK.tutkinnot[0].jaksot[0].opi[0].Tunnus);

                //Console.WriteLine("Opiskelijoita on:" + olioOhj.CountStudents());
                //testiä
                //Console.WriteLine(Opintojakso.howManyStudents); staattinen muuttoja Opintojaksossa incrementoidaan kun uusi opiskelija luodaan

                foreach (var t in JAMK.tutkinnot)
                {
                    Console.WriteLine("-----"+ t.Nimi + " " + t.OP+ "----");

                    foreach (var jakso in t.jaksot)
                    {
                        Console.WriteLine("#Kurssit#");
                        Console.WriteLine(" {0} {1} {2}",jakso.Nimi,jakso.Tunnus,jakso.OP);

                        Console.WriteLine("     #Opiskelijat#");
                        foreach (var opi in jakso.opi)
                        {
                            
                            Console.WriteLine("     {0} {1}", opi.Nimi,opi.Tunnus);
                        }
                        Console.WriteLine("");

                        Console.WriteLine("     #Opettajat#");
                        foreach (var ope in jakso.ope)
                        {
                            Console.WriteLine("     " + ope.Nimi);
                        }
                        Console.WriteLine("");
                    }



                    Console.WriteLine();
                }



            }
            catch (Exception ex)
            {

                Console.WriteLine("Poikkeus pääohjelmassa " + ex.Message);
            }
            

        }
    }
}
