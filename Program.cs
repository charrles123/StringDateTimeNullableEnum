﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDateTimeNullableEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sampleString;
            string sampleStringWithNullValue = null;
            String stringUsingClass = "Test";

            var myName = "Charles";
            var reverseName = "";

            myName += " Inay";

            // Reverse the string using for loop
            for (int i = myName.Length -1; i >= 0 ; i--)
            {
                reverseName += myName[i];
            }
            Console.WriteLine($"Reversed Name: {reverseName}");

            // Reversing the string using linq

            var reversedUsingLinq = new string(myName.Reverse().ToArray());
            Console.WriteLine($"Reversed using LINQ: {reversedUsingLinq}");

            Console.WriteLine("Print by using loop");
            foreach(var character in myName)
            {
                Console.Write(character);
            }

            char[] nameCharacters = myName.ToCharArray(); // Convert string to char array
            var stringFromArray = new string(nameCharacters); // Convert char array back to string


            // Verbatim string literal
            var stringWithSpecialCharacters = @"""Test\only""";
            var stringMultiLine = @"
                C
                H
                A
                R
                L
                E
                S";

            Console.WriteLine($"\n{stringWithSpecialCharacters}");
            Console.WriteLine(stringMultiLine);

            // String escape sequences
            var stringWithTabAndNewLine = "my\tname\tis:\nCharles";
            Console.WriteLine(stringWithTabAndNewLine);

            // Immutable nature of strings
            // Modifying a string will create a new string in memory
            var testString = "Hello";
            for(var number = 1; number <=5; number++)
            {
                testString += number;
            }
            Console.WriteLine(testString);

            // Solving immutable nature using StringBuilder
            var stringBuilder = new StringBuilder(); // Create only one instance in memory
            stringBuilder.Append("Hello");

            for(var number = 1; number <= 5; number++)
            {
                stringBuilder.Append(number.ToString());
            }
            Console.WriteLine("Using StringBuilder:");
            Console.WriteLine(stringBuilder.ToString());

            /*
             Numeric Standard Formatting
            C = Currency
            N = Number
            P = Percent

            D = Decimal
             */

            var myNumeric = 12345.6789D;
            Console.WriteLine(myNumeric.ToString("C")); // Convert to currency format
            Console.WriteLine(myNumeric.ToString("N")); // Convert to number format with commas
            Console.WriteLine(myNumeric.ToString("P")); // Convert to percent format

            var myNumericInt = 12345;
            Console.WriteLine(myNumericInt.ToString("D10")); // Convert to decimal with leading zeros ex. 0000012345(10 digits)

            Console.WriteLine("Number with 2 decimal places only"); 
            Console.WriteLine(myNumericInt.ToString("N2")); // Convert to number format with commas and 2 decimal places

            // Creating custom numeric format
            Console.WriteLine("Custom Numeric Format:");
            Console.WriteLine(myNumeric.ToString("PHP #, ##0.00")); // Custom format
        }
    }
}
