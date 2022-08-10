using System;
using UnityEngine;

namespace Asteroid
{
    internal sealed class PlayerHealth : IHealth
    {
        event Action noLifeLeft = delegate { };
        private float _health = 10;
        private float _maxHealPoint;

        public PlayerHealth(float maxHealPoint)
        {
            _maxHealPoint = maxHealPoint;  
        }

        public void GetDemage(float demage)
        {
            _health -= 1;
            Debug.Log(_health);
            if (_health<=0)
            {
                noLifeLeft.Invoke();
            }
        }

        public void Healing(float heal)
        {
            _health += 1;
            if (_health > _maxHealPoint)
            {
                _health = _maxHealPoint;
            }
        }
    
    }
}
