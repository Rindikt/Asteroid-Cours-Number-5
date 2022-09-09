using UnityEngine;


namespace Asteroid
{
    internal class ExampleProxy : MonoBehaviour
    {
        private void Start()
        {
            var unlockWeapon = new UnlocWeapon(false);
            var weapon = new WeaponHw5();
            var weaponProxy = new WeaponProxy(weapon,unlockWeapon);

            weaponProxy.Fire();
            unlockWeapon.IsUnlock = true;
            weaponProxy.Fire();
        }

    }
}
