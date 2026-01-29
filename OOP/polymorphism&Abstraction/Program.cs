namespace polymorphism_Abstraction
{

    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Animal1  // Base class (parent) 
        {
            public virtual void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Pig1 : Animal1  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal1  // Derived class (child) 
        {
            public override void animalSound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }

    internal class Program
    {
        static void Main(string[] args)
            {
            //polymorphism
                Animal1 myAnimal = new Animal1();  // Create a Animal object
                Animal1 myPig = new Pig1();  // Create a Pig object
                Animal1 myDog = new Dog();  // Create a Dog object

                myAnimal.animalSound();
                myPig.animalSound();
                myDog.animalSound();

            //Abstraction
            
                Pig myPig2 = new Pig(); // Create a Pig object
            myPig2.animalSound();  // Call the abstract method
            myPig2.sleep();  // Call the regular method
        }
        }
    }





      

