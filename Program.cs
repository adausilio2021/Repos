//Anastasia D'Ausilio
// Due 1/29/2021
// ISM4300
// Deliverable 2:Iterative Statements
using System;

namespace Iteration_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for user input
            Console.WriteLine("Enter an integer between 1 and 100");

            //use try catch to validate input
            //if user provides bad input, the catch block will handel
            try
            {
                string input = Console.ReadLine();

                //value_of_input is the variable
                int value_of_input = int.Parse(input);
                //allow integer value of 1-100
                if ((value_of_input >= 1) && (value_of_input <= 100))
                {
                    Console.WriteLine("You have entered " + value_of_input.ToString());
                    //for loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine
                            ("This is the current integer value in the loop: " +
                          i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                Console.WriteLine("Please enter integer value and try running the program again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            }
            }
            }
    }

