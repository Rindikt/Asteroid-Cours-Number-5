

namespace Asteroid
{
    internal class EnemyModifierHw6
    {
        protected EnemyHw6 _enemy;
        protected EnemyModifierHw6 Next;

        public EnemyModifierHw6(EnemyHw6 enemy)
        {
            _enemy = enemy;
        }

        public void Add(EnemyModifierHw6 cm)
        {
            if (Next!=null)
            {
                Next.Add(cm);
            }
            else
            {
                Next = cm;
            }
        }

        public virtual void Handle() => Next?.Handle();
    }
}
