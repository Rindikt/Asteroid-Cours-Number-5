using UnityEngine;
using System.Collections.Generic;


namespace Asteroid
{
    internal class UndoCommand : ICommand
    {
        private readonly List<ICommand> _commands;
        public bool Succeeded { get; private set; }

        public UndoCommand(List<ICommand> commands)
        {
            _commands = commands;
        }

        public bool Execute(Transform box)
        {
            if (_commands.Count>0)
            {
                ICommand latesCommand = _commands[_commands.Count - 1];
                if (latesCommand.Succeeded)
                {
                    latesCommand.Undo(box);
                    _commands.RemoveAt(_commands.Count-1);
                    Succeeded = true;
                }
            }
            else
            {
            Succeeded = false;
            }

            return Succeeded;
        }

        public void Undo(Transform box)
        {
        }
    }
}
