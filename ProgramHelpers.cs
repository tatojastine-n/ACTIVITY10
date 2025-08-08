using System;

namespace ValidateMyInfo
{
    internal static class ProgramHelpers
    {     
        static void Main(string[] args)
        {          
            Console.Write("Enter your name: ");
            string name = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name required.");
                return;
            }
            
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            
            if (!int.TryParse(ageInput, out int age) || age < 1 || age > 120)
            {
                Console.WriteLine("Invalid age.");
                return;
            }
           
            Console.Write("Enter your email: ");
            string email = Console.ReadLine().Trim();

            if (!email.Contains("@"))
            {
                Console.WriteLine("Invalid email.");
                return;
            }            
            Console.WriteLine("All fields are valid.");
        }
       
    }
}