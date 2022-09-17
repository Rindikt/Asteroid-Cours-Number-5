

namespace Asteroid
{
    internal class AbilityHw6 : IAbilityHw6
    {
        public string Name { get; }

        public int Demage { get; }

        public Target Target { get; }

        public DamageType DamageType { get; }

        public AbilityHw6(string name, int demage, Target target, DamageType damageType)
        {
            Name = name;
            Demage = demage;
            Target = target;
            DamageType = damageType;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
