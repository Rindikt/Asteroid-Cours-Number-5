using UnityEngine;
using System.Collections.Generic;

namespace Asteroid
{
    internal sealed class ViewServices
    {
        private static ViewServices viewServices;
        private ViewServices() { }

        private readonly Dictionary<int, ObjectPool> _viewCache = new Dictionary<int, ObjectPool>();
        
        public static ViewServices Instance()
        {
            if (viewServices == null)
            {
                viewServices = new ViewServices();
            }
            return viewServices;
        }
        public GameObject Create(GameObject prefab)
        {
            if (!_viewCache.TryGetValue(prefab.GetInstanceID(), out ObjectPool viewPool))
            {
                viewPool = new ObjectPool(prefab);
                _viewCache[prefab.GetInstanceID()] = viewPool;
            }
            
            return viewPool.Pop();
        }

        public void Destroy(GameObject go)
        {
            _viewCache[go.GetInstanceID()].Push(go);
        }
    }
}
