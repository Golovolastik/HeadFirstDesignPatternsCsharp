using System;
namespace Strategy;

public class Squeak: IQuackBehavior
{
    public void DoQuack()
    {
        Console.WriteLine("Squeak");
    }
}