using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAI
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        class oldSpaces
        {
            // List to collect the snakes body.
            // Make optimized version following only head and the last bit of tail to save memory??
            public int oldY { get; set; }
            public int oldX { get; set; }

            public virtual ICollection<Program> GENRES { get; set; }
        }
        public class MoveParams
        {
            public int currentVert { get; set; }
            public int currentHor { get; set; }
            public int vert { get; set; }
            public int hor { get; set; }
            public string dirString { get; set; }
            public bool paused { get; set; }

            public const int rows = 10;
            public const int columns = 20;

            public static void ChangeDir(string newDir,MoveParams GmPrms)
            {
                if(newDir == "Up" && GmPrms.dirString != "Down")
                {
                    GmPrms.vert = -1;
                    GmPrms.hor = 0;
                    GmPrms.dirString = "Up";
                }
                if (newDir == "Down" && GmPrms.dirString != "Up")
                {
                    GmPrms.vert = 1;
                    GmPrms.hor = 0;
                    GmPrms.dirString = "Down";
                }
                if (newDir == "Right" && GmPrms.dirString != "Left")
                {
                    GmPrms.vert = 0;
                    GmPrms.hor = 1;
                    GmPrms.dirString = "Right";
                }
                if (newDir == "Left" && GmPrms.dirString != "Right")
                {
                    GmPrms.vert = 0;
                    GmPrms.hor = -1;
                    GmPrms.dirString = "Left";
                }
            }
        }
        public static void display(char[,] area, string dirString)
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
        public static void Main()
            {
                List<int> OldY = new List<int>();
                List<int> OldX = new List<int>();
                
                int[,] oldSpaces = new int[100000, 2];
                double TimeElapsed;
                bool Alive = true;
                Random rnd = new Random();

            MoveParams GmPrms = new MoveParams();
            //initialisoi peli
            TimeElapsed = 0;
            GmPrms.dirString = "O";
            GmPrms.vert = 0;
            GmPrms.hor = 0;     
            GmPrms.currentHor = 11;
            GmPrms.currentVert = 5;
                System.Timers.Timer timer = new System.Timers.Timer();
                timer.Enabled = true;
                timer.Start();
                Stopwatch t = new Stopwatch();
                // riviä, saraketta
                //vert hor          
                char[,] area = new char[MoveParams.rows, MoveParams.columns];
                for (int i = 0; i < area.GetLength(0); i++)// tehdään sarake 1,2,3
                {
                    for (int j = 0; j < area.GetLength(1); j++) // rivi sarake 1,2,3
                    {
                        area[i, j] = '.';
                    }
                }
                area[GmPrms.currentVert, GmPrms.currentHor] = 's';
                int score = 0;
                int y = 0;
                
                //empty needed to not remove the actual head, y -1 index would go out of index in the 1st loop.
                OldY.Add(0);
                OldX.Add(0);

                int NewScoreVert = rnd.Next(0, MoveParams.rows);
                int NewScoreHort = rnd.Next(0, MoveParams.columns);

                NewScoreVert = 0;
                NewScoreHort = 3;
                area[NewScoreVert, NewScoreHort] = 'o';

                GmPrms.paused = false;
                display(area, GmPrms.dirString);
                Console.WriteLine("Press any direction to start, Space to pause");
                Console.ReadKey();

                area[GmPrms.currentVert, GmPrms.currentHor] = '.';
                while (Alive)
                {
                    //Timer for "game ticks"
                    t.Start();
                    TimeSpan ts = t.Elapsed;
                    TimeElapsed = ts.Milliseconds;
                
                if (TimeElapsed > 15)// new game tick every x milliseconds.
                    {
                    //GetKeyPress(GmPrms);
                    FailProofAI(area, GmPrms, y, NewScoreVert, NewScoreHort);
                    //UseAI(area,GmPrms, y,NewScoreVert, NewScoreHort);
                    //SwitchCaseAI(area, GmPrms, y, NewScoreVert, NewScoreHort);

                    t.Reset();
                        TimeElapsed = 0;

                        //game "Game Over" instead of program chrasing
                        if ((GmPrms.currentVert + GmPrms.vert < 0 || GmPrms.currentVert + GmPrms.vert > MoveParams.rows - 1) || (GmPrms.currentHor + GmPrms.hor < 0 || GmPrms.currentHor + GmPrms.hor > MoveParams.columns - 1 || area[GmPrms.currentVert + GmPrms.vert, GmPrms.currentHor + GmPrms.hor] == '█'))
                        {
                        Console.WriteLine("Game Over");
                        area[GmPrms.currentVert, GmPrms.currentHor] = 'E';
                        display(area, GmPrms.dirString);
                        Console.WriteLine(" Score:" + score);
                        Console.WriteLine(GmPrms.currentVert + " " + GmPrms.currentHor);
                        Console.Write("oldY:" + OldY[OldY.Count - 1]);
                        Console.Write(" oldX: " + OldX[OldX.Count - 1]);
                        Console.WriteLine();
                        Console.Write("hor: " + GmPrms.hor + " vert:" + GmPrms.vert);
                        Console.WriteLine("  next score at: " + "Y: " + NewScoreVert + " X: " + NewScoreHort);// + area[NewScoreVert, NewScoreHort]);
                        Console.WriteLine("Current Y " + GmPrms.currentVert + " Current X " + GmPrms.currentHor);
                        Console.WriteLine(y);
                        Console.ReadLine();
                            Main();
                        }

                        if (GmPrms.currentVert == NewScoreVert && GmPrms.currentHor == NewScoreHort)//(area[GmPrms.currentVert + GmPrms.vert, GmPrms.currentHor + GmPrms.hor] == 'o')
                        {
                            score++;

                        do// let's make new location for collectable, its good when its not in the snake.
                        {
                            NewScoreVert = rnd.Next(0, MoveParams.rows);
                            NewScoreHort = rnd.Next(0, MoveParams.columns);

                        } while (GmPrms.currentHor == NewScoreHort && GmPrms.currentVert == NewScoreVert || area[NewScoreVert, NewScoreHort] == '█');

                            area[NewScoreVert, NewScoreHort] = 'o';
                            //Console.WriteLine("next score at function: " + NewScoreVert + " " + NewScoreHort +"          "+ area[NewScoreVert, NewScoreHort]);
                            //Console.ReadLine();
                        }



                        //draw new head space and remove too much latest tail at index y - score
                        area[GmPrms.currentVert + GmPrms.vert, GmPrms.currentHor + GmPrms.hor] = '█'; // places of new head

                    GmPrms.currentVert = GmPrms.currentVert + GmPrms.vert;
                    GmPrms.currentHor = GmPrms.currentHor + GmPrms.hor;

                        oldSpaces[y, 0] = GmPrms.currentVert;
                        oldSpaces[y, 1] = GmPrms.currentHor;
                        OldY.Add(GmPrms.currentVert);
                        OldX.Add(GmPrms.currentHor);

                        if (area[OldY.ElementAt(y - score), OldX.ElementAt(y - score)] != 'o')
                        {
                            area[OldY.ElementAt(y - score), OldX.ElementAt(y - score)] = '.'; // location of the last bit of tail, remove it.
                        }
                        else
                        { 
                        }

                    display(area, GmPrms.dirString);
                    Console.WriteLine(" Score:" + score);
                    Console.WriteLine(GmPrms.currentVert + " " + GmPrms.currentHor);
                    Console.Write("oldY:"+OldY[OldY.Count-1]);
                    Console.Write(" oldX: "+OldX[OldX.Count-1]);
                    Console.WriteLine();
                    Console.Write("hor: " + GmPrms.hor + " vert:" + GmPrms.vert);
                    Console.WriteLine("  next score at: " + "Y: " + NewScoreVert + " X: " + NewScoreHort + area[NewScoreVert, NewScoreHort]);// + area[NewScoreVert, NewScoreHort]);
                    Console.WriteLine("Current Y " + GmPrms.currentVert + " Current X " + GmPrms.currentHor);
                    //Console.WriteLine();
                    y++;
                }
            }
        }


        public static void UseAI(char[,] area,MoveParams GmPrms,int y, int NewScoreVert, int NewScoreHort)
        {
            if(y == 0)
            {
                GmPrms.vert = -1;
                GmPrms.hor = 0;
                GmPrms.dirString = "Up";
            }
            //if we are moving vertically
            if (GmPrms.dirString == "Down" || GmPrms.dirString == "Up")
            {
                if (GmPrms.dirString == "Up" && GmPrms.currentVert + GmPrms.vert < 0)//Dodge upper wall...
                {
                    //...To the direction of the score
                    if (GmPrms.currentHor < NewScoreHort)
                    {
                        MoveParams.ChangeDir("Right", GmPrms);
                    }
                    else if (GmPrms.currentHor > NewScoreHort)
                    {
                        MoveParams.ChangeDir("Left", GmPrms);
                    }

                    else if (GmPrms.currentHor == NewScoreHort)
                    {
                        if (GmPrms.currentHor - 1 < 0)
                        {
                            MoveParams.ChangeDir("Right", GmPrms);
                        }
                        else if (GmPrms.currentHor + 1 < MoveParams.columns)
                        {
                            MoveParams.ChangeDir("Left", GmPrms);
                        }
                    }
                }

                else if (GmPrms.dirString == "Down" && GmPrms.currentVert + GmPrms.vert > MoveParams.rows - 1)//Dodge Bottom wall....
                {

                    //...To the direction of the score
                    if (GmPrms.currentHor < NewScoreHort)
                    {
                        MoveParams.ChangeDir("Right", GmPrms);
                    }
                    else if (GmPrms.currentHor > NewScoreHort)
                    {
                        MoveParams.ChangeDir("Left", GmPrms);
                    }
                    else if (GmPrms.currentHor == NewScoreHort)
                    {
                        if (GmPrms.currentHor - 1 < 0)
                        {
                            MoveParams.ChangeDir("Right", GmPrms);
                        }
                        else if (GmPrms.currentHor + 1 < MoveParams.columns)
                        {
                            MoveParams.ChangeDir("Left", GmPrms);
                        }
                    }

                }

                else if (GmPrms.dirString == "Down" && area[GmPrms.currentVert + GmPrms.vert , GmPrms.currentHor + GmPrms.hor] == '█')//Dodge own tail
                {
                    MoveParams.ChangeDir("Left", GmPrms);
                }

                else if (GmPrms.dirString == "Up" && area[GmPrms.currentVert + GmPrms.vert, GmPrms.currentHor + GmPrms.hor] == '█')//Dodge own tail
                {
                    MoveParams.ChangeDir("Left", GmPrms);
                }


                //Go to catch score
                else if (GmPrms.dirString == "Up" && GmPrms.currentVert == NewScoreVert && GmPrms.currentHor > NewScoreHort && area[GmPrms.currentVert,GmPrms.currentHor-1] != '█')// if moving up and the score is on the same row and left of you turn there
                {
                    MoveParams.ChangeDir("Left", GmPrms);
                }

                else if (GmPrms.dirString == "Up" && GmPrms.currentVert == NewScoreVert && GmPrms.currentHor < NewScoreHort && area[GmPrms.currentVert, GmPrms.currentHor + 1] != '█')// if moving up and the score is on the same row and right of you turn there
                {
                    MoveParams.ChangeDir("Right", GmPrms);
                }

                else if (GmPrms.dirString == "Down" && GmPrms.currentVert == NewScoreVert && GmPrms.currentHor > NewScoreHort && area[GmPrms.currentVert, GmPrms.currentHor - 1] != '█')// if moving down and the score is on the same row and left of you turn there
                {
                    MoveParams.ChangeDir("Left", GmPrms);
                }

                else if (GmPrms.dirString == "Down" && GmPrms.currentVert == NewScoreVert && GmPrms.currentHor < NewScoreHort && area[GmPrms.currentVert, GmPrms.currentHor + 1] != '█')// if moving down and the score is on the same row and right of you turn there
                {
                    MoveParams.ChangeDir("Right", GmPrms);
                }
             
            }

            // if we move horizontally
            if (GmPrms.dirString == "Left" || GmPrms.dirString == "Right")
            {
                if (GmPrms.dirString == "Left" && GmPrms.currentHor + GmPrms.hor < 0) // Dodge left wall...
                {
                    //... To the direction of the score
                    if (GmPrms.currentVert < NewScoreVert)
                    {
                        MoveParams.ChangeDir("Down", GmPrms);
                    }
                    else if (GmPrms.currentVert > NewScoreVert)
                    {
                        MoveParams.ChangeDir("Up", GmPrms);
                    }
                    else if (GmPrms.currentVert == NewScoreVert)
                    {
                        if (GmPrms.currentVert - 1 < 0)
                        {
                            MoveParams.ChangeDir("Down", GmPrms);
                        }
                        else if (GmPrms.currentHor + 1 < MoveParams.columns)
                        {
                            MoveParams.ChangeDir("Up", GmPrms);
                        }
                    }

                }

                else if (GmPrms.dirString == "Right" && GmPrms.currentHor + GmPrms.hor > MoveParams.columns -1) // Dodge right wall...
                {
                    //... To the direction of the score
                    if (GmPrms.currentVert < NewScoreVert)
                    {
                        MoveParams.ChangeDir("Down", GmPrms);
                    }
                    else if (GmPrms.currentVert > NewScoreVert)
                    {

                        MoveParams.ChangeDir("Up", GmPrms);
                    }

                    else if (GmPrms.currentVert == NewScoreVert)
                    {
                        if (GmPrms.currentVert - 1 < 0)
                        {
                            MoveParams.ChangeDir("Down", GmPrms);
                        }
                        else if(GmPrms.currentHor + 1 < MoveParams.columns)
                        {
                            MoveParams.ChangeDir("Up", GmPrms);
                        }
                        else { MoveParams.ChangeDir("Up", GmPrms); }
                    }
                }

                else if (area[GmPrms.currentVert + GmPrms.vert, GmPrms.currentHor + GmPrms.hor] == '█')//Dodge own tail
                {
                    MoveParams.ChangeDir("Up", GmPrms);
                }

                //Go to catch score
                else if (GmPrms.dirString == "Right" && GmPrms.currentHor == NewScoreHort && GmPrms.currentVert > NewScoreVert && area[GmPrms.currentVert -1, GmPrms.currentHor] != '█')// if moving right and the score is on the same row and left of you turn there
                {
                    MoveParams.ChangeDir("Up", GmPrms);
                }

                else if (GmPrms.dirString == "Right" && GmPrms.currentHor == NewScoreHort && GmPrms.currentVert < NewScoreVert && area[GmPrms.currentVert + 1, GmPrms.currentHor] != '█')// if moving right and the score is on the same row and left of you turn there
                {
                    MoveParams.ChangeDir("Down", GmPrms);
                }

                else if (GmPrms.dirString == "Left" && GmPrms.currentHor == NewScoreHort && GmPrms.currentVert > NewScoreVert && area[GmPrms.currentVert - 1, GmPrms.currentHor] != '█')// if moving left and the score is on the same row and left of you turn there
                {
                    MoveParams.ChangeDir("Up", GmPrms);
                }

                else if (GmPrms.dirString == "Left" && GmPrms.currentHor == NewScoreHort && GmPrms.currentVert < NewScoreVert && area[GmPrms.currentVert + 1, GmPrms.currentHor] != '█')// if moving left and the score is on the same row and left of you turn there
                {
                    MoveParams.ChangeDir("Down", GmPrms);
                }

            }

        }
        public static void FailProofAI(char[,] area, MoveParams GmPrms, int y, int NewScoreVert, int NewScoreHort)
        {
            if (y == 0)
            {
                MoveParams.ChangeDir("Down",GmPrms);

            }

            switch (GmPrms.dirString)
            {
                case "Up":
                    if (GmPrms.dirString == "Up" && GmPrms.currentVert + GmPrms.vert < 0)
                    {
                        MoveParams.ChangeDir("Right", GmPrms);
                    }
                break;

                case "Right":
                    if (GmPrms.dirString == "Right" && GmPrms.currentVert - 1 < 0)
                    {
                        MoveParams.ChangeDir("Down", GmPrms);
                    }
                    if (GmPrms.dirString == "Right" && GmPrms.currentVert + 3 > MoveParams.rows)
                    {
                        MoveParams.ChangeDir("Up", GmPrms);
                    }

                    break;

                case "Down":
                    if (GmPrms.dirString == "Down" && GmPrms.currentVert + GmPrms.vert > MoveParams.rows-2 && GmPrms.currentHor + 1 < MoveParams.columns)
                    {
                        MoveParams.ChangeDir("Right", GmPrms);
                    }
                    else if(GmPrms.currentVert + GmPrms.vert > MoveParams.rows-1)
                    {
                        MoveParams.ChangeDir("Left", GmPrms);
                    }
                    break;

                case "Left":
                    if (GmPrms.currentHor + GmPrms.hor < 0)
                    {
                        MoveParams.ChangeDir("Up", GmPrms);
                    }
                    break;

            }



        }
        public static void SwitchCaseAI(char[,] area, MoveParams GmPrms, int y, int NewScoreVert, int NewScoreHort)
        {
            if (y == 0)
            {
                MoveParams.ChangeDir("Up", GmPrms);
            }

            switch (GmPrms.dirString)
            {
                case "Up"://------------------------------------------------------------------------
                    if(GmPrms.currentVert + GmPrms.vert < 0)
                    {
                        /* if (GmPrms.currentHor < NewScoreHort)
                         {
                             MoveParams.ChangeDir("Right", GmPrms);
                         }*/
                        MoveParams.ChangeDir("Left", GmPrms);
                        /*else if (GmPrms.currentHor > NewScoreHort)
                        {
                            MoveParams.ChangeDir("Left", GmPrms);
                        }*/

                    }
                    
                    break;

                case "Down"://------------------------------------------------------------------------
                    if (GmPrms.currentVert + GmPrms.vert > MoveParams.rows-1)
                    {
                        MoveParams.ChangeDir("Right", GmPrms);
                    }
                    break;

                case "Left"://------------------------------------------------------------------------

                    if (GmPrms.currentHor + GmPrms.hor < 0)
                    {
                        MoveParams.ChangeDir("Down", GmPrms);
                    }
                        break;

                case "Right"://------------------------------------------------------------------------
                    if (GmPrms.currentHor + GmPrms.hor > MoveParams.columns-1)
                    {
                        MoveParams.ChangeDir("Up", GmPrms);
                    }
                    break;
            }
        }
        public static void GetKeyPress(MoveParams GmPrms)
        {
            if (GetAsyncKeyState(38) != 0 && GmPrms.dirString != "Down")
            {                
                MoveParams.ChangeDir("Up",GmPrms);
            }
            else if (GetAsyncKeyState(40) != 0 && GmPrms.dirString != "Up")
            {
                MoveParams.ChangeDir("Down", GmPrms);
            }

            else if (GetAsyncKeyState(39) != 0 && GmPrms.dirString != "Left")
            {
                MoveParams.ChangeDir("Right", GmPrms);
            }

            else if (GetAsyncKeyState(37) != 0 && GmPrms.dirString != "Right")
            {
                MoveParams.ChangeDir("Left", GmPrms);
            }
            
            else if (GetAsyncKeyState(32) != 0 && GmPrms.paused == false) {; Console.ReadKey(); }
            
        }
        public static void Tree(char[,] area, MoveParams GmPrms, int y, int NewScoreVert, int NewScoreHort)
        {

        }

       
    }

    public static class TreeNode<Node>
    {
        public static int ID { get; set; }
        public static string dir { get; set; }
        public static int parentOff { get; set; }
        public static int childOff { get; set; }

        public static void AddChild()
        {
            
        }
    }
 }

