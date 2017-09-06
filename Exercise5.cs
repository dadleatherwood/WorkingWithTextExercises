using System;
using System.Collections.Generic;

namespace WorkingWithTextExercises
{
    public class Exercise5
    {
        public static void HowManyVowels()
        {
            Console.WriteLine("Please enter an English word: ");
            var input = Console.ReadLine().ToLower();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid");
                return;
            }

            var vowelCount = 0;
            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine(vowelCount);
        }
    }
}
