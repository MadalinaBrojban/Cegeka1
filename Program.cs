using System;

namespace app1
{
    public class Car
    {
        public string model;
        private static int instances = 0;

        public Car()
        {
            instances++;
        }
        ~Car()
        {
            instances--;
        }
        public static int GetActiveInstances()
        {
            return instances;
        }
        public Car(string model)
        {
            this.model = model;
        }

        public static int carCounter;

        public static int AddCar()
        {
            return ++carCounter;
        }
        public class Package {
            enum packageType { Entry, Premium};
            enum engine {mechanical, pneumatic };
            enum transmission { automotive, manual};

        }
    }
    class MainClass
    {
        static void Main()
        {
           
            Car c1 = new Car();
            c1.model = "Mercedes";

            Console.Write("Enter a new car model: ");
            string model = Console.ReadLine();
            Console.Write("How many car models: ");
            string n = Console.ReadLine();
            int count = Car.GetActiveInstances();
            Car.carCounter = Int32.Parse(n);
            int total = count+Int32.Parse(n);
            Car.AddCar();

            // Display the new information.
            Console.WriteLine($"desired car model: {model}");
            Console.WriteLine($"amount of cars manufactured: {total}");
            Console.WriteLine($"models created by company:{c1.model}");


        }
    }
}
