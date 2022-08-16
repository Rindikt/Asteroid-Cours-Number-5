using UnityEngine;

namespace Asteroid
{
    internal static class PlayerFactory
    {

        public static Player GetPlayer(Transform startPoint,string view)
        {
            var player = Resources.Load<Player>("Ship/ShipLogic");
            var _player = Object.Instantiate(player, startPoint.position,startPoint.rotation);
            var _view = Resources.Load<GameObject>(view);
            var View = Object.Instantiate(_view, startPoint.position, Quaternion.identity);
            View.transform.SetParent(_player.gameObject.transform);
            return _player;
        }

    }
}
