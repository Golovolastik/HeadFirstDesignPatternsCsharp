using Strategy;

namespace Strategy
{
    public class FlyWithWings: IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying");
        }
    }
}

