using UnityEngine;

namespace Asteroid
{
    internal sealed class ExampleHw6 : MonoBehaviour
    {
        private void Start()
        {
            var asteroid = new EnemyHw6("Asteroid", 1, 1);

            var root = new EnemyModifierHw6(asteroid);

            root.Add(new AddAttackModifier(asteroid, 5));
            root.Add(new AddAttackModifier(asteroid, 10));
            root.Add(new AddDefenseModifier(asteroid, 10));
            root.Handle();
        }
    }
}
