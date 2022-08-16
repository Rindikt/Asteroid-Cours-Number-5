using UnityEngine;

namespace Asteroid
{
    public class MoveTransform : IMove
    {
        private readonly float _speed;
        private Vector3 _move;
        private Rigidbody2D _rigidbody;
        public float Speed { get; protected set; }

        public MoveTransform(Transform transform, float speed, Rigidbody2D rigidbody)
        {
            //_transform = transform;
            Speed = speed;
            _rigidbody = rigidbody;
        }


        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var speed = deltaTime * Speed;
            Vector3 movement = new Vector3(horizontal, vertical, 0.0f);
            _rigidbody.AddForce(movement * (speed * _rigidbody.mass),ForceMode2D.Impulse);
        }
            //_move.Set(horizontal * speed, vertical * speed, 0.0f);
            //_transform.localPosition += _move;

    }
}