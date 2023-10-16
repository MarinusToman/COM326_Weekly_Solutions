namespace CarLibrary
{
    public class Engine
    {
        private int cylinders;
        private double hp;

        public int Cylinders
        {
            get { return cylinders; }
            set { cylinders = value; }
        }

        public double Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public Engine()
        {
            cylinders = 0;
            hp = 0;
        }

        public Engine(int cylinders, double hp)
        {
            this.cylinders = cylinders;
            this.hp = hp;
        }

        public void Start()
        {
            Console.WriteLine("Engine starting");
        }

        public void Stop() { Console.WriteLine("Engine stopping"); }

    }
}