// See https://aka.ms/new-console-template for more information
//using System.ComponentModel;
//using System.Globalization;

//Console.WriteLine("Q01 Enter Two String to compare");
////1.Write C# Sharp program to demonstrate that the Compare(String, String, Boolean) method is equivalent to using ToUpper or ToLower when comparing strings.
////Expected Output :

//Console.Write("Enter First One: ");
//string word_01 = Console.ReadLine(); //enter first string
//Console.Write("Enter Second One: ");
//string word_02 = Console.ReadLine(); //enter second string

//if (word_01.ToUpper() == word_02.ToUpper())
//{
//    Console.WriteLine("Two strings are equal and Capitalize ");
//}
//else if (word_01== word_02)
//{
//    Console.WriteLine("Two strings are equal and not case is ignored ");
//}
//else
//{
//    Console.WriteLine("Two strings are not equal");
//}

////--------------------------------------------------------




using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CompareTwoStringUsingLinguistic_Casesensitive_Ordinal();
    }

    /// <summary>Compares the two sting by culture.</summary>
    static void CompareTwoStingByCulture()
    {

        Console.Write("Enter First One: ");
        string word_03 = Console.ReadLine(); //enter first string
        Console.Write("Enter Second One: ");
        string word_04 = Console.ReadLine(); //enter second string

        CultureInfo _Us = new CultureInfo("en-US"); //make variable for culture Us
        CultureInfo _CZ = new CultureInfo("cs-CZ"); //make variable for culture cz
        int _USresult = string.Compare(word_03, word_04, false, _Us);  //compare by ignore case and use US culture
        int _CZresult = string.Compare(word_03, word_04, false, _CZ);  //compare by ignore case and use _CZ culture\

        switch (_USresult)
        {
            case 0:
                Console.WriteLine($"Two words are Equal in Us culture {word_03} = {word_04}");
                break;
            case 1:
                Console.WriteLine($"First word are greater than second in Us culture {word_03} > {word_04}");
                break;

            default:
                Console.WriteLine($"First word are smaller than second in Us culture {word_03} < {word_04}");
                break;
        }


        switch (_CZresult)
        {
            case 0:
                Console.WriteLine($"Two words are Equal in CZ culture {word_03} = {word_04}");
                break;
            case 1:
                Console.WriteLine($"First word are greater than second in CZ culture {word_03} > {word_04}");
                break;

            default:
                Console.WriteLine($"First word are smaller than second in CZ culture {word_03} < {word_04}");
                break;
        }
    }

    static void CompareTwoStringUsingLinguistic_Casesensitive_Ordinal()
    {
        Console.Write("Enter First One: ");
        string word_03 = Console.ReadLine(); //enter first string
        Console.Write("Enter Second One: ");
        string word_04 = Console.ReadLine(); //enter second string

        CultureInfo _Us = new CultureInfo("en-US"); //make variable for culture Us

        Console.WriteLine("Notes 0 means Equal, 1 means 1st string greater, -1 means 2nd string is greater"); //notes when print
        int LinguisticResult = string.Compare(word_03, word_04, true, _Us); //case-insensitive
        Console.WriteLine($"LinguisticResult {getResult(LinguisticResult)}");
        int CasesensitiveResult = string.Compare(word_03, word_04,false,_Us); //case-sensitive
        Console.WriteLine($"CasesensitiveResult {getResult(CasesensitiveResult)}");
        int OrdinalResult = string.CompareOrdinal(word_03, word_04); //Ordinal
        Console.WriteLine($"OrdinalResult {getResult(OrdinalResult)}");


        static int getResult(int result)
        {
            switch (result)
            {
                case 0:
                    return 0;
                    break;
                case 1:
                    return 1;
                   break;
                default:
                    return -1;
                   break;
            }
        }

    }

}

