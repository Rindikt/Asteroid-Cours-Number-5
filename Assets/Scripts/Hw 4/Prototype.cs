using System;
using UnityEngine;

namespace Asteroid
{
    internal class Prototype : MonoBehaviour
    {
        [SerializeField] private GameObject Prefab;

        [ContextMenu("Clone")]
        public void Clone()
        {
            var newObject = new GameObject();
            var myClonobl = newObject.AddComponent<Prototype>();
            if (Prefab.TryGetComponent<SpriteRenderer>(out SpriteRenderer sprite))
            {
                var newSpriteRender = newObject.AddComponent<SpriteRenderer>();
                newSpriteRender.sprite = sprite.sprite;
            }
            if (Prefab.TryGetComponent<PolygonCollider2D>(out PolygonCollider2D polygonCollider))
            {
                var newpolygonCollider = newObject.AddComponent<PolygonCollider2D>();
                newpolygonCollider.autoTiling = polygonCollider.autoTiling;
                //var newpolygonColliderw = newObject.AddComponent<BoxCollider2D>();
                //newpolygonColliderw.
            }
            if (Prefab.TryGetComponent<EnemyShip>(out EnemyShip enemyShip))
            {
                var newEnemyShip = newObject.AddComponent<EnemyShip>();
            }
        }
    }
}
