using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdCarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = ReadInt("How many cars would you like to create?");


            for (int i = 0; i < numberOfCars; i++)
            {
                string make = string.Empty;
                bool makeIsValid = false;
                while (makeIsValid == false)
                {
                    Console.WriteLine("Please enter the make of your car (Must be 10 characters or less):");
                    make = Console.ReadLine();

                    if (make.Length > 10 || string.IsNullOrEmpty(make))
                    {
                        makeIsValid = false;
                    }
                    else
                    {
                        makeIsValid = true;
                    }
                }

                string model = string.Empty;
                bool modelIsValid = false;
                while (modelIsValid == false)
                {
                    Console.WriteLine("Please enter the model of your car (Must be 15 characters or less):");
                    model = Console.ReadLine();

                    if (model.Length > 15 || string.IsNullOrEmpty(model))
                    {
                        modelIsValid = false;
                    }
                    else
                    {
                        modelIsValid = true;
                    }
                }

                int maxSpeed = ReadInt("Please enter the Maximum speed of your car:", 0, 200);
                
                Car car1 = new Car(make, model, maxSpeed);
                car1.PrintCar();

            }
        }

        private static int ReadInt(string message, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            int enteredValue = 0;
            string enteredString = string.Empty;

            while (true)
            {
                Console.WriteLine(message);
                enteredString = Console.ReadLine();

                if (int.TryParse(enteredString, out enteredValue))
                {
                    if (enteredValue > minValue && enteredValue < maxValue)
                    {
                        return enteredValue;
                    }
                }
            }
        }

    }
}


