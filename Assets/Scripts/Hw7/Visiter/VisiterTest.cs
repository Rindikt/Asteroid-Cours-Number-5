using UnityEngine;

namespace Asteroid
{
    internal class VisiterTest : MonoBehaviour
    {
        public float Damage;
        private Camera _mainCamera;
        private float _dedicateDistance = 20.0f;

        private void Start()
        {
            _mainCamera = Camera.main;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(_mainCamera.ScreenPointToRay(Input.mousePosition),out var hit, _dedicateDistance))
                {
                    if (hit.collider.TryGetComponent<HitHw7>(out var damage))
                    {
                        damage.Activate(new ConsoleDisplay(), Damage);
                        damage.Activate(new ApplayDamage(), Damage);
                    }
                }
            }
        }
    }
}
