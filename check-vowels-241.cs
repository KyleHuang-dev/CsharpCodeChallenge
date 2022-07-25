using System;

namespace check_vowel
{
    using System;
    /*
    Write a program that asks the user to enter a lowercase letter and determines whether or not the letter is a vowel. If the user enters a vowel, print “This is a vowel”, if the user enters a consonant, print “This is a consonant”. If the user enters the letter ‘y’, print “This is sometimes a vowel”. If the user enters anything other than a lowercase letter, print “Invalid input”.
    */

    class Program
    {
        static void Main(string[] args)
        {
            char validLetter;

            Console.WriteLine("Enter a letter:");
            validLetter = char.Parse(Console.ReadLine());

            if (validLetter < 'a' || validLetter > 'z')
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                switch (validLetter)
                {
                    case 'a':

                    case 'e':

                    case 'i':

                    case 'o':

                    case 'u':
                        Console.WriteLine("This is a vowel");
                        break;
                    case 'y':
                        Console.WriteLine("This is sometimes a vowel");
                        break;
                    default:
                        Console.WriteLine("This is a consonant");
                        break;
                }
            }

            Console.Read();
        }

    }




}

