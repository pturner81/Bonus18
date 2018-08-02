using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class UsedCar : Car
    {
        //fields
        private double miles;

        //properties
        public double Miles
        {
            set { miles = value; }
            get { return miles; }
        }

        //default constructor
        public UsedCar()
        {
            miles = 1000;
        }
        //override constructor
        public UsedCar(string ma, string mo, int ye, double pr, double mi) : base(ma, mo, ye, pr)
        {
            Miles = mi;
        }
        //methods
        public override void PrintList()
        {
            base.PrintList();
            Console.Write($"{Miles}");
        }
    }
}
