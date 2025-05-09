using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Welcome to C# Programming");

            // Escape Sequence always add in "" string 
            //  \' , \" , \n , \t ,   

            string data = "Hello \"C#\"";

            Console.WriteLine(data);

            Console.Write("Hello World \n");
            Console.Write("Welcome to C# Programming\t");
            Console.Write("Hello \n World\n");

            Console.Write("\n\n\n");
            // Operator  
            // arithmatic (+ - * \) , assignment (+= , -= , *= , /= , ++ , -- )
            // , Comparion (< , > , <= , >= ,== , === , != ) & logical (&& , || , !)

            string studentName = "Ali Raza";
            int maths = 50;
            int eng = 12;
            int urdu = 72;

            int total = maths + eng + urdu;
            double percent = total/300F * 100;

            Console.WriteLine("\" MARKSHEET \"");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Maths: {maths}");
            Console.WriteLine($"English: {eng}");
            Console.WriteLine($"Urdu: {urdu}");
            Console.WriteLine($"Total marks: {total}");
            Console.WriteLine($"Percentage: {Math.Round(percent)}");


            Console.ReadKey();
        }
    }
}
