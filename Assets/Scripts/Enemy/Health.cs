using System;
using UnityEngine;

namespace Asteroid
{
    internal class Health
    {
       
        public float _health;
        public Health(float health)
        {
            _health = health;
        }
        public float GetDamage(float demage)
        {
            _health -= demage;
            Debug.Log(_health);
            return _health;
        }

    }
}
