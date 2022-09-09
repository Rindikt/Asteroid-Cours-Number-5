using UnityEngine;
using System.Collections.Generic;

namespace Asteroid
{
    internal sealed class ViewServices
    {
        private static ViewServices viewServices;
        private ViewServices() { }

        private readonly Dictionary<string, ObjectPool> _viewCache = new Dictionary<string, ObjectPool>();

        public static ViewServices Instance()
        {
            if (viewServices == null)
            {
                viewServices = new ViewServices();
            }
            return viewServices;
        }
        public GameObject Get(string name, GameObject prefab)
        {
            if (!_viewCache.TryGetValue(name, out ObjectPool viewPool))
            {
                viewPool = new ObjectPool(prefab);
                _viewCache[name] = viewPool;

            }
            Debug.Log(prefab.name);
            var enemy = viewPool.Pop();
            return enemy;
        }

        public void Destroy(string name, GameObject go)
        {
            Debug.Log("дестрой");
            _viewCache[name].Push(go);


        }
    }
}
