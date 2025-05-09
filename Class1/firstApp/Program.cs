using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World"); // Print 
            Console.WriteLine("C# First Application");

            //Console.WriteLine("Enter Your Name: ");
            //Console.ReadLine(); // Get User data

            //Console.WriteLine("Enter your Age");
            //Console.ReadLine();

            int number = 60; // integer 
            string name = "Nisa"; // string 
            float fnum = 12.21F; // float
            double db = 12.12345;
            char b = 'A';
            bool tf = true;
            Console.WriteLine($"Integer: {number}, String: {name}, Float {fnum}");


            Console.ReadKey();
        }
    }
}
