
namespace Asteroid
{
    internal interface IDealingDamage
    {
        void Visit(EnemyHW7 hit, InfoCollision info);
        void Visit(Enviroment hit, InfoCollision info);
        void Visit(Knight hit, InfoCollision info);
    }
}
