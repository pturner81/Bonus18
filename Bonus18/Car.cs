using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Car
    {
        //Fields
        private string make;
        private string model;
        private int year;
        private double price;

        //Properties
        public string Make
        {
            set { make = value; }
            get { return make; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        //default constructor
        public Car()
        {
            Make = "unassigned";
            Model = "unassigned";
            Year = 2000;
            Price = 0;
        }
        //override constructor
        public Car(string ma, string mo, int ye, double pr)
        {
            Make = ma;
            Model = mo;
            Year = ye;
            Price = pr;
        }
        //Methods
        public virtual void PrintList()
        {
            Console.Write($"{Make.PadRight(15)}");
            Console.Write($"{Model.PadRight(15)}");
            Console.Write($"{Year.ToString().PadRight(15)}");
            Console.Write($"{Price.ToString().PadRight(15)}");
        }
    }
}
