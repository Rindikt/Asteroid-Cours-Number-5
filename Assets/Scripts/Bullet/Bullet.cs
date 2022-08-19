using UnityEngine;
using System;

namespace Asteroid
{
    internal class Bullet : MonoBehaviour
    {
        public event Action Hit = delegate () { };
        public float demage;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (!collision.gameObject.GetComponent<Player>())
            {
               Hit.Invoke();
            }
        }
    }
}