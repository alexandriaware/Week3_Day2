using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2
{
    class Program
    {
        static void Main(string[] args)
        {

            Boat boaty = new Boat(3, "Boaty", 18.6);
            boaty.Move();
            boaty.BoatInfo();

            Boat misterBoat = new Boat(14, "MisterBoat", 30.8);
            misterBoat.BoatInfo();
        }
    }
}
