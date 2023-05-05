using System;

namespace GameUnits
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            SettlerUnit settler = new SettlerUnit(1, 2);
            settler.Move(3);
            Console.WriteLine($"Settler Health: {settler.Health}, Cost: {settler.Cost}");
        }
    }
}

