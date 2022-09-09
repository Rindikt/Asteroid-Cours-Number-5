
namespace AdapterAndFacade
{
    internal class AdapterDuck : ITurkey
    {
        IDuck duck;

        int distance = 5;
        public AdapterDuck(IDuck duck)
        {
            this.duck = duck;
        }

        public void Fly()
        {
            if (distance==0)
            {
                duck.Fly();
                distance = 5;
            }
            else
            {
                --distance;
            }
        }

        public void Gobble()
        {
            duck.Quack();
        }
    }
}
