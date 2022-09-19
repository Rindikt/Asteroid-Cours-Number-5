using UnityEngine;

namespace Asteroid
{
    internal class StateTest : MonoBehaviour
    {
        private void Start()
        {
            Context c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }
    }
}
