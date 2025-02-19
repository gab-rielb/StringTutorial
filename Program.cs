using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = TakeUserInput("Enter a string to encrypt: ");
                string encrypted_string = EncryptString(input);
            }
            catch (Exception e)
            {
                  Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }

        static string TakeUserInput(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return input;
        }

        static string EncryptString(string inputString)
        {
            // Guard clause to check if input is a valid string
            if (string.IsNullOrWhiteSpace(inputString)) 
            { 
                throw new ArgumentNullException(nameof(inputString), "String must not be null or empty.");
            }


            // Reverse the string
            string finalEncryption = inputString;
            char[] reversed = finalEncryption.ToCharArray();
            Array.Reverse(reversed);
            finalEncryption = new string(reversed);

            Console.Write(finalEncryption);
            Console.ReadKey();


            // Convert every second charatcer to uppercase


            // Interpolateion and concatenation


            // String conversion using ASCII values to shift each character by 1



            return finalEncryption;
        }
    }
}
