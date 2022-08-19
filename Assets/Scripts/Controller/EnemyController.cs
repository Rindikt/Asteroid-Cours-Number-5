using UnityEngine;
using System.Collections.Generic;

namespace Asteroid
{
    internal class EnemyController : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private float _speed;

        private SpawnEnemy _spawnEnemy;
        private AsteroidFactory _asteroidFactory;
        private EnemyShipFactory _enemyShipFactory;


        private void Start()
        {

            _enemyShipFactory = new EnemyShipFactory(_spawnPoint);
            _asteroidFactory = new AsteroidFactory(_spawnPoint);
            _spawnEnemy = new SpawnEnemy(_asteroidFactory, _enemyShipFactory);

        }
        private void Update()
        {
            _spawnEnemy.Execute();
        }
    }
}
