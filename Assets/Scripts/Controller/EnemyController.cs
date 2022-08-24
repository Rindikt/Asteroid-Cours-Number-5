using UnityEngine;
using System.Collections.Generic;

namespace Asteroid
{
    internal class EnemyController : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private float _speed;

        private SpawnEnemy _spawnEnemy;



        private void Start()
        {
            _spawnEnemy = new SpawnEnemy(_spawnPoint);

        }
        private void Update()
        {
            _spawnEnemy.Execute();
        }
    }
}
