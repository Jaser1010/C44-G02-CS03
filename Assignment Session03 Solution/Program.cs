using System.Reflection.Metadata;



namespace Assignment_Session03

{

    internal class Program

    {

        static void Main(string[] args)

        {

            #region Q1 - Write a program that allows the user to enter a number then print it.

            Console.WriteLine("Enter a number:");
            string userInput = Console.ReadLine();
            Console.WriteLine("You entered: " + userInput);

            #endregion



            #region Q2 - Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen

            /*
            string textWithNonNumeric = "123a";
            try
            {
                int number = int.Parse(textWithNonNumeric);
                Console.WriteLine("Converted number: " + number);
            }
            catch (FormatException e)
            {
                Console.WriteLine("What will happen: A FormatException is thrown because the input string is not in the correct format.");
                Console.WriteLine("Error: " + e.Message);
            }
            */

            #endregion



            #region Q3 - Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            /*
            float num1 = 10.5f;
            float num2 = 2.5f;
            float result = num1 / num2;
            Console.WriteLine("Result of division: " + result);
            // What will happen: The division is performed correctly, and the result is 4.2. 
            // Floating-point types can handle fractional values without data loss in this case.
            */


            #endregion



            #region Q4 - Write C# program that Extract a substring from a given string.

            /*
            string originalString = "Hello, World!";
            string sub = originalString.Substring(7, 5);
            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Extracted Substring: " + sub);
            */



            #endregion



            #region Q5 - Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen

            /*
            int a = 10;
            int b = a;
            
            Console.WriteLine("Before modification:");
            Console.WriteLine($"a: {a}, b: {b}");

            b = 20;
            
            Console.WriteLine("\nAfter modifying 'b':");
            Console.WriteLine($"a: {a}, b: {b}");
            // What will happen: Modifying 'b' does not affect 'a'. 'int' is a value type, so a copy of the value is assigned.
            */



            #endregion



            #region Q6 - Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen

            /*
            MyClass obj1 = new MyClass();
            obj1.MyProperty = 10;

            MyClass obj2 = obj1; 

            Console.WriteLine("Before modification:");
            Console.WriteLine($"obj1.MyProperty: {obj1.MyProperty}, obj2.MyProperty: {obj2.MyProperty}");
            
            obj2.MyProperty = 20;

            Console.WriteLine("\nAfter modifying obj2.MyProperty:");
            Console.WriteLine($"obj1.MyProperty: {obj1.MyProperty}, obj2.MyProperty: {obj2.MyProperty}");
            // What will happen: Modifying the property via 'obj2' also changes it for 'obj1' because both variables
            // reference the same object in memory.
            */



            #endregion



            #region Q7 - Write C# program that take two string variables and print them as one variable 





            #endregion



            #region Q8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time

            // Note :  The formula for simple interest is Interest = (principal * rate * time ) /100.



            #endregion



            #region Q9 - Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 

            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)





            #endregion



            #region Q10 - Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result.

            ///that below 10 degrees is "Just Cold"

            ///above 30 degrees is "Just Hot"

            ///anything else is "Just Good"





            #endregion



            #region Q11  Write a program that takes the date from the user and displays it in various formats using string interpolation.

            ///Ex:

            ///Today’s date : 20 , 11 , 2001

            ///Today's date : 20 / 11 / 2001

            ///Today's date : 20 – 11 – 2001





            #endregion



            #region Q12 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            ///Example(1)

            ///Input: 12

            ///Output: Yes

            ///Example(2)

            ///Input: 9

            ///Output: No





            #endregion



            #region Q13 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            ///Example(1)

            ///Input: -5

            ///Output: negative

            ///Example(2)

            ///Input: 10

            ///Output: positive





            #endregion



            #region Q14 - Write a program that takes 3 integers from the user then prints the max element and the min element.

            ///Example(1)

            ///Input: 7,8,5

            ///Output:

            ///max element = 8

            ///min element = 5

            ///Example(2)

            ///Input: 3 6 9

            ///Outputs:

            ///Max element = 9

            ///Min element = 3









            #endregion



            #region Q15 - Write a program that allows the user to insert an integer number then check If a number is even or odd.





            #endregion



            #region Q16 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            ///Example(1)

            ///Input: O

            ///Output: vowel

            ///Example(2)

            ///Input: b

            ///Output: Consonant



            #endregion



            #region Q17 - Write a program to input the month number and print the number of days in that month.

            /// Example

            /// Input: Month Number: 1

            /// Output: Days in Month: 31





            #endregion



        }

    }

}