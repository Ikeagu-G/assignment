using System;

namespace AssignmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var Y = Console.ReadLine();

            int X=int.Parse(Y);

            int P = X / 100;

            int Q = P / 10;

            

            var S= Y[1] == 7 && Q == 7 ? "You are correct" : "You are wrong";

            Console.WriteLine(X);

            Console.WriteLine(P);

            Console.WriteLine(Q);

            Console.WriteLine(S);
            

        }
    }
}
