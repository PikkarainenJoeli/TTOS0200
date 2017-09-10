using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.InteropServices;


namespace Labra1
{

    class oldSpaces
    {
       // Teht20 = new List<oldSpaces>()
        public int oldY{get;set;}
        public int oldX {get; set;}

        public virtual ICollection<Teht20> GENRES { get; set; } // Use ICollection here
    }

    class Teht20
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);


        public static void display(char[,] area,string dirString)
        {
            var oldSpaces = new List<oldSpaces>();

            Console.Clear();
            for (int i = 0; i < area.GetLength(0); i++)// tehdään sarake 1,2,3
            {
                for (int j = 0; j < area.GetLength(1); j++) // rivi sarake 1,2,3
                {    
                    Console.Write(area[i, j]);
                }
                
                Console.WriteLine("");
            }
            Console.WriteLine(dirString);

        }


        public static void Snake()
        {
            List<int> OldY = new List<int>();
            List<int> OldX = new List<int>();
                         /*
                        OldY.Add(123);
                        OldY.Add(312);
                        Console.WriteLine("y at 0"+ OldY.ElementAt(1));
                         Console.ReadLine();    

                         OldY.Add(1);
                        Console.WriteLine("capa");
                        Console.WriteLine(OldX.Count);
                        Console.WriteLine(OldY.Count);
                        Console.ReadLine();
                        */

            int currentVert;
            int currentHor;
            int vert;
            int hor;
            int [,]oldSpaces = new int[200,2];

            string dirString;
            Random rnd = new Random();          
            dirString = "O";
            vert = 0;
            hor = 0;
            
            double TimeElapsed;
            TimeElapsed = 0;
            //initialisoi peli
            bool Alive = true;
            currentHor = 0;
            currentVert = 0;

            System.Timers.Timer timer = new System.Timers.Timer(200);
             timer.Enabled = true;
             timer.Start();

                                     // riviä, saraketta
                                    //vert hor
            char[,] area = new char[10, 20];
            

            Console.WriteLine(area.GetLength(0));
            Console.WriteLine("Here");

            for (int i = 0;i < area.GetLength(0); i++)// tehdään sarake 1,2,3
            {
                        for (int j = 0; j < area.GetLength(1); j++) // rivi sarake 1,2,3
                            {
                                area[i, j] = 'x';
                            Console.Write(area[0, j]);

                            }
                Console.WriteLine("");
            }

            Stopwatch t = new Stopwatch();
            Console.WriteLine("START");
            Console.ReadLine();
            int round = 0;
            int score = 0;
            int y = 0;
            area[0, 3] = 'o';


            //empty needed
            OldY.Add(0);
            OldX.Add(0);


            while (Alive)
            {
                //round++;
                //Console.WriteLine(round);

                t.Start();
                TimeSpan ts = t.Elapsed;
                TimeElapsed = ts.Seconds;
     
                if (GetAsyncKeyState(38) != 0 && dirString != "Down")
                {
                    vert = -1;
                    hor = 0;
                    dirString = "Up";
                   // Console.WriteLine("UP");
                }
                else if (GetAsyncKeyState(40) != 0 && dirString != "Up")
                {
                    vert = 1;
                    hor = 0;
                    dirString = "Down";
                    // Console.WriteLine("DOWN");
                }

                else if (GetAsyncKeyState(39) != 0 && dirString != "Left")
                {
                    vert = 0;
                    hor = 1;
                    dirString = "Right";
                    //Console.WriteLine("RIGHT");
                }
               
                else if (GetAsyncKeyState(37) != 0 && dirString != "Right")
                {
                    vert = 0;
                    hor = -1;
                    dirString = "Left";
                  //  Console.WriteLine("LEFT");
                }

                if (TimeElapsed > 0.1)//_________________________________________________________________________________________________
                {
                    t.Reset();
                    TimeElapsed = 0;

                    if(area[currentVert + vert, currentHor + hor] == 'o')
                    {
                        score++;
                        int NewScoreVert = rnd.Next(0, 10);
                        int NewScoreHort = rnd.Next(0, 20);
                        area[NewScoreVert, NewScoreVert] = 'o';
                    }
                    //drew current head space
                    area[currentVert + vert,currentHor + hor] = '■';

                    currentVert = currentVert + vert;
                    currentHor = currentHor + hor;


                    oldSpaces[y, 0] = currentVert;
                    oldSpaces[y, 1] = currentHor;

                   OldY.Add(currentVert);
                   OldX.Add(currentHor);

                    area[OldY.ElementAt(y-score), OldX.ElementAt(y-score)] = 'x';
                  

                  

             

                    display(area,dirString);
           
                    Console.WriteLine(currentVert + " " + currentHor);
                    Console.Write("oldY:"+OldY[OldY.Count-1]);
                    Console.Write(" oldX:"+OldX[OldX.Count-1]);
                    Console.WriteLine(" Score:" +score);

                    Console.Write("To delete: Y:" + OldY.ElementAt(y)+" X:" + OldX.ElementAt(y)+" Y:" + y);
                    //Console.ReadLine();
                    y++;
                }
                



            }



        }

   }

        
}

