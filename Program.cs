using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string correctUsername = "admin";
            const string correctPassword = "1234";

            bool isAuthenticated = false;

            while (!isAuthenticated)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login successful");
                    isAuthenticated = true;
                }
                else
                {
                    Console.WriteLine("Try again");
                    Console.WriteLine();  
                }
            }
        }
    }
}
   

