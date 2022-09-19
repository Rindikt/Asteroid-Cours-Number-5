using UnityEngine;

namespace Asteroid
{
    internal abstract class HitHw7 : MonoBehaviour
    {
        public float Health;
        public TextMesh TextMesh;
        public abstract void Activate(IDealingDamage value, float demage);
    }
}
