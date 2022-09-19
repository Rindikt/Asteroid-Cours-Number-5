
namespace Asteroid
{
    internal class Knight : HitHw7
    {
        public float Armor;
        public override void Activate(IDealingDamage value, float demage)
        {
            value.Visit(this, new InfoCollision(demage));
        }
    }
}
