namespace constructors_accessmodifiers
{

    internal class Program
    {
        class Car1
        {
           
            public int brandCode = 991;
        }
            class Car
        {
            public string model;
            public string color;
            public int year;
            int brandCode = 991; // private by default

            // Create a class constructor with multiple parameters
            public Car(string modelName, string modelColor, int modelYear)
            {
                model = modelName;
                color = modelColor;
                year = modelYear;
            }

            static void Main(string[] args)
            {
                Car Ford = new Car("Mustang", "Red", 1969);
                Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
                Console.WriteLine(Ford.brandCode);
                Car1 Ford1 = new Car1();
                Ford1.brandCode = 992;
                Console.WriteLine(Ford1.brandCode);//outside class declaration acces because public
            }
        }


    }
}
