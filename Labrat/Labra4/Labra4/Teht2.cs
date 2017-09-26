using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Teht2
    {
        public void ElevatorMain()
        {
            Elevator.CurrentFloor = 1;
            Console.WriteLine("Go to floor");
            int newFloor = int.Parse(Console.ReadLine());
            Elevator.GotoFloor(newFloor,Elevator.CurrentFloor);

            Console.WriteLine(Elevator.GotoFloor(newFloor, Elevator.CurrentFloor) + " Current floor: " + Elevator.CurrentFloor);
        }

    }

    public class Elevator
    {
        public static int CurrentFloor;

        public static string GotoFloor(int newFloor,int CurrentFloor)
        {
            if(newFloor < 0 || newFloor > 5 || newFloor == CurrentFloor)
            {
                return "Invalid floor input ";
            }
            else
            {
                Elevator.CurrentFloor = newFloor;
                return "Floor chaned ";
            }       

        }
    }
}
