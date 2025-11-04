using System;
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
            for (int i = myName.Length - 1; i >= 0; i--)
            {
                reverseName += myName[i];
            }
            Console.WriteLine($"Reversed Name: {reverseName}");

            // Reversing the string using linq

            var reversedUsingLinq = new string(myName.Reverse().ToArray());
            Console.WriteLine($"Reversed using LINQ: {reversedUsingLinq}");

            Console.WriteLine("Print by using loop");
            foreach (var character in myName)
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
            for (var number = 1; number <= 5; number++)
            {
                testString += number;
            }
            Console.WriteLine(testString);

            // Solving immutable nature using StringBuilder
            var stringBuilder = new StringBuilder(); // Create only one instance in memory
            stringBuilder.Append("Hello");

            for (var number = 1; number <= 5; number++)
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
            var myPhoneNumber = 09095185275;
            Console.WriteLine($"Custom Phone Number Format: {myPhoneNumber.ToString("0###-###-####")}");
            Console.WriteLine("Custom Numeric Format:");
            Console.WriteLine(myNumeric.ToString("PHP #, ##0.00")); // Custom format

            // String format and interpolation
            var name = "Charles";
            var age = 24;
            var sampleMoney = 12345.15D;

            // Using String.Format
            Console.WriteLine("Using String.Format:");
            var stringOutput = string.Format("My name is {0}, I am {1} years old, sample computation: {2}", name, age, 2025 - age);
            Console.WriteLine(stringOutput);
            Console.WriteLine(string.Format("{0:C}", sampleMoney));
            Console.WriteLine(string.Format("{0:PHP #,##0.00}", sampleMoney));

            // Interpolated strings
            Console.WriteLine("Using Interpolated Strings:");
            Console.WriteLine($"My name is {name}, I am {age} years old, sample computation: {2025 - age}");
            Console.WriteLine($"{sampleMoney:C}");
            Console.WriteLine($"{sampleMoney:PHP #,##0.00}");

            // Checker
            string firstString = null;
            var secondString = string.Empty; // Equivalent to "";
            var thirdString = "   "; // String with only spaces
            if (firstString == null)
                Console.WriteLine("firstString is null");

            // Versiong 1
            if (secondString != null && secondString != string.Empty)
                Console.WriteLine("Second string is not a Null");
            else
                Console.WriteLine("Second string is either Null or Empty");

            // Version 2
            if (!string.IsNullOrEmpty(secondString))
                Console.WriteLine("Second string is not a Null");
            else
                Console.WriteLine("Second string is either Null or Empty");

            // Check if null or whitespace
            if (!string.IsNullOrWhiteSpace(thirdString))
                Console.WriteLine("Third string is not a Null");
            else
                Console.WriteLine("Third string is either Null or WhiteSpace");

            // Common Checker functions
            var myNameForChecker = "Charles";
            if (myNameForChecker.StartsWith("Ch"))
                Console.WriteLine($"{myNameForChecker} starts with Ch");
            if (myNameForChecker.EndsWith("s"))
                Console.WriteLine($"{myNameForChecker} ends with s");
            if (myNameForChecker.Contains("ar"))
                Console.WriteLine($"{myNameForChecker} contains ar");

            if (myNameForChecker.IndexOf("rl") >= 0)
                Console.WriteLine($"{myNameForChecker} has rl at index {myNameForChecker.IndexOf("rl")}");

            if (myNameForChecker == "Charles")
                Console.WriteLine($"{myNameForChecker} is equal to Charles");
            else
                Console.WriteLine($"{myNameForChecker} is not equal to Charles");

            // Igone case
            if (myNameForChecker.Equals("charles", StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine($"{myNameForChecker} is equal to charles (Ignore Case)");
            else
                Console.WriteLine($"{myNameForChecker} is \"NOT\" equal to charles (Ignore Case)");

            // Commonly used to manipulate string
            var myString = "Charles pogi";
            Console.WriteLine(myString);
            Console.WriteLine($"Reversed: {new string(myString.Reverse().ToArray())}"); // Reverse using LINQ
            Console.WriteLine($"Replaced: {myString.Replace("pogi", "Inay")}"); // Replace pogi with Inay
            Console.WriteLine($"Substring: {myString.Substring(4, 3)}"); // Start at index 4, take 3 characters
            Console.WriteLine($"ToUpper: {myString.ToUpper()}"); // Convert to upper case)
            Console.WriteLine($"ToLower: {myString.ToLower()}"); // Convert to lower case)

            var anotherString = "   Char les   ";
            Console.WriteLine($"Trim start: '{anotherString.TrimStart(' ')}'"); // Trim starting spaces
            Console.WriteLine($"Trim end: '{anotherString.TrimEnd(' ')}'"); // Trim ending spaces
            Console.WriteLine($"Trim both sides: '{anotherString.Trim()}'"); // Trim spaces both sides
            Console.WriteLine($"Trim both sides and replace: '{anotherString.Trim().Replace(" ", string.Empty)}'");

            var lastString = "Charles-Inay-pogi:ako";
            Console.WriteLine(lastString);
            var words = lastString.Split('-'); // Split string into array using - as delimiter
            Console.WriteLine("===WORD===");
            foreach(var word in words)
            {
                Console.WriteLine($"{word}");
            }

            var wordWithMultipleDelimiters = lastString.Split(new char[] { '-', ':' }); // Split string into array using - and : as delimiters
            Console.WriteLine("===WORD WITH MULTIPLE DELIMITERS ('-', ':')===");
            foreach (var word in wordWithMultipleDelimiters)
            {
                Console.WriteLine($"{word}");
            }
            Console.WriteLine(string.Join("*", wordWithMultipleDelimiters)); // Join array into string using * as delimiter)
        }
    }
}
