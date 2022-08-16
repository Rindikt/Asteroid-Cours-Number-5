using UnityEngine;
using System;

namespace Asteroid
{
    internal class AsteroidFactory : EnemyFactory
    {
        public AsteroidFactory(Transform spawnPoint)
        {
            _spawnPoint = spawnPoint;
        }
        protected override GameObject CreateEnemy(EnemyType type,ref GameObject scelet)
        {
            if (!scelet.TryGetComponent(out EnemyAsteroid asteroid))
            {
                scelet.AddComponent<EnemyAsteroid>();
            }
            switch (type)
            {
                case EnemyType.AsteroidSmal:
                     var enemy = Resources.Load<GameObject>("Enemy/Asteroid/AsteroidSmall");  
                    return enemy;
                    
                case EnemyType.AsteroidMedium:
                     enemy = Resources.Load<GameObject>("Enemy/Asteroid/AsteroidMedium");
                    return enemy;
                    
                case EnemyType.AsteroidBig:
                     enemy = Resources.Load<GameObject>("Enemy/Asteroid/AsteroidBig");
                    return enemy;
                    
                default: throw new Exception();
                    
            }
        }
    }
}
