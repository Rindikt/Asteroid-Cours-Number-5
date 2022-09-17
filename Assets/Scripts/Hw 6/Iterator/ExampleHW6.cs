using UnityEngine;
using System.Collections.Generic;
using System.Linq;


namespace Asteroid
{
    internal class ExampleHW6 : MonoBehaviour
    {
        private void Start()
        {
            var ability = new List<IAbilityHw6>
            {
                new AbilityHw6("Inner Fire",100,Target.None,DamageType.Magical),
                new AbilityHw6("Burning Spear",200,Target.Unit | Target.Autocast,DamageType.Magical),
                new AbilityHw6("Berserker's Blood",300,Target.Passive,DamageType.None),
                new AbilityHw6("Life Break", 400,Target.Unit,DamageType.Magical)
            };
            IEnemyHw6 enemy = new EnemyHW6(ability);

            Debug.Log(enemy[0]);
            Debug.Log(new string('+',50));
            Debug.Log(enemy[Target.Unit|Target.Autocast]);
            Debug.Log(new string('+', 50));
            Debug.Log(enemy[Target.Unit|Target.Passive]);
            Debug.Log(new string('+', 50));
            //Debug.Log(enemy.);
            Debug.Log(new string('+', 50));

            foreach (var o in enemy)
            {
                Debug.Log(o);
            }
            Debug.Log(new string('+', 50));

            foreach(var o in enemy.GetAbilityHw6s().Take(2))
            {
                Debug.Log(o);
            }
            Debug.Log(new string('+', 50));
            foreach (var o in enemy.GetAbilityHw6s(DamageType.Magical))
            {
                Debug.Log(o);
            }
        }
    }
}
