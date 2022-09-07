using System;
using UnityEngine;

namespace Asteroid
{
    public class Builder
    {
        protected GameObject _gameObject;
        public BuilderView View => new BuilderView(_gameObject);

        public Builder()
        {
            _gameObject = new GameObject();
        }
        public Builder(GameObject gameObject)
        {
            _gameObject = gameObject;
        }
        public Builder Rigidbody2D(float mass)
        {
            var rb = GetOrAddComponent<Rigidbody2D>();
            rb.mass = mass;

            return this;

        }

        protected T GetOrAddComponent<T>() where T : Component
        {
            var result = _gameObject.GetComponent<T>();
            if (!result)
            {
                result = _gameObject.AddComponent<T>();
            }
            return result;
           
        }
    }
}
