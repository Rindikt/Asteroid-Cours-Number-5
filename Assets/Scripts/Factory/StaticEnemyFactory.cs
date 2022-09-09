using UnityEngine;
using System;
using Object = UnityEngine.Object;

namespace Asteroid
{
    internal static class StaticEnemyFactory
    {
        public static GameObject GetEnemy(EnemyType type, Vector3 transform)
        {
            GameObject enemy = null;
            switch (type)
            {
                case EnemyType.AsteroidSmal:
                    enemy = Resources.Load<GameObject>("Enemy/Asteroid/AsteroidSmallScelet");
                    enemy = Object.Instantiate(enemy, transform, Quaternion.identity);
                    return enemy;

                case EnemyType.AsteroidMedium:
                    enemy = Resources.Load<GameObject>("Enemy/Asteroid/AsteroidMediumScelet");
                    enemy = Object.Instantiate(enemy, transform, Quaternion.identity);
                    return enemy;

                case EnemyType.AsteroidBig:
                    enemy = Resources.Load<GameObject>("Enemy/Asteroid/AsteroidBigScelet");
                    enemy = Object.Instantiate(enemy, transform, Quaternion.identity);
                    return enemy;

                case EnemyType.ShipFighter:
                    enemy = Resources.Load<GameObject>("Enemy/Ship/LightFighter");
                    enemy = Object.Instantiate(enemy, transform, Quaternion.identity);
                    return enemy;

                default:
                    throw new Exception();

            }
        }

    }
}
