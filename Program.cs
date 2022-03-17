using System;
namespace TdAfrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Trapezium trapezium = new Trapezium(8,9.6,10);
            Trapezium trapezium1 = new Trapezium(3.4, 5.6, 7.6);
            Console.WriteLine(trapezium.Area());
            Console.WriteLine(trapezium1.Area());
            Console.ReadLine();
        }
    }
}
