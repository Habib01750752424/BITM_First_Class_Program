using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            int age;
            string contactNo = "";
            string address = "";
            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your ContactNumber: ");
            contactNo = Console.ReadLine();

            Console.Write("Enter Your Address: ");
            address = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("My name is: " + name);
            Console.WriteLine("My age: " + age);
            Console.WriteLine("My contact number: " + contactNo);
            Console.WriteLine("and\nMy Address is: " + address);

            Console.ReadKey();
        }
    }
}
