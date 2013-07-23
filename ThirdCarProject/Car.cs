using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdCarProject
{
    class Car
    {
        private string make;
        private string model;
        private int maxSpeed;

        public Car(string make, string model, int maxSpeed)
        {
            this.make = make;
            this.model = model;
            this.maxSpeed = maxSpeed;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }

        public void PrintCar()
        {
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Max Speed: " + maxSpeed + "mph");
            Console.ReadLine();
        }
    }
}
