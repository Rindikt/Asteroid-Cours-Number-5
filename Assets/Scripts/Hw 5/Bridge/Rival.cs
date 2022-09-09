

namespace Asteroid
{
    internal sealed class Rival
    {
        private IAttack _attack;
        private IMoveHw _move;

        public Rival(IAttack attack, IMoveHw move)
        {
            _attack = attack;
            _move = move;
        }
        public void SetAttack(IAttack attack)
        {
            _attack = attack;
        }
        public void SetMove(IMoveHw moveHw)
        {
            _move = moveHw;
        }

        public void Attack()
        {
            _attack.Attack();
        }
        public void Move()
        {
            _move.Move();
        }
    }
}
