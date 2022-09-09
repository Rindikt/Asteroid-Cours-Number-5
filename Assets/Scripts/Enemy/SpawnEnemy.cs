using UnityEngine;
using System;
using Random = UnityEngine.Random;

namespace Asteroid
{
     internal class SpawnEnemy 
    {
        private Transform _spawnPoint;
        private float _offset = 4.3f;
        private ViewServices _viewServices;
        private float _spawnTime { get; set; }
        private Vector3 _spawnPosition;
        public SpawnEnemy(Transform spawnPoint)
        {
            _viewServices = ViewServices.Instance();
            _spawnTime = Random.Range(2, 5);
            _spawnPoint = spawnPoint;
        }

        public void Execute()
        {
            if (_spawnTime>0)
            {
                _spawnTime-=Time.deltaTime;
            }
            else
            {
                Spawn();
                _spawnTime = Random.Range(3, 10);

            }

            #region oldcode
            //if (_spawnTime>0)
            //{
            //    _spawnTime-=1*Time.deltaTime;
            //}
            //else
            //{ var ran = Random.Range(0, 4);
            //    switch (ran)
            //    {
            //        case 0:
            //            var unitOne = _viewServices.Get(ManegerEnemy.ASTEROID_SMALL, _asteroidFactory.Get(EnemyType.AsteroidSmal));
            //            var unOne = unitOne.GetComponent<EnemyAsteroid>();
            //            //unitOne.GetComponent<EnemyAsteroid>().demage = 4;
            //            //unitOne.GetComponent<EnemyAsteroid>()._healPoint = 2;
            //            //unitOne.GetComponent<EnemyAsteroid>().Death += () => _viewServices.Destroy(unitOne);
            //            unOne.demage = 4;
            //            unOne._healPoint = 2;
            //            unOne.Death += () => _viewServices.Destroy(ManegerEnemy.ASTEROID_SMALL, unitOne);
            //            break;
            //        case 1:
            //            var unitSecond = _viewServices.Get(ManegerEnemy.ASTEROID_MEDIUML, _asteroidFactory.Get(EnemyType.AsteroidMedium));
            //            var unSecond = unitSecond.GetComponent<EnemyAsteroid>();
            //            unSecond.demage = 6;
            //            unSecond._healPoint = 4;
            //            unSecond.Death += () => _viewServices.Destroy(ManegerEnemy.ASTEROID_MEDIUML,unitSecond);
            //            break;
            //        case 2:
            //            //var unitThird = _enemyShipFactory.Get(EnemyType.ShipFighter);
            //            //var unThird = unitThird.GetComponent<EnemyShip>();
            //            //unThird.demage = 6;
            //            //unThird._healPoint = 4;
            //            //unThird.Death += () => _viewServices.Destroy(unitThird);
            //            break;
            //        default:
            //            var unitFourth = _viewServices.Get(ManegerEnemy.ASTEROID_BIG, _asteroidFactory.Get(EnemyType.AsteroidBig));
            //            var unFourth = unitFourth.GetComponent<EnemyAsteroid>();
            //            unFourth.demage = 8;
            //            unFourth._healPoint = 6;
            //            unFourth.Death += () => _viewServices.Destroy(ManegerEnemy.ASTEROID_BIG,unitFourth);
            //            break;
            //    }
            //    _spawnTime = Random.Range(5, 7);
            //}
            #endregion
        }
        public void Spawn()
        {
            _spawnPosition = GetSpawnPoint();
            int rand = Random.Range(0, 4);
            //var enemy = _viewServices.Get(ManegerEnemy.LIGHT_FIGHTER,StaticEnemyFactory.GetEnemy(EnemyType.ShipFighter, _spawnPosition));
            //if (enemy.TryGetComponent<EnemyShip>(out EnemyShip ship))
            //{
            //    ship.Death += () => _viewServices.Destroy(ManegerEnemy.LIGHT_FIGHTER,enemy);
            //}

            switch (rand)
            {
                case 0:
                    StaticEnemyFactory.GetEnemy(EnemyType.AsteroidSmal, _spawnPosition);
                    break;
                case 1:
                    StaticEnemyFactory.GetEnemy(EnemyType.AsteroidMedium, _spawnPosition);
                    break;
                case 2:
                    StaticEnemyFactory.GetEnemy(EnemyType.AsteroidBig, _spawnPosition);
                    break;
                case 3:
                    StaticEnemyFactory.GetEnemy(EnemyType.ShipFighter, _spawnPosition);
                    break;
                default:
                    throw new Exception();
            }
        }

        private Vector3 GetSpawnPoint()
        {
             var spawnOffset = new Vector3(_spawnPoint.position.x, Random.Range(_spawnPoint.position.y - _offset, _spawnPoint.position.y + _offset), _spawnPoint.position.z);
            return spawnOffset;
        }

    }
}
