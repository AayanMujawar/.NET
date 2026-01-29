namespace interface_Enums
{
    // Interface
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    enum Months
    {
        January,    // 0
        February,   // 1
        March,      // 2
        April,      // 3
        May,        // 4
        June,       // 5
        July        // 6
    }

    public static void checkAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Access denied - You must be at least 18 years old.");
        }
        else
        {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }

  

    class Program
    {
        static void Main(string[] args)
        {
            // Interface
            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();

            // Enum
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);

            //EXCEPTION
            checkAge(15);
        }
    }
}

