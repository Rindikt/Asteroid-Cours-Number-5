
namespace Asteroid
{
    internal sealed class AddAttackModifier : EnemyModifierHw6
    {
        private readonly int _attack;
        public AddAttackModifier(EnemyHw6 enemy, int attack) : base(enemy)
        {
            _attack = attack;
        }

        public override void Handle()
        {
            _enemy.Attack += _attack;
            base.Handle();
        }
    }
}
