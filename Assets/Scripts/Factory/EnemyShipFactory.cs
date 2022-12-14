using System;
using UnityEngine;

namespace Asteroid
{
    internal class EnemyShipFactory : EnemyFactory
    {
        public EnemyShipFactory(Transform spawnPoint)
        {
            _spawnPoint = spawnPoint;
        }
        protected override GameObject CreateEnemy(EnemyType type, ref GameObject scelet)
        {
            if (!scelet.TryGetComponent(out EnemyShip ship))
            {
                scelet.AddComponent<EnemyShip>();
                //ship._weapon = scelet.GetComponentInChildren<Transform>();
            }

            switch (type)
            {
                case EnemyType.ShipFighter:
                    var enemy = Resources.Load<GameObject>("Enemy/Ship/Fighter");
                    return enemy;  
                default:
                    throw new Exception();  
            }
        }
    }
}
