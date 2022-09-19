

namespace Asteroid
{
    internal class ApplayDamage : IDealingDamage
    {
        public void Visit(EnemyHW7 hit, InfoCollision info)
        {
            hit.Health -= info.Damage;
            hit.TextMesh.text = hit.Health.ToString();
        }

        public void Visit(Enviroment hit, InfoCollision info)
        {
            
        }

        public void Visit(Knight hit, InfoCollision info)
        {
           var armor = hit.Armor;
            armor-=info.Damage;
            hit.Health -= armor;
            hit.TextMesh.text = armor.ToString();
        }
    }
}
