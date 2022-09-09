
namespace Asteroid
{
    internal abstract class ModificationWeapon : IFire
    {
        private Weapon _weapon;
        private Weapon _standartWeapon;

        protected abstract Weapon AddModification(Weapon weapon);

        public void ApplayModification(Weapon weapon)
        {
            _standartWeapon = weapon;
            _weapon = AddModification(weapon);
        }
        public Weapon RemoveModification(Weapon weapon)
        {
            weapon = _standartWeapon;
            return weapon;
        }
        public void Fire()
        {
            _weapon.Fire();
        }

        
    }
}
