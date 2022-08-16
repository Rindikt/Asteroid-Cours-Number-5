using UnityEngine;
using System.Collections.Generic;

namespace Asteroid
{
    internal class SpawnEnemy : IExecute
    {
        private AsteroidFactory _asteroidFactory;
        private EnemyShipFactory _enemyShipFactory;
        private List<Enemy> _enemy;
        private float _spawnTime { get; set; }
        public SpawnEnemy(AsteroidFactory asteroidFactory, EnemyShipFactory enemyShipFactory, List<Enemy> enemy)
        {
            _enemyShipFactory = enemyShipFactory;
            _asteroidFactory = asteroidFactory;
            _spawnTime = Random.Range(2, 5);
            _enemy = enemy;
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
                        _enemy.Add(_asteroidFactory.Get(EnemyType.AsteroidSmal));
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
