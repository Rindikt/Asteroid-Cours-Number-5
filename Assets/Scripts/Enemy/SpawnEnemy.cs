using UnityEngine;
using System.Collections.Generic;

namespace Asteroid
{
     internal class SpawnEnemy 
    {
        private AsteroidFactory _asteroidFactory;
        private EnemyShipFactory _enemyShipFactory;
        private ViewServices _viewServices;
        private float _spawnTime { get; set; }
        public SpawnEnemy(AsteroidFactory asteroidFactory, EnemyShipFactory enemyShipFactory)
        {
            _viewServices = ViewServices.Instance();
            _enemyShipFactory = enemyShipFactory;
            _asteroidFactory = asteroidFactory;
            _spawnTime = Random.Range(2, 5);
        }

        public void Execute()
        {
            
            if (_spawnTime>0)
            {
                _spawnTime-=1*Time.deltaTime;
            }
            else
            { var ran = Random.Range(0, 4);
                switch (ran)
                {
                    case 0:
                        var unit = _viewServices.Create( _asteroidFactory.Get(EnemyType.AsteroidSmal));
                        var un = unit.GetComponent<EnemyAsteroid>();
                        un.demage = 4;
                        un._healPoint = 5;
                        un.Death += () => _viewServices.Destroy(unit);
                        break;
                    case 1: _asteroidFactory.Get(EnemyType.AsteroidMedium);
                        break;
                    case 2: _enemyShipFactory.Get(EnemyType.ShipFighter);
                        break;
                    default:_asteroidFactory.Get(EnemyType.AsteroidBig);
                        break;
                }
                _spawnTime = Random.Range(5, 7);
            }
        }

    }
}
