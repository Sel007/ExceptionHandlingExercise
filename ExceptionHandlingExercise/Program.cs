using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            // DONE -----------------------------------------------------------------------------
            // First create a char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = { '4', '7', '1', '9', '6', '8', 's', 'r', 'q' };

            // Create a list called numbers that will hold integers
            List<int> numbers = new List<int>();

            // Create a "string variable" with an "empty string initializer" - "name it str"
            string str = "";

            // DONE ------------------------------------------------------------------------------

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 

            // DONE ------------------------------------------------------------------------------

            //DONE START HERE:

            //DONE
            // Make a foreach loop to iterate through your character array
            foreach (var character in arr)
            {
                //DONE - Now create a try catch
                try
                {
                //DONE
                // Inside your try block
                // set your string variable to each array element in your char[] to .ToString()
                // Now, using int.Parse, "parse your string variable" and store in an "int variable"
                // Then add each int to your list
                    str = character.ToString();
                    int num = int.Parse(str);
                    numbers.Add(num);
                }
                catch (Exception ex)
                {
                //DONE               
                // catch your Exception:
                // in the scope of your catch you can use the following, 
                //Console.WriteLine($"Unable to Parse '{character}'"); 
                //character will be the name of each item in your collection
                    Console.WriteLine($"Unable to Parse '{character}'");
                    Console.WriteLine(ex.Message);
                }

            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
