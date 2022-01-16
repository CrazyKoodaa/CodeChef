using System;

namespace FLOW001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                string[] lines = Console.ReadLine().Split(' ');
                Console.WriteLine(int.Parse(lines[0]) + int.Parse(lines[1]));
            }
        }
    }
}
