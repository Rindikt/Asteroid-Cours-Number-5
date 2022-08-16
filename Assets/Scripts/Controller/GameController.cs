using UnityEngine;

namespace Asteroid
{
    internal sealed class GameController : MonoBehaviour
    {
        [SerializeField] private Transform _startPosition;
        private Player _player;
        private string DefaultView = "ViewPlayerShip/ViewShipDefault";

        private void Awake()
        {
            //StaticEnemyFactory.CreateEnemy(_spawnPoint);
            _player = PlayerFactory.GetPlayer(_startPosition, DefaultView);
            
        }
        private void Start()
        {

        }

       

    }
}
