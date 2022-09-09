

namespace AdapterAndFacade
{
    internal class DuckTestDrive
    {

        public static void Main()
        {
            MallardDuck duck = new MallardDuck();
            Turkey turkey = new Turkey();

            IDuck turkeyAdapter = new AdapterTurkey(turkey);

            //Console.WriteLine("The turkay says..");
            turkey.Gobble();
            turkey.Fly();

            //Console.WriteLine();

            //Console.WriteLine("The duck says..");
            duck.Quack();
            duck.Fly();

            //Console.WriteLine();

            //Console.WriteLine("The turkeyAdapter says..");
            turkeyAdapter.Quack();
            turkeyAdapter.Fly();
        } 
    }
}
