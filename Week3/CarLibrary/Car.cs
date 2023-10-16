using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Engine Engine { get; set; }

        public Car()
        {
            Engine = new Engine();
            Make = string.Empty;
            Model = string.Empty;
            Year = 1970;
        }

        public Car(string make, string model, int year, Engine engine)
        {
            Make = make;
            Model = model;
            Year = year;
            Engine = engine;
        }

        public void Drive()
        {
            Engine.Start();
            Console.WriteLine("Driving started");
        }

        public void Stop()
        {
            Engine.Stop();
            Console.WriteLine("Driving stopped");
        }
    }
}
