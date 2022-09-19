using UnityEngine;

namespace Asteroid
{
    internal class ObserverTest : MonoBehaviour
    {
        public EnemyHw7 Enemy;
        public float Demage;
        private Camera _mainCamera;
        private float _dedicateDistance = 20.0f;


        private void Start()
        {
            _mainCamera = Camera.main;
            var listenerHitShowDemage = new ListenerHitShowDamage();
            listenerHitShowDemage.Add(Enemy);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition), out var hit, _dedicateDistance))
                {
                    if (hit.collider.TryGetComponent<IHit>(out var enemy))
                    {
                        enemy.Hit(Demage);
                    }
                }

            }
        }
    }
}
