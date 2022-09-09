using UnityEngine;

namespace Asteroid
{
    internal class Example : MonoBehaviour
    {
        private Rival _enemy;
        private void Start()
        {
         _enemy = new Rival(new MagicalAttack(), new Walking());
            _enemy.Attack();
            _enemy.Move();
        }

        public void Change()
        {
            _enemy.SetAttack(new MeleeAttack());
            _enemy.SetMove(new Run());

            _enemy.Attack();
            _enemy.Move();
        }
    }
}
