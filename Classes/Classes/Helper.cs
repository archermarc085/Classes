using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classes
{
    public static class Helper
    {
        public static double CheckDoubleDigits(this string str)
        {
            bool input = false;
            double value = 0;
            Console.Write("Enter number: ");
            do
            {
                try
                {
                    str = Console.ReadLine();
                    input = Regex.IsMatch(str, @"^[-+]?\d+\.?\d*$");
                    if (!input)
                    {
                        Console.WriteLine("Wrong number!");
                        Console.Write("Enter number again: ");
                    }
                }
                catch (OutOfMemoryException ex)
                {
                    Console.WriteLine("Method: {0}", ex.TargetSite);
                    Console.WriteLine("Message: {0}", ex.Message);
                    Console.WriteLine("Stack: {0}", ex.StackTrace);
                    Console.WriteLine("Source: {0}", ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Method: {0}", ex.TargetSite);
                    Console.WriteLine("Message: {0}", ex.Message);
                    Console.WriteLine("Stack: {0}", ex.StackTrace);
                    Console.WriteLine("Source: {0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Method: {0}", ex.TargetSite);
                    Console.WriteLine("Message: {0}", ex.Message);
                    Console.WriteLine("Stack: {0}", ex.StackTrace);
                    Console.WriteLine("Source: {0}", ex.Message);
                }
            }
            while (!double.TryParse(str, out value));
            return value;
        }
        public static int CheckIntDigits(this string str)
        {
            bool input = false;
            int value = 0;
            Console.Write("Enter number: ");
            do
            {
                try
                {
                    str = Console.ReadLine();
                    input = Regex.IsMatch(str, @"^[-+]?\d+\.?\d*$");
                    if (!input)
                    {
                        Console.WriteLine("Wrong number!");
                        Console.Write("Enter number again: ");
                    }
                }
                catch (OutOfMemoryException ex)
                {
                    Console.WriteLine("Method: {0}", ex.TargetSite);
                    Console.WriteLine("Message: {0}", ex.Message);
                    Console.WriteLine("Stack: {0}", ex.StackTrace);
                    Console.WriteLine("Source: {0}", ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Method: {0}", ex.TargetSite);
                    Console.WriteLine("Message: {0}", ex.Message);
                    Console.WriteLine("Stack: {0}", ex.StackTrace);
                    Console.WriteLine("Source: {0}", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Method: {0}", ex.TargetSite);
                    Console.WriteLine("Message: {0}", ex.Message);
                    Console.WriteLine("Stack: {0}", ex.StackTrace);
                    Console.WriteLine("Source: {0}", ex.Message);
                }
            }
            while (!int.TryParse(str, out value));
            return value;
        }
    }
}
