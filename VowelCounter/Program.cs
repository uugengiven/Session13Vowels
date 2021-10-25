﻿using System;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Count all of the vowels in a given sentence/string
            // ex: hello should return 2
            // for this example, a, e, i, o, and u are vowels
            // but y is not.

            Console.WriteLine(CountIt("hello")); // 2
            Console.WriteLine(CountIt("what is happening")); // 5

            Console.WriteLine("Hi there"!);
            Console.WriteLine("You've found the secret version!");
        }

        static int CountIt(string sentence)
        {
            int counter = 0;
            foreach(char letter in sentence)
            {
                if("aeiou".Contains(letter))
                {
                    counter = counter + 1;
                }
            }
            return counter;
        }
    }
}
