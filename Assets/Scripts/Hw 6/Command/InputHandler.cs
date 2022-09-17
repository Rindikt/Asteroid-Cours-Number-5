using UnityEngine;
using System.Collections.Generic;


namespace Asteroid
{
    internal class InputHandler : MonoBehaviour
    {
        [SerializeField] private Transform _box;
        [SerializeField] private float _moveDistance;
        private ICommand _buttonW;
        private ICommand _buttonS;
        private ICommand _buttonA;
        private ICommand _buttonD;
        private ICommand _buttonB;
        private ICommand _buttonZ;
        private readonly List<ICommand> _oldCommands = new List<ICommand>();

        private void Start()
        {
            _buttonB = new DoNothing();
            _buttonW = new MoveForward(_moveDistance);
            _buttonS = new MoveReverse(_moveDistance);
            _buttonA = new MoveLeft(_moveDistance);
            _buttonD = new MoveRight(_moveDistance);
            _buttonZ = new UndoCommand(_oldCommands);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (_buttonA.Execute(_box))
                {
                    _oldCommands.Add(_buttonA);
                }
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (_buttonD.Execute(_box))
                {
                    _oldCommands.Add(_buttonD);
                }
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (_buttonW.Execute(_box))
                {
                    _oldCommands.Add(_buttonW);
                }
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (_buttonS.Execute(_box))
                {
                    _oldCommands.Add(_buttonS);
                }
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                if (_buttonB.Execute(_box))
                {
                    _oldCommands.Add(_buttonB);
                }
            }
            if (Input.GetKeyDown(KeyCode.Z))
            {
                _buttonZ.Execute(_box);
            }
        }
    }
}
