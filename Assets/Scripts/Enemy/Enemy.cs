using UnityEngine;

namespace Asteroid {
    public abstract class Enemy : MonoBehaviour
    {
        protected Rigidbody2D _body;
        protected float _healPoint;
        public float demage;
        
        protected abstract void Move(); 
    }
}