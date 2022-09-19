
namespace Asteroid
{
    internal class Enviroment : HitHw7
    {
        public override void Activate(IDealingDamage value, float demage)
        {
           value.Visit(this, new InfoCollision(demage));
        }
    }
}
