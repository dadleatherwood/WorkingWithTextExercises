using System;
namespace WorkingWithTextExercises
{
    public class Exercise4
    {
        public static void PascalCase()
        {
            Console.WriteLine("Enter a few words seperated by spaces: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error");
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' ')) 
            {
                //upcase the first letter of each word, and downcase the rest of the word
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                //add the new pascalCase word to the variable name
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }
    }
}
