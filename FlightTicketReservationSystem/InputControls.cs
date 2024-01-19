using System;
using System.Text.RegularExpressions;
namespace FlightTicketReservationSystem
{
    internal class InputControls
    {
        public static bool lettersControl(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c)) { return false; }
            } return true;
        }
        public static string stringControl(string input, string message)
        {
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                if (lettersControl(input))
                {
                    Console.WriteLine();
                    break;
                } else { Console.WriteLine("Invalid Input. Please enter only letters.\n"); }
            } return input;
        }
        public static int intControl(int input, string message, int part)
        {
            while (true)
            {
                try
                {
                    Console.Write(message);
                    input = Convert.ToInt32(Console.ReadLine());
                    if (part == 0)
                    {
                        if (input >= 1 && input <= Program.listCounter)
                        {
                            ++input;
                            Console.WriteLine();
                            break;
                        } else { Console.WriteLine("Incorrect Value. Please enter a valid flight number!\n"); }
                    }
                    if (part == 1)
                    {
                        if (input > 0 && input < 101)
                        {
                            Console.WriteLine();
                            break;
                        } else { Console.WriteLine("Invalid Age. Please enter a positive integer!\n"); }
                    }
                } catch (FormatException) { Console.WriteLine("Incorrect Input. Please enter a number!\n"); }
            } return input;
        }
        public static string genderControl(string input, string message)
        {
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine().ToUpper();
                input.ToLower();
                if (input == "F" || input == "M" || input == "O") { Console.WriteLine(); break; }
                else { Console.WriteLine("Invalid Input. Please enter only {f, m, o}.\n"); }
            } return input;
        }
        public static string phoneNumberControl(string input, string message)
        {
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();
                string pattern = @"^\d{11}$";
                if (Regex.IsMatch(input, pattern)) { Console.WriteLine(); break; }
                else { Console.WriteLine("Invalid Input. The Phone Number has 11 digits and consists of numbers!\n"); }
            } return input;
        }
    }
}