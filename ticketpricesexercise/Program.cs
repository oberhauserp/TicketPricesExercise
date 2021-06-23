using System;

namespace TicketPricesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 0;
            bool isStudent = false;

            Console.WriteLine("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Are you a student? Y/N ");
            string StudentString = Console.ReadLine().ToUpper();

            try
            {
               isStudent = CheckStudent(StudentString);           
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error: Letter can only be Y or N for student!");
                System.Environment.Exit(1);
            }
                
            try
            {
                price = ProcessAge(age,isStudent);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error: Number cannot be negative!");
                System.Environment.Exit(1);
            }

            Console.WriteLine("Your ticket price is " + price);
        }



        static int ProcessAge(int age, bool isStudent)
        {
            int price;
            if (age < 0)
            {
                throw new ArgumentException();
            }
            else if (age >= 65 && isStudent == false)
            {
                price = 10;
            }
            else if (age >= 13 && age <= 64 && isStudent == false)
            {
                price = 14;
            }
            else
            {
                price = 8;
            }

            return price;
        }


        static bool CheckStudent(string StudentString)
        {
             if (StudentString == "Y")
                {
                    return true;
                }
                else if(StudentString == "N")
                {
                    return false;
                }
                else
                {
                    throw new ArgumentException();
                }
        }

    }
}
