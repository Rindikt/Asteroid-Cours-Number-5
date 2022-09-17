using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Asteroid
{
    internal class EnemyHW6 : IEnemyHw6
    {
        private List<IAbilityHw6> _ability;
        public EnemyHW6(List<IAbilityHw6> ability)
        {
            _ability = ability;
        }


        public IAbilityHw6 this[int index] => _ability[index];

        public string this[Target index]
        {
            get
            {
                var ability = _ability.FirstOrDefault(a => a.Target == index);
                return ability == null ? "Not supported" : ability.ToString();
            }
        }
        public int MaxDemage => _ability.Select(a => a.Demage).Max();

        public IEnumerable<IAbilityHw6> GetAbilityHw6s()
        {
            while (true)
            {
                yield return _ability[Random.Range(0,_ability.Count)];
            }
        }


        public IEnumerable<IAbilityHw6> GetAbilityHw6s(DamageType index)
        {
            foreach (var ability in _ability)
            {
                if (ability.DamageType == index)
                {
                    yield return ability;
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _ability.Count; i++)
            {
                yield return _ability[i];
            }
        }
    }
}
