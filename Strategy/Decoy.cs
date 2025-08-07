using System;

namespace Strategy;

public class Decoy
{
    protected IQuackBehavior quackBehavior;

    public Decoy()
    {
        quackBehavior = new Quack();
    }

    public void PerformQuack()
    {
        quackBehavior.DoQuack();
    }
}