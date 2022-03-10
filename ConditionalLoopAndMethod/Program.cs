using System;

namespace ConditionalLoopAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.write("enter an initial number: ");
            //int num = int32.parse(console.readline());

            //console.write("enter a target number: ");
            //int target = int32.parse(console.readline());

            //console.write("enter a range: ");
            //int range = int32.parse(console.readline());

            //string results = iswithinrange(num, target, range) ? "it's within range." : "it's not within range.";
            //console.writeline($"given a starting number of: {num} and a target number: {target}. {results}");


            bool haspower = PromptUser("Do we have power? (y/n): ") == "y";
            bool haspaper = PromptUser("Do we have paper? (y/n): ") == "y";
            int inklevel = PromptUserInt("What is the current ink level: ");

            PrintDoc(haspower, haspaper, inklevel);
        }

        private static bool IsWithinRange(int num, int target, int range)
        {
            return Math.Abs(num - target) <= range;
        }

        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            string result = hasPaper & hasPower & inkLevel >= 10 ? "Printing" : "Unable to print";
            Console.WriteLine(result);
        }

        private static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        private static int PromptUserInt(string message)
        {
            //while input is invalid, ask them to comply
            int result;
            while(!int.TryParse(PromptUser(message), out result))
            {
                PromptUser("Invalid input! Press enter to retry.");
            }
            return result;
        }

    }
}
