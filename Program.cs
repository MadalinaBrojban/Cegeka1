using System;
using System.Collections.Generic;

namespace app1
{
    public class Car
    {
        public string model;
        public static string color = "black";

        public Car(string model) {
            this.model = model;
        }

    }
    public class Package {
        public string packageType;
        public double enginePower;
        public string transmission;

        public Package(string packageType, double enginePower, string transmission) {
            this.packageType = packageType;
            this.enginePower = enginePower;
            this.transmission = transmission;
        }
     
    }
    
    class MainClass
    {
        static void Main()
        {

            Car c1 = new Car("Mercedes");
            Car c2 = new Car("WW");
            Package p1 = new Package("Entry", 1.9, "manual transmission");
            Package p2 = new Package("Premium", 2.7, "automotive transmission");
            List<Car> cars = new List<Car>();
            cars.Add(c1);
            cars.Add(c2);
            int count = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine("Model "+i+": "+ cars[i].model);
                count++;
            }
            Console.WriteLine("The amount of cars manufactured: "+count);

            Console.Write("Enter a new car model: ");
            string newModel = Console.ReadLine();
            Console.Write("How many car models do you want: ");
            string n = Console.ReadLine();
            int total = count + Int32.Parse(n);

            // Display the new information.
            Console.WriteLine("Desired car model: " +newModel);
            Console.WriteLine("The amount of cars manufactured: " +total);
            Console.WriteLine("Color of all cars: "+Car.color);



        }
    }
}
