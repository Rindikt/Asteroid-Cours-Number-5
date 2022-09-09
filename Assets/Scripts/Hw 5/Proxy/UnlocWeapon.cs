using UnityEngine;


namespace Asteroid
{
    internal sealed class UnlocWeapon
    {
        public bool IsUnlock { get; set; }
        public UnlocWeapon(bool isUnlock)
        {
            IsUnlock = isUnlock;
        }
    }
}
