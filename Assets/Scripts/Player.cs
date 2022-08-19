using UnityEngine;

namespace Asteroid
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _healPoint;
        [SerializeField] private float _acceleration;
        [SerializeField] private GameObject _bulet;
        [SerializeField] private Rigidbody2D _shipRb;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        private Camera _camera;
        private Ship _ship;
        private InputController _inputController;
        private PlayerHealth _playerHealth;
        private IWeapon _weapon;


        private void Awake()
        {   
            _shipRb = GetComponent<Rigidbody2D>();
            _camera = Camera.main;
            _weapon = new DefaultWeapon(_barrel, _bulet);
            var moveTransform = new AccelerationMove(transform, _speed, _acceleration, _shipRb);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);
            _playerHealth = new PlayerHealth(_healPoint);
            _inputController = new InputController(_ship);
            _inputController.onCkickLeftMause += _weapon.Attack;
        }
  

        private void Update()
        {
            var diraction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(diraction);
            _inputController.Execute(); 
            
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.TryGetComponent(out Enemy enemy))
            {
                _playerHealth.GetDemage(1);
            }
            if (true)
            {
                _playerHealth.Healing(1);
            }
            
        }

    }
}

