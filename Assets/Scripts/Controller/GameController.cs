using System;
using UnityEngine;

namespace Asteroid
{
    internal class GameController : MonoBehaviour
    {
        [SerializeField] private Transform _startPos;
        [SerializeField] private Transform _enemySpawnPos;
        private GameStarter gameStarter;
        private GameUpdate gameUpdate;
        private EnemyController enemyController;

        private void Awake()
        {
            enemyController = new EnemyController(_enemySpawnPos);
            gameStarter = new GameStarter(_startPos);
            gameUpdate = new GameUpdate();
            gameStarter.AddListStart(enemyController);
            gameUpdate.AddListExecute(enemyController);
            gameStarter.Start();

        }
        private void Start()
        {
        }
        private void Update()
        {
            gameUpdate.Execute();
            
        }

    }
}
