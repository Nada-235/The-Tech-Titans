using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        /*Q1:<<Write C# Sharp program to demonstrate that the Compare(String, String, Boolean) method is equivalent to 
         * using ToUpper or ToLower when comparing strings.>>

         * first we take the words from the user, then we change the uesers input to a upper case and store it in the 
         variable type of boolean , if it was equal then it is true otherwise false.
        then by using compare method we compare the words with ignoring the case by (True), if the value was 0 then it means it is equal.
        */

        //Console.Write("Enter first string: ");
        //string str1 = Console.ReadLine();

        //Console.Write("Enter second string: ");
        //string str2 = Console.ReadLine();

        //bool isEqualWhenCapitalized = str1.ToUpper() == str2.ToUpper();

        //bool isEqualIgnoreCase = String.Compare(str1, str2, true) == 0;

        //Console.WriteLine();
        //Console.WriteLine($"Comparing '{str1}' and '{str2}':");
        //Console.WriteLine($"The Strings are equal when capitalized? {isEqualWhenCapitalized}");
        //Console.WriteLine($"The Strings are equal when case is ignored? {isEqualIgnoreCase}");


        /*Q2:<< Write a C# Sharp program to demonstrate how culture affects comparisons.
        Note : In Czech – Czech Republic culture, "ch" is a single character that is greater than "d". However, 
        in English - United States culture, "ch" consists of two characters, and "c" is less than "d".>>

        as always we need to get the words from the user, then we call a prepared method named CultureInfo and store it in 
        enUS and csCZ again by using prepared method (compare) it takes word1 and word2 false means compare it when it's
        case-sensitive, after that we call our method which takes three parameter by using if else it will do the comparison.

         */


        Console.Write("Enter first word: ");
        string word1 = Console.ReadLine();

        Console.Write("Enter second word: ");
        string word2 = Console.ReadLine();

        CultureInfo enUS = new CultureInfo("en-US");
        int resultEn = String.Compare(word1, word2, false, enUS);

        CultureInfo csCZ = new CultureInfo("cs-CZ");
        int resultCs = String.Compare(word1, word2, false, csCZ);

        Console.WriteLine();
        Console.Write("For en-US: ");
        PrintComparison(word1, word2, resultEn);

        Console.Write("For cs-CZ: ");
        PrintComparison(word1, word2, resultCs);
    }

    static void PrintComparison(string a, string b, int result)
    {
        if (result < 0)
            Console.WriteLine($"{a} < {b}");
        else if (result > 0)
            Console.WriteLine($"{a} > {b}");
        else
            Console.WriteLine($"{a} = {b}");
    }
}




