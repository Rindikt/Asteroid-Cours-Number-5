using UnityEngine;
using System.Collections.Generic;


namespace Asteroid
{
    internal class GameStarter 
    {
        private Transform _startPos;
        private List<IStart> _start = new List<IStart>();
        public GameStarter(Transform startPos)
        {
            _startPos = startPos;
        }

        public void Start()
        {
            CreatPlayer();
            Begin();
        }
        private void CreatPlayer()
        {
           var player = PlayerFactory.GetPlayer(_startPos, PlayerView.VIEWSTANDART);
        }
        public void AddListStart(IStart start)
        {
            _start.Add(start);
        }
        public void Begin()
        {
            if (_start!=null)
            {
                foreach (var item in _start)
                {
                    item.Start();
                }
            }
        }

    }
}
