using System;

namespace Strategy;

public class Quack: IQuackBehavior
{
    public void DoQuack()
    {
        Console.WriteLine("Quack");
    }
}