using System;
namespace Strategy;

public class MuteQuack: IQuackBehavior
{
    public void DoQuack()
    {
        Console.WriteLine("MuteQuack");
    }
}