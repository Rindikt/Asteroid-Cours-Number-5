using System;

namespace Asteroid
{
    internal interface IButtonDown
    {
        event Action<string> ButtonDown;

        void GetButton();
    }
}
