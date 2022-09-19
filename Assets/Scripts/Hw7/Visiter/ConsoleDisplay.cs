using UnityEngine;

namespace Asteroid
{
    internal sealed class ConsoleDisplay : IDealingDamage
    {
        public void Visit(EnemyHW7 hit, InfoCollision info)
        {
            Debug.Log($"{nameof(Enemy)} - {info.Damage}");
        }

        public void Visit(Enviroment hit, InfoCollision info)
        {
            Debug.Log($"{nameof(Enviroment)} - {info.Damage}");
        }

        public void Visit(Knight hit, InfoCollision info)
        {
            Debug.Log($"{nameof(Knight)} - {info.Damage}");
        }
    }
}
