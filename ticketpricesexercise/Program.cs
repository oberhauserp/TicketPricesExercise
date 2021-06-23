using System;

namespace TicketPricesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 0;
            bool isStudent = false; 
            
            Console.WriteLine("How old are you?");
            int age =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Are you a student?");
            string StudentString = Console.ReadLine();
            
            
            if(StudentString == "Y" || StudentString == "y")
            {
                isStudent = true;
            }

            try
            {
                ProcessAge(age);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Error: Number cannot be negative!");
                System.Environment.Exit(1);
            }

            if(age >=  65 && isStudent == false)
            {
                price = 10;
            }
            else if(age >= 13 && age <= 64 && isStudent == false)
            {
                price = 14;
            }
            else
            {
                price = 8;
            }



            Console.WriteLine("your ticket price is " + price);
        }

    static void ProcessAge(int age)
    {
        if(age < 0)
        {
            throw new ArgumentException("Age must not be a negative number");
        }
    }


    }
}
