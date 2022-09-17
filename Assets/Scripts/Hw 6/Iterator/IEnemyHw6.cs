using System.Collections;
using System.Collections.Generic;


namespace Asteroid
{
    internal interface IEnemyHw6
    {
        IAbilityHw6 this[int index] { get;}
        string this[Target index] { get; }

        IEnumerable<IAbilityHw6> GetAbilityHw6s();
        IEnumerator GetEnumerator();
        IEnumerable<IAbilityHw6> GetAbilityHw6s(DamageType index);
    }
}
