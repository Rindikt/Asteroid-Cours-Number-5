using System;
using UnityEngine;


namespace Asteroid
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            
            ////Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));
            //IEnemyFactory factory = new AsteroidFactory();
            //factory.Create(new Health(100.0f, 100.0f));
            //EnemyPool enemyPool = new EnemyPool(5);
            //var enemy = enemyPool.GetEnemy("Asteroid");
            //enemy.transform.position = Vector3.one;
            //enemy.gameObject.SetActive(true);
            ////Enemy.Factory.Create(new Health(100.0f, 100.0f))

        }

        public Player GetPlayer()
        {
            return new Player();
        }

    }
}
