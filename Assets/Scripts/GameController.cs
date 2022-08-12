using UnityEngine;

namespace Asteroid
{
    internal sealed class GameController : MonoBehaviour
    {
        private GameStarter _gameStarter;
        private Player _player;

        public GameController()
        {
            _gameStarter = new GameStarter();
            _player = _gameStarter.GetPlayer();
        }

    }
}
