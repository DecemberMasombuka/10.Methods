using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine(); //User input name
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine()); //User input age
            //Calling the functions created
            SayHi();
            SayHiUser("John");
            SayHiAge("John", 34);
            SayHiAgeUser(name, age);
            Console.Read();

        }

        //Creating or defining Methods
        static void SayHi()
        {
            Console.WriteLine("Hello There");
            
        }

        static void SayHiUser(String name)
        {
            Console.WriteLine("Hello  " + name);
        }

        static void  SayHiAge(String name, int age) 
        {
            Console.WriteLine("Hello " + name + "  Your age is  "+ age);
        }

        static void SayHiAgeUser(String name, int age)
        {
            Console.WriteLine("Hello " + name + "  Your age is  " + age);
        }
    }
}
