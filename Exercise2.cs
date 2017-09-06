using System;
using System.Collections.Generic;
namespace WorkingWithTextExercises
{
    public class Exercise2
    {
        public static void Duplicates()
        {
            Console.WriteLine("Enter a few numbers seperated by a hyphen (ie: 3-5-7-9): ");
            var input = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var numbers = new List<int>();
            foreach(var number in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var uniqueValues = new List<int>();
            var includesDuplicates = false;

            foreach(var number in numbers)
            {
                if(!uniqueValues.Contains(number))
                {
                    uniqueValues.Add(number);
                }
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
            {
                Console.WriteLine("Duplicate");
            }
        }
    }
}
