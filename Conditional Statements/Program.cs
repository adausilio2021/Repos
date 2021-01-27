//Anastasia D'Ausilio
//Due 01/29/2021
//ISM4300
//Deliverable 2:Conditional Statements

using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for input
            Console.WriteLine("What grade do you expect in ISM4300");
            //use try catch to validate user input
            try
            {
                string input = Console.ReadLine();
                decimal grade = decimal.Parse(input);

                if ((grade > 0) && (grade < 60)) 
                {
                    Console.WriteLine("You will recieve an F");
                }
                if ((grade >60) && (grade<61))
                {
                    Console.WriteLine("You will recieve a D-");
                }
                if ((grade > 61) && (grade < 67))
                {
                    Console.WriteLine("You will recieve a D");
                }
                if ((grade > 67) && (grade < 69))
                {
                    Console.WriteLine("You will recieve a D+");
                }
                if ((grade > 69) && (grade < 71))
                {
                    Console.WriteLine("You will recieve a C-");
                }
                if ((grade > 71) && (grade < 77))
                {
                    Console.WriteLine("You will recieve a C");
                }
                if ((grade > 77) && (grade < 79)) 
                {
                    Console.WriteLine("You will recieve a C+");
                }
                if ((grade > 79) && (grade < 81)) 
                {
                    Console.WriteLine("You will recieve a B-");
                }
                if ((grade > 81) && (grade < 87))
                {
                    Console.WriteLine("You will recieve a B");
                }
                if ((grade > 87) && (grade < 89))
                {
                    Console.WriteLine("You will recieve a B+");
                }
                if ((grade > 89) && (grade < 91)) 
                {
                    Console.WriteLine("You will recieve an A-");
                }
                if ((grade > 91) && (grade < 97)) 
                {
                    Console.WriteLine("You will recieve an A");
                }
                if (grade > 97)
                {
                    Console.WriteLine("You will recieve an A+");
                }
            }
           catch(Exception)
            //display error message
            {
                Console.WriteLine("please enter vaild integer between 0 and 100");
            }
            }
            
        }


    }

