namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            Console.WriteLine(greeting);

            Console.WriteLine();

            string greeting2 = "Nice to meet you!";
            Console.WriteLine(greeting2);

            Console.WriteLine();

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);
            Console.WriteLine();

            string txt1 = "Hello World";
            Console.WriteLine(txt1.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt1.ToLower());   // Outputs "hello world"
            Console.WriteLine();

            //concatination

            string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string first2Name = "John ";
            string last2Name = "Doe";
            string name2 = string.Concat(first2Name, last2Name);
            Console.WriteLine(name2);

            int x = 10;
            int y = 20;
            int z = x + y;  // z will be 30 (an integer/number)

            string x1 = "10";
            string y1 = "20";
            string z1= x1 + y1;  // z will be 1020 (a string)
            Console.WriteLine();
            //Interpolation
            string first3Name = "John";
            string last3Name = "Doe";
            string name3 = $"My full name is: {first3Name} {last3Name}";
            Console.WriteLine(name3);
            Console.WriteLine();

            //acess strings

            string myString = "Hello";
            Console.WriteLine(myString[1]);  // Outputs "e"

            string my1String = "Hello";
            Console.WriteLine(my1String.IndexOf("e"));  // Outputs "1"

            // Full name
            string name4 = "John Doe";

            // Location of the letter D
            int charPos = name4.IndexOf("D");

            // Get last name
            string lastName4 = name4.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName4);
            Console.WriteLine();

            //escape sequences

            string txt3 = "The character \\ is called backslash.";
            Console.WriteLine(txt3);
            string txt4= "It\'s alright.";
            Console.WriteLine(txt4);
            string txt5 = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt5);
        }
    }
}
