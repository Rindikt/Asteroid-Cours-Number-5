

namespace Asteroid
{
    internal sealed class AddDefenseModifier : EnemyModifierHw6
    {
        private readonly int _maxDefense;

        public AddDefenseModifier(EnemyHw6 enemy, int maxDefense) : base(enemy)
        {
            _maxDefense = maxDefense;
        }

        public override void Handle()
        {
            if (_enemy.Defense<=_maxDefense)
            {
                _enemy.Defense++;
            }
            base.Handle();
        }
    }
}
