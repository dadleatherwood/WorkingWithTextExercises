using System;
namespace WorkingWithTextExercises
{
    public class Exercise3
    {
        public static void CheckingTheTime()
        {
            Console.WriteLine("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length !=2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
