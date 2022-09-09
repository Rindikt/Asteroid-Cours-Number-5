using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroid
{
    public class ServisLocator : IServisLocator
    {
        public static Dictionary<Type, ObjectPool> Locaons = new Dictionary<Type, ObjectPool>();

        public static void SetService<T>(T value) where T : class
        {
            var type = typeof(T);

        }

        public ObjectPool Registr(ObjectPool newPool)
        {
            throw new NotImplementedException();
        }

        public void UnRegistr(ObjectPool Pool)
        {
            throw new NotImplementedException();
        }
    }
}