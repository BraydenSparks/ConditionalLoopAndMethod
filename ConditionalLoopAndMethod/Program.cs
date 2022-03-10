using System;

namespace ConditionalLoopAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an initial number: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a target number: ");
            int target = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a range: ");
            int range = Int32.Parse(Console.ReadLine());

            string results = IsWithinRange(num, target, range) ? "It's within range." : "It's not within range.";

            // TODO: Write the result by calling IsWithinRange
            Console.WriteLine($"Given a starting number of: {num} and a target number: {target}. {results}");
        }

        private static bool IsWithinRange(int num, int target, int range)
        {
            return Math.Abs(num - target) <= range;
        }

    }
}
