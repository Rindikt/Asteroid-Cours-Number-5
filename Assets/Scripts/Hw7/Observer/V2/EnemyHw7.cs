using System;
using UnityEngine;

namespace Asteroid
{
    internal class EnemyHw7 : MonoBehaviour, IHit
    {
        public event Action<float> OnHitChange;

        public void Hit(float demage)
        {
            OnHitChange.Invoke(demage);
        }
    }
}
