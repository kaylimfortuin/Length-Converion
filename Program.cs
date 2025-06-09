using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Globalization;

namespace Length
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            bool loop = true;
            double result = 0;

            try
            {
                while (loop)
                {
                    System.Console.WriteLine("\n===Unit Converter===");
                    System.Console.WriteLine("1. Meters to Centimeters");
                    System.Console.WriteLine("2. Meters to Kilometers");
                    System.Console.WriteLine("3. Meters to Miles");
                    System.Console.WriteLine("4. Centimeters to Meters");
                    System.Console.WriteLine("5. Kilometers to Meters");
                    System.Console.WriteLine("6. Miles to Meters");
                    System.Console.WriteLine("7. Exit");
                    System.Console.Write("Please enter your choice: ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice < 1 || choice > 7)
                    {
                        System.Console.WriteLine("Please enter a menu option, press any key to continue...");
                        Console.ReadKey();
                        continue;
                    }

                    if (choice == 7)
                    {
                        System.Console.WriteLine("Goodbye");
                        break;
                    }

                    System.Console.Write("Enter a number to Convert: ");
                    double con = Convert.ToDouble(Console.ReadLine());
                    if (con < 0)
                    {
                        System.Console.WriteLine("Invalid, press any key to continue...");
                        Console.ReadKey();
                        continue;
                    }

                    if (choice == 1)
                    {
                        result = con * 100;
                        System.Console.WriteLine($"{result}cm");
                    }
                    else if (choice == 2)
                    {
                        result = con / 1000;
                        System.Console.WriteLine($"{result}km");
                    }
                    else if (choice == 3)
                    {
                        result = con / 1609.34;
                        System.Console.WriteLine($"{result}miles");
                    }
                    else if (choice == 4)
                    {
                        result = con / 100;
                        System.Console.WriteLine($"{result}m");
                    }
                    else if (choice == 5)
                    {
                        result = con * 1000;
                        System.Console.WriteLine($"{result}m");
                    }
                    else if (choice == 6)
                    {
                        result = con * 1609.34;
                        System.Console.WriteLine($"{result}m");
                    }
                }
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Please enter a valid number");
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}