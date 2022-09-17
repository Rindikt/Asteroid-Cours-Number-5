using UnityEngine;

namespace Asteroid
    {
    public interface ICommand
    {
        bool Succeeded { get; }
        bool Execute(Transform box);
        void Undo(Transform box);
    }
}