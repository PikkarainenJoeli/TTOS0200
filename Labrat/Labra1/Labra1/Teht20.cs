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


            int currentVert;
            int currentHor;
            int vert;
            int hor;
            int [,]oldSpaces = new int[2000,2];
           

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
            const int rows = 10;
            const int columns = 25;
       
            char[,] area = new char[rows, columns];
            

            for (int i = 0;i < area.GetLength(0); i++)// tehdään sarake 1,2,3
            {
                        for (int j = 0; j < area.GetLength(1); j++) // rivi sarake 1,2,3
                            {
                                area[i, j] = '.';
                            //Console.Write(area[0, j]);

                            }
               // Console.WriteLine("");
            }

            Stopwatch t = new Stopwatch();
            Console.WriteLine("Press any to Start!");
            //Console.ReadKey();
            int round = 0;
            int score = 0;
            int y = 0;
            area[0, 3] = 'o';


            //empty needed
            OldY.Add(0);
            OldX.Add(0);
            int NewScoreVert = rnd.Next(0, rows);
            int NewScoreHort = rnd.Next(0, columns);

            bool paused;
            paused = false;
            while (Alive)
            {

                t.Start();
                TimeSpan ts = t.Elapsed;
                TimeElapsed = ts.Milliseconds;
     
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
                          //Console.WriteLine("LEFT");
                        }

                        else if (GetAsyncKeyState(32) !=0 && paused == false) {;Console.ReadKey();}
               
                if (TimeElapsed > 150)// new game tick every x milliseconds.
                {
                    
                    t.Reset();
                    TimeElapsed = 0;

                    if( (currentVert + vert < 0 || currentVert + vert > rows -1) || (currentHor + hor < 0 || currentHor + hor > columns-1))
                    {
                        Console.Write("Game Over");Console.Read();
                        Labra1.Menu();
                    }

                            if (area[currentVert + vert, currentHor + hor] == 'o')
                            {
                                score++;

                        //make new score location and check that it free
                        NewScoreVert = rnd.Next(0, 10);
                        NewScoreHort = rnd.Next(0, 20);
                        if (area[NewScoreVert, NewScoreHort] != '■')
                        {
                            area[NewScoreVert, NewScoreVert] = 'o';
                        }
                        else
                        {
                            while (area[NewScoreVert, NewScoreHort] == '■')
                            {
                                NewScoreVert = rnd.Next(0, 10);
                                NewScoreHort = rnd.Next(0, 20);
                                area[NewScoreVert, NewScoreVert] = 'o';
                            }

                        }
                                
                                //Console.WriteLine("next score at function: " + NewScoreVert + " " + NewScoreHort +" "+ area[NewScoreVert, NewScoreHort]);
                                //Console.ReadLine();
                    }

                    if (area[currentVert + vert, currentHor + hor] == '■')
                    {
                        Console.WriteLine("GAME OVER");
                        Console.ReadLine();
                        Labra1.Menu();
                    }

                    //drew new head space and remove too much latest tail at index y - score
                    area[currentVert + vert,currentHor + hor] = '■';

                    currentVert = currentVert + vert;
                    currentHor = currentHor + hor;

                    oldSpaces[y, 0] = currentVert;
                    oldSpaces[y, 1] = currentHor;
                   OldY.Add(currentVert);
                   OldX.Add(currentHor);

                    if (area[OldY.ElementAt(y - score), OldX.ElementAt(y - score)] != 'o')
                    {
                        area[OldY.ElementAt(y - score), OldX.ElementAt(y - score)] = '.';
                    }
                    else { Console.WriteLine("Its 'o' "); Console.ReadLine(); }

                    display(area,dirString);
           
                    Console.WriteLine(currentVert + " " + currentHor);
                    Console.Write("oldY:"+OldY[OldY.Count-1]);
                    Console.Write(" oldX:"+OldX[OldX.Count-1]);
                    Console.WriteLine(" Score:" +score);

                    Console.WriteLine("next score at: " + NewScoreVert +" " + NewScoreHort);
                    //Console.Write("To delete: Y:" + OldY.ElementAt(y)+" X:" + OldX.ElementAt(y)+" Y:" + y);
                    //Console.ReadLine();
                    y++;
                }
                



            }



        }

   }

        
}

