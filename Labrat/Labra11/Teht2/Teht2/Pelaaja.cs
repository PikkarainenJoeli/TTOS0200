using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Katisyys { get; set; }
        public int Numero { get; set; }
        public Pelaaja()
        {

        }

        public Pelaaja(string enimi, string snimi, string hand, int num)
        {
            Etunimi = enimi;
            Sukunimi = snimi;
            Katisyys = hand;
            Numero = num;
        }
        public override string ToString()
        {
            return Etunimi + "," + Sukunimi + "," + Katisyys + "," + Numero;
        }
    }

    public class Joukkue
    {
        public string Nimi { get; set; }
        public string Kaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }

        public Joukkue(string nimi, string kaupunki)

        {
            Pelaajat = new List<Pelaaja>();
            Nimi = nimi;
            Kaupunki = kaupunki;
        }

        public void HaePelaajat()
        {
            Pelaajat.Add(new Pelaaja("Eetu", "Laurikainen", "Left", 41));
            Pelaajat.Add(new Pelaaja("Juho", "Olkinuora", "Left", 45));
            Pelaajat.Add(new Pelaaja("Anttoni", "Honka", "Right", 3));
            Pelaajat.Add(new Pelaaja("Juuso", "Vainio", "Right", 5));
            Pelaajat.Add(new Pelaaja("Mikko", "Kalteva", "Left", 7));
            Pelaajat.Add(new Pelaaja("Jaakko", "Jokinen", "Left", 16));
            Pelaajat.Add(new Pelaaja("Alex", "Lindroos", "Left", 34));
            Pelaajat.Add(new Pelaaja("Ronji", "Allen", "Left", 36));
            Pelaajat.Add(new Pelaaja("Ossi", "Ikonen", "Left", 37));
            Pelaajat.Add(new Pelaaja("Nolan", "Yonkman", "Right", 43));
            Pelaajat.Add(new Pelaaja("Mikko", "MÃ¤enpÃ¤Ã¤", "Left", 47));
            Pelaajat.Add(new Pelaaja("Joona", "Erving", "Left", 53));
            Pelaajat.Add(new Pelaaja("Olli", "Aitola", "Left", 60));
            Pelaajat.Add(new Pelaaja("Tuomas", "Salmela", "Left", 61));
            Pelaajat.Add(new Pelaaja("Mikko", "Kuukka", "Left", 91));
            Pelaajat.Add(new Pelaaja("Joonas", "NÃ¤ttinen", "Right", 9));
            Pelaajat.Add(new Pelaaja("Samuli", "Ratinen", "Left", 11));
            Pelaajat.Add(new Pelaaja("Jani", "Tuppurainen", "Left", 12));
            Pelaajat.Add(new Pelaaja("Antti", "Suomela", "Left", 14));
            Pelaajat.Add(new Pelaaja("Juha-Pekka", "HytÃ¶nen", "Left", 15));
            Pelaajat.Add(new Pelaaja("Juuso", "Puustinen", "Right", 17));
            Pelaajat.Add(new Pelaaja("Valtteri", "Hotakainen", "Left", 21));
            Pelaajat.Add(new Pelaaja("Ossi", "Louhivaara", "Right", 23));
            Pelaajat.Add(new Pelaaja("Jarkko", "Immonen", "Right", 26));
            Pelaajat.Add(new Pelaaja("Riku", "Tiainen", "Left", 27));
            Pelaajat.Add(new Pelaaja("Miika", "Lahti", "Left", 28));
            Pelaajat.Add(new Pelaaja("Joel", "Sund", "Right", 29));
            Pelaajat.Add(new Pelaaja("Arttu", "Likola", "Left", 31));
            Pelaajat.Add(new Pelaaja("Jerry", "Turkulainen", "Right", 32));
            Pelaajat.Add(new Pelaaja("Micke", "Saari", "Left", 40));
            Pelaajat.Add(new Pelaaja("Janne", "Kolehmainen", "Left", 55));
            Pelaajat.Add(new Pelaaja("Henri", "Kanninen", "Left", 71));
            Pelaajat.Add(new Pelaaja("Robert", "Rooba", "Left", 88));
        }

        // Pelaajat voisi tallentaa muihin tiedostoihin, kuten esim. excel. Jos asiaa tahtoo viedÃ¤ pitkÃ¤lle voi kÃ¤yttÃ¤Ã¤ tietokantaa.
        public void Tallenna()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"c:\temp\" + Nimi + ".csv");

            foreach (Pelaaja i in Pelaajat)
            {
                file.WriteLine(i);
            }
            file.Close();
        }

        public void Lataa()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\temp\" + Nimi + ".csv");
            {
                string line;
                string[] param;
                while ((line = file.ReadLine()) != null)
                {
                    param = line.Split(',');
                    Pelaajat.Add(new Pelaaja(param[0], param[1], param[2], int.Parse(param[3])));
                    Array.Clear(param, 0, param.Length);
                }
            }
        }
    }
   

}

