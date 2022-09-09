using UnityEngine;



namespace Asteroid
{
    internal sealed class WeaponProxy : IFire
    {
        private readonly IFire _weapon;
        private readonly UnlocWeapon _unlockWeapon;

        public WeaponProxy(IFire weapon, UnlocWeapon unlockWeapon)
        {
            _weapon = weapon;
            _unlockWeapon = unlockWeapon;
        }

        public void Fire()
        {
            if (_unlockWeapon.IsUnlock)
            {
                _weapon.Fire();
            }
            else
            {
                Debug.Log("Weapon is lock");
            }
        }
    }
}
