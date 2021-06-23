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

            if(StudentString == "Y")
            {
                isStudent = true;
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
    }
}
