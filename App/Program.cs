using System;
namespace App
{
    class Program
    {
        abstract class AbsParent
        {
            public void Add(int x, int y) => Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
            public void Sub(int x, int y) => Console.WriteLine($"Addition of {x} and {y} is : {x - y}");
            public abstract void Mult(int x, int y);
            public abstract void Div(int x, int y);
        }
        class AbsChild : AbsParent
        {
            public override void Mult(int x, int y)=> Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
            public override void Div(int x, int y)=> Console.WriteLine($"Multiplication of {x} and {y} is : {x / y}");
        }
        static void Main(string[] args)
        {
            var AbsChild = new AbsChild();
            AbsChild.Add(30,10);
            AbsChild.Sub(30,10);
            AbsChild.Mult(30,10);
            AbsChild.Div(30,10);
            Console.ReadKey();
        }
    }
}