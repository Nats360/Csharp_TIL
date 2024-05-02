using System;

namespace ConsoleApp
{
    class Program
    {
        public int x { get; set; }
        public int y { get; set; }

        public override string ToString() => $"({x}, {y})";
    }
    class CosoleApp
    {
        static void Main(string[] args)
        {
            var p = new Program { x = 1, y = 2 };
            Console.WriteLine(p);
        }
    }

}