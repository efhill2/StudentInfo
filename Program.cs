using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Threading;

namespace StudentInfo
{
    class Program
    {
            
        
        static void Main(string[] args)
        {
            string[] name = { "Eugene", "Steven", "Jasmine" };
            string[] favFood = { "Ice Cream Sandwiches", "Bar B Chips", "Grapes" };
            string[] prevTitle = { "Junior", "Senior", "Sophomore" };

            string ansInput;
            string choiceInput;

            string s1 = "favorite food";
            string s2 = "previous title";
            
            int userInput;


            do
            {
                Console.WriteLine("Please pick a student: \n" +
               "1: Eugene, \n" +
               "2: Steven, \n" +
               "3: Jasmine ");

                userInput = Convert.ToInt32(Console.ReadLine());

                int idNumber = userInput;

                if (userInput == 1)
                {
                    Console.WriteLine("");
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("");     
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Not a choice");
                }

                do
                {
                    Console.WriteLine($"{name[idNumber - 1]}, what would you like to know? (\"Favorite food or Previous title\")");

                    Console.WriteLine("");

                    choiceInput = Console.ReadLine().ToLower();

                    if (choiceInput == s1)
                    {
                        Console.WriteLine($"{name[idNumber - 1]} favorite food is {favFood[idNumber - 1]}");
                    }
                    else if (choiceInput == s2)
                    {
                        Console.WriteLine($"{name[idNumber - 1]} previous title was {prevTitle[idNumber - 1]}");
                    }
                    else
                    {
                        Console.WriteLine("Not a choice");
                    }
                } while (choiceInput != s1 && choiceInput != s2);

                Console.WriteLine("");

                Console.WriteLine("Would you like to know more? (yes or no)");

                ansInput = Console.ReadLine().ToLower();

                try
                {
                    if (ansInput == "no")
                    {
                        Console.WriteLine("Goodbye");
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid input");
                }
            } while (ansInput == "yes");
        }
    }
}
