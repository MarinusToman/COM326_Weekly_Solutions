namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            double radius = 0;
            double height = 0;
            double volumeOfCylinder = 0;

            do
            {
                // Get user option
                Console.WriteLine("1. Enter radius to find area of a circle");
                Console.WriteLine("0. Exit application");
                Console.WriteLine("Enter an option:");
                option = Convert.ToInt32(Console.ReadLine());
                // check option
                switch(option)
                {
                    case 0:
                        Console.WriteLine("Goodbye");
                        break;
                    case 1:
                        Console.WriteLine("Enter radius:");
                        radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter height:");
                        height = Convert.ToDouble(Console.ReadLine());
                        volumeOfCylinder = CylinderVolume(radius, height);
                        volumeOfCylinder = Math.Round(volumeOfCylinder);
                        Console.WriteLine($"Volume of the cylinder is {volumeOfCylinder}");
                        break;
                    default: 
                        Console.WriteLine("Please enter a valid option");
                        break;
                }
                Console.WriteLine();
            } while (option != 0);
            
        }

        static double CircleArea(double radius)
        {
            // calc area of circle
            double area = Math.PI*Math.Pow(radius,2);
            // return area of circle
            return area;
        }

        static double CylinderVolume(double radius, double height)
        {
            double areaOfCircle = CircleArea(radius);
            double volume = areaOfCircle * height;

            return volume;
        }
    }
}