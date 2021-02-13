using System;
using System.Text;

namespace OloOnlineCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WordWrap("No spicy", 3));
            Console.WriteLine(WordWrap("Happy birthday to everyone", 5));
            Console.WriteLine(WordWrap("Happy birthday to everyone Happy birthday to everyone Happy birthday to everyone", 25));
            Console.WriteLine(WordWrap("", 3));
            Console.WriteLine(WordWrap(null, 3));
            Console.WriteLine(WordWrap("1", 2));
            Console.WriteLine(WordWrap("1", -1));
        }

        static string WordWrap(string specialInstructions, int characterLimit)
        {
            if (!validateInput(specialInstructions, characterLimit))
            {
                return "Invalid special Instructions";
            }

            if (specialInstructions.Length <= characterLimit)
            {
                return specialInstructions;
            }

            StringBuilder result = new StringBuilder();
            int len = specialInstructions.Length;
            int currentIndex = 0;

            while (true)
            {
                if (currentIndex + characterLimit < len)
                {
                    result.AppendLine(specialInstructions.Substring(currentIndex, characterLimit));
                    currentIndex += characterLimit;
                }
                else
                {
                    result.AppendLine(specialInstructions.Substring(currentIndex, len-currentIndex));
                    break;
                }
            }

            return result.ToString();
        }

        static bool validateInput(string specialInstructions, int characterLimit)
        {
            if (string.IsNullOrEmpty(specialInstructions))
            {
                return false;
            }

            if (characterLimit < 1)
            {
                return false;
            }

            return true;
        }
    }
}
