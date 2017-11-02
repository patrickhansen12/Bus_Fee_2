using System;

namespace Bus_Fee
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus_Fee bus = new Bus_Fee();
            double total = bus.TotalCost(5, 120);
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
