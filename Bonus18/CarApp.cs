using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class CarApp
    {
        public int x { set; get; }
        public List<Car> l { set; get; }
        //COnstructors


        //Methods
        public CarApp (int x, List<Car> l)
        {
            
            if (x == 1)
            {
                Program.PrintList(l);
            }
            else if (x == 2)
            {
                AddNewCar(l);
            }
            else if (x == 3)
            {
                Console.WriteLine("Which car would you like to remove?");
                int a = Program.ValidateInt(Console.ReadLine());
                a = Program.IsOption(a, l);
                l.RemoveAt(a);
            }
            else if (x == 4)
            {
                Console.WriteLine("What car would you like to look up?");
                int b = Program.ValidateInt(Console.ReadLine());
                b = Program.IsOption(b, l);
                l[b].PrintList();
            }
            else
            {
                int c, Year;
                string Make, Model;
                double Price;
                CarDetails(l, out c, out Make, out Model, out Year, out Price);

                l[c] = new Car(Make, Model, Year, Price);
            }

        }

        private static void CarDetails(List<Car> l, out int c, out string Make, out string Model, out int Year, out double Price)
        {
            Console.WriteLine("What car would you like to edit?");
            c = Program.ValidateInt(Console.ReadLine());
            c = Program.IsOption(c, l);

            Console.WriteLine("Please provide the car make:");
            Make = (Console.ReadLine());
            Console.WriteLine("Please provide the car model:");
            Model = (Console.ReadLine());
            Console.WriteLine("Please provide the car year:");
            Year = Program.ValidateInt(Console.ReadLine());
            Console.WriteLine("Please provide the car price:");
            Price = ValidateFloat(Console.ReadLine());
        }

        private static void AddNewCar(List<Car> y)
        {
            Console.WriteLine("Please provide the car make:");
            string Make = (Console.ReadLine());

            Console.WriteLine("Please provide the car model:");
            string Model = (Console.ReadLine());

            Console.WriteLine("Please provide the car year:");
            int Year = Program.ValidateInt(Console.ReadLine());

            Console.WriteLine("Please provide the car price:");
            double Price = ValidateFloat(Console.ReadLine());

            Car temp = new Car(Make, Model, Year, Price);
            y.Add(temp);
        }

        public static float ValidateFloat(string UserInput1)
        {//Extended Chalenge
            try
            {
                float.Parse(UserInput1);
                return (float.Parse(UserInput1));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                return 0;
            }
        }

    }
}
