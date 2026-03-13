using System.Runtime.CompilerServices;
using System;
using System.ComponentModel;
namespace generics_and_lambda_exprn
{


     class Program
    {
        
        static void Main(string[] args)
        {
            //          ArrayList list1 = new ArrayList();
            //list1.add(1);
            //list1.add("om");
            //CallConvThiscall type of collection is not type safe need to convert type casting
            //Console.WriteLine("Hello, World!");

            //2 remain
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add("Omkar");// errror will gt while coding , compile time type checking 


            MyClass<int> obj1 = new MyClass<int>();
            obj1.data = 10;
            obj1.fun();


            MyClass<String> obj2 = new MyClass<String>();
            obj2.data = "omkar";
            obj2.fun();

            
            
            List<int> num = new List<int>() { 1, 2, 3, 4, 5 };
            var even = num.Where(n => n % 2 == 0);

            foreach (var item in even)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    class MyClass<T>
    {
        public T data;
        public void fun()
        {
            Console.WriteLine(data);
        }
    }

}



// generics allow us to define classes and methods and and collections with a placeholder  for a datatype so they work withany datatype while maintaining type safety

// write 2 examples with generics where we use generics in company level  its used for clean code.

// lamda exprn is short way of writing anonymous methods using the arrow operators 
//syntax = (parameters) => expression

//lambda exp with list

//activity : 2 exps on lambda expression and company uses;

//create generic class to store 2 values

// what is generics , why its better than array list

// what is constraints in generics 

// what is lamda expressio diff beteween deligate and lambda

//2types programming in C#
// synchronous and asynchronous

//synchronous : task execute line by line , one after another , blocking behaviour.2.60
