using System.Collections.Generic;
using UnityEngine;

namespace Asteroid
{
    public sealed class ObjectPool
    {
        private readonly Stack<GameObject> _stack = new Stack<GameObject>();
        private GameObject _prefab;
        public ObjectPool(GameObject prefab)
        {
            _prefab = prefab;
        }

        public void Push(GameObject go)
        {
            Debug.Log(go.name);
            _stack.Push(go);
            go.SetActive(false);
        }

        public GameObject Pop()
        {
            GameObject go;
            if (_stack.Count == 0)
            {
                go = Object.Instantiate(_prefab);
            }
            else
            {
                go = _stack.Pop();
            }
            go.SetActive(true);
            return go;
        }
    }
}
