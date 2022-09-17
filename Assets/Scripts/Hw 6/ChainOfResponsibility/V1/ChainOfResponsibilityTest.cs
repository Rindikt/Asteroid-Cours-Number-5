using UnityEngine;
using System.Collections.Generic;


namespace Asteroid
{
    public sealed class ChainOfResponsibilityTest : MonoBehaviour 
    {
        [SerializeField] private List<GameHandler> _gameHandlers;

        private void Start()
        {
        }
        private void Update()
        {
            _gameHandlers[0].Handle();
            for (int i = 1; i < _gameHandlers.Count; i++)
            {
                _gameHandlers[i - 1].SetNext(_gameHandlers[i]);
            }
            
        }
    }
}
