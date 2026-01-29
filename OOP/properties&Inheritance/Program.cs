namespace properties_Inheritance
{
    //    sealed class Vehicle //  sealed class cannot be inherited by keyword "sealed"
    //    {
    //  ...
    //}

    //    class Car : Vehicle
    //    {
    //  ...
    //}

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }
         
    class Person
    {
        private string Name; // property

            public  string name
        {
            get; set;
        }
            
    }

        internal class Program
    {
        
            static void Main(string[] args)
            {
            Person myObj = new Person();
            myObj.name = "Liam";

            Console.WriteLine(myObj.name);

            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

        }
    }
    }

