# Student Database

## Objective:
Store and search data using arrays.

## Task:
Write a program that recognizes invalid inputs when the user requests information about students in a class.

## What the Application Will Do:
1. **2 Points:** Create 3 arrays and fill them with student information—one with names, one with hometowns, and one with favorite foods.
2. **1 Point:** Prompt the user to ask about a particular student by number. Convert the input to an integer and use it as the index for the arrays to print the student’s name.
3. **1 Point:** Ask the user which category to display: "Hometown" or "Favorite Food." Then display the relevant information.
4. **1 Point:** Ask the user if they would like to learn about another student.

## Build Specifications:
- **1 Point:** Validate the user number. Use an if statement to check if the number is out of range (less than 1 or greater than the length of the arrays). If so, display a friendly message and allow the user to try again.
- **1 Point:** Validate the category. Ensure the user entered either "Hometown" or "Favorite Food" correctly. If they entered an incorrect category, display a friendly message and re-ask the question.
- **1 Point:** Use the first array’s Length property in your code to handle the array size dynamically instead of hardcoding it.

## Hints:
- Make sure all arrays are the same size.
- Let the user enter a number from 1 up to and including the length of the array. To get the index, subtract 1 from the number they entered.
- For category validation, use a while loop to ask for valid input and only continue when "Hometown" or "Favorite Food" is entered correctly.
- Provide clear instructions to the user about what information is available.
- Ensure polite and grammatically correct messages throughout.

## Extra Challenges:
- **1 Point:** Provide an option for the user to see a list of all students.
- **2 Points:** Allow the user to search for a student by name.
- **1 Point:** Accept uppercase, lowercase, or portions of words such as "Food" instead of "Favorite Food."
