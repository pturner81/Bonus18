using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1, car2, car3;
            UsedCar car4, car5, car6;
            IntantiateObjects(out car1, out car2, out car3, out car4, out car5, out car6);

            List<Car> cars = new List<Car>() { car1, car2, car3, car4, car5, car6 };

            string cont = "y";
            while (cont == "y" || cont == "yes")
            {
                PrintList(cars);
                Console.WriteLine();

                int x = WhichCar(cars);

                x = IsOption(x, cars);
                cars[x - 1].PrintList();

                string buy = BuyOption();

                buy = BuyOrNot(buy);

                Result(cars, x, buy);

                PrintList(cars);

                Console.WriteLine();
                Console.WriteLine("Would you like to view/buy another car? (y/n)");
                cont = ValidateString(Console.ReadLine());
                Console.Clear();
            }
        }

        private static void Result(List<Car> cars, int x, string buy)
        {
            if (buy == "no" || buy == "n")
            {
                Console.Clear();
            }
            else
            {
                cars.RemoveAt(x - 1);
            }
        }

        private static string BuyOption()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to buy the car? (y/n)");
            string buy = ValidateString(Console.ReadLine());
            return buy;
        }

        private static int WhichCar(List<Car> cars)
        {
            Console.WriteLine($"Which car would you like to see? (1-{cars.Count()})");
            int x = ValidateInt(Console.ReadLine());
            return x;
        }

        public static string BuyOrNot(string validatedInput)
        {
            while (validatedInput != "y" && validatedInput != "n" && validatedInput != "yes" && validatedInput != "no")
            {
                Console.WriteLine("That is not an option- Please enter a valid option (y/n)");
                string UserInput = Console.ReadLine();
                validatedInput = ValidateString(UserInput);
            }
            return validatedInput;
        }

        private static void IntantiateObjects(out Car car1, out Car car2, out Car car3, out UsedCar car4, out UsedCar car5, out UsedCar car6)
        {
            //Instantiate
            car1 = new Car("Nikolai", "Model S", 2017, 54999.90);
            car2 = new Car("Fourd", "Escapade", 2017, 31999.90);
            car3 = new Car("Chewie", "Vette", 2017, 44989.95);
            car4 = new UsedCar("Hyonda", "Prior", 2015, 14795.5, 35987);
            car5 = new UsedCar("GC", "Chirpus", 2013, 8500, 12345);
            car6 = new UsedCar("GC", "Witherell", 2016, 14450, 3500);
        }

        private static void PrintHeaders()
        {
            Console.Write("Make".PadRight(15));
            Console.Write("Model".PadRight(15));
            Console.Write("Year".PadRight(15));
            Console.Write("Price".PadRight(15));
            Console.WriteLine("Mileage");
            Console.WriteLine("=========================================================================");
        }

        public static void PrintList(List<Car> cars)
        {
            PrintHeaders();
            foreach (Car c in cars)
            {
                c.PrintList();
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        public static int ValidateInt(string UserInput1)
        {
            try
            {
                int.Parse(UserInput1);
                return (int.Parse(UserInput1));
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
        public static int IsOption(int validatedInput, List<Car> cars)
        {
            while (validatedInput <= 0 || validatedInput >= cars.Count + 1)
            {
                Console.WriteLine("That is not an option- Please enter a valid number/option");
                string UserInput = Console.ReadLine();
                validatedInput = ValidateInt(UserInput);
            }
            return validatedInput;



        }
        public static string ValidateString(string UserInput)
        {//Extended Chalenge
            try
            {
                UserInput = UserInput.ToLower();
                return (UserInput);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return "0";
            }
            catch (Exception f)
            {
                Console.WriteLine(f.Message);
                return "0";
            }
        }
    }
}
