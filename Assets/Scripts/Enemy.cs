using UnityEngine;

namespace Asteroid
{
    internal abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        public float _demage { get; }
        public Health Health { get; set; }

        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }
    }
}
