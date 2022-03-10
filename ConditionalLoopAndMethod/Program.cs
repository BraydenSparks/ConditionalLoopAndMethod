using System;

namespace ConditionalLoopAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter an initial number: ");
            //int num = Int32.Parse(Console.ReadLine());

            //Console.Write("Enter a target number: ");
            //int target = Int32.Parse(Console.ReadLine());

            //Console.Write("Enter a range: ");
            //int range = Int32.Parse(Console.ReadLine());

            //string results = IsWithinRange(num, target, range) ? "It's within range." : "It's not within range.";
            //Console.WriteLine($"Given a starting number of: {num} and a target number: {target}. {results}");


            Console.Write("Do we have power? (y/n): ");
            bool hasPower = Console.ReadLine().ToLower() == "y";

            Console.Write("Do we have paper? (y/n): ");
            bool hasPaper = Console.ReadLine().ToLower() == "y";

            Console.Write("What is the current ink level: ");
            int inkLevel = Int32.Parse(Console.ReadLine());

            PrintDoc(hasPower, hasPaper, inkLevel);
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

    }
}
