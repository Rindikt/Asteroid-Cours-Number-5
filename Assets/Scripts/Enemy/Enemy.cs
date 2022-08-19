using UnityEngine;

namespace Asteroid {
    public abstract class Enemy : MonoBehaviour
    {
        protected Rigidbody2D _body;
        public float _healPoint;
        public float demage;


        private void Update()
        {
            Move();
        }
        protected abstract void Move();
   
    }
}