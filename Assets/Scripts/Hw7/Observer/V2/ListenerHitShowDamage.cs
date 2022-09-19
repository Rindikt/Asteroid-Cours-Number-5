using UnityEngine;

namespace Asteroid
{
    internal class ListenerHitShowDamage
    {
        public void Add(IHit value)
        {
            value.OnHitChange += ValueOnHitChange;
        }
        
        public void Remove(IHit value)
        {
            value.OnHitChange -= ValueOnHitChange;
        }

        private void ValueOnHitChange(float demage)
        {
            Debug.Log(demage);
        }
    }
}
