using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_db
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Student Database

            Objective:
            Store and search data using arrays.

            Task:
            Write a program that recognizes invalid inputs when the user requests information about students in a class.
            */

            /*
            What the Application Will Do:
            1. Create 3 arrays and fill them with student information—one with names, one with hometowns, and one with favorite foods.
            2. Prompt the user to ask about a particular student by number. Convert the input to an integer and use it as the index for the arrays to print the student’s name.
            3. Ask the user which category to display: "Hometown" or "Favorite Food." Then display the relevant information.
            4. Ask the user if they would like to learn about another student.
            */

            /*
            Build Specifications:
            - Validate the user number: Use an if statement to check if the number is out of range (less than 1 or greater than the length of the arrays). If so, display a friendly message and allow the user to try again.
            - Validate the category: Ensure the user entered either "Hometown" or "Favorite Food" correctly. If they entered an incorrect category, display a friendly message and re-ask the question.
            - Use the first array’s Length property in your code to handle the array size dynamically instead of hardcoding it.
            */

            /*
            Hints:
            - Make sure all arrays are the same size.
            - Let the user enter a number from 1 up to and including the length of the array. To get the index, subtract 1 from the number they entered.
            - For category validation, use a while loop to ask for valid input and only continue when "Hometown" or "Favorite Food" is entered correctly.
            - Provide clear instructions to the user about what information is available.
            - Ensure polite and grammatically correct messages throughout.
            */

            /*
            Extra Challenges:
            - Provide an option for the user to see a list of all students.
            - Allow the user to search for a student by name.
            - Accept uppercase, lowercase, or portions of words such as "Food" instead of "Favorite Food."
            */

            //Create 3 arrays and fill them with student information—one with names, one with hometowns, and one with favorite foods.
            string[] stuNames = { "Kendall", "Evan", "Ashley", "Ryan", "Josh", "Ethan" };
            string[] stuHomeTowns = { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia" };
            string[] stuFavFoods = { "Pizza", "Burgers", "Tacos", "BBQ", "Sushi", "Pasta" };
            int studentNumber = 0;
            bool moreStudents = true;

            //Provide an option for the user to see a list of all students.
            Console.WriteLine("Would you like to see a list of students? (Y/N)");
            string userChoice3 = Console.ReadLine().ToUpper();
            if (userChoice3 == "Y")
            {
                for (int i = 0; i < stuNames.Length; i++)
                {
                    Console.WriteLine($"{i} {stuNames[i]}");
                }
            }
            else
            {
                Console.WriteLine("Okay, Let's move on");
            }

            //While loop to continue evaluating students
            while (moreStudents)
            {
                bool validStuNumber = true;
                bool validCatInput = true;
                //Prompt the user to ask about a particular student by number
                //While loop for inout validation
                while (validStuNumber)
                {
                    Console.WriteLine("Which Student would you like to learn about? (Enter a number 0-5): ");

                    //Convert the input to an integer and use it as the index for the arrays to print the student’s name.
                    studentNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(stuNames.Length);
                    if (studentNumber < 0 || studentNumber > stuNames.Length - 1)
                    {
                        Console.WriteLine("Invalid Input, Please enter a value between 0 and 5");
                        validStuNumber = true;
                    }
                    else
                    {
                        validStuNumber = false;
                    }
                }
                Console.WriteLine($"You Chose {studentNumber} that is {stuNames[studentNumber]}");

                //Ask the user which category to display: "Hometown" or "Favorite Food." Then display the relevant information.
                //While loop for input validation
                while (validCatInput)
                {
                    Console.WriteLine("Would you like to know their Hometown or Favorite Food? ");
                    string userChoice = Console.ReadLine().ToUpper();

                    if (userChoice != "HOMETOWN" && userChoice != "FAVORITE FOOD")
                    {
                        Console.WriteLine("Invalid Input, Please enter Hometown or Favorite Food");
                        validCatInput = true;
                    }
                    else if (userChoice == "FAVORITE FOOD")
                    {
                        Console.WriteLine($"{stuNames[studentNumber]}'s favorite food is {stuFavFoods[studentNumber]}");
                        validCatInput = false;
                    }
                    else
                    {
                        Console.WriteLine($"{stuNames[studentNumber]} is from {stuHomeTowns[studentNumber]}");
                        validCatInput = false;
                    }
                }
                
                    Console.WriteLine("Would you like to learn about another student? (Y/N)");
                    //To user input to capitalize the input
                    string userChoice2 = Console.ReadLine().ToUpper();
                    if (userChoice2 != "Y" && userChoice2 != "N")
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    else if (userChoice2 == "N")
                    {
                        moreStudents = false;
                    }
                    else
                    {
                        moreStudents = true;
                    
                }
            }

        }
    }
}
