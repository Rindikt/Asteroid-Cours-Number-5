using UnityEngine;

namespace Asteroid
{
    internal class Observer : IObserver
    {
        public void Update(float f)
        {
            Debug.Log(f);
        }
    }
}
