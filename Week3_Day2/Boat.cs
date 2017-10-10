using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2
{
    class Boat
    {
        //fields - describes characteristics of properties -- information about the specific instances
        public int numberOfPassengers;
            
        private string name;
        private double engineSize;


        //Property - 
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }


        //Constructors -- used to create something 
        public Boat()
        {

        }

        public Boat(int numberOfPassengers, string name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }


        //Methods
        public void Move()
        {
            Console.WriteLine(name + " moves forward.");
        }

        private double CalculateMPG() // <---only code inside the Boat class can use this bc Private
        {
            double MPG = engineSize * .7d;

            return MPG;
        }

    }
}
