
namespace AdapterAndFacade
{
    internal class AdapterTurkey : IDuck
    {
        ITurkey turkey;
        public AdapterTurkey(ITurkey turkey)
        {
            this.turkey = turkey;
        }
        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
