using UnityEngine;
using System.Collections.Generic;

namespace Asteroid
{
    internal class EnemyController : IStart, IExecute
    {
        private Transform _spawnPoint;
        private SpawnEnemy _spawnEnemy;
       
        public EnemyController(Transform spawnPoint)
        {
            _spawnPoint = spawnPoint;
    
        }

        public void Execute()
        {
            _spawnEnemy.Execute();
        }

        public void Start()
        {
            _spawnEnemy = new SpawnEnemy(_spawnPoint);
        }
    }
}
