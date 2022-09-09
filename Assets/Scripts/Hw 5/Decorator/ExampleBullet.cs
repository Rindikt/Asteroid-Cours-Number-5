using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Asteroid
{
    internal class ExampleBullet : IAmmuntion
    {
        public Rigidbody2D BulletInstance { get; }
        public float TimeToDestroy { get;}

        public ExampleBullet(Rigidbody2D bulletInstance, float timeToDestroy)
        {
            BulletInstance = bulletInstance;
            TimeToDestroy = timeToDestroy;
        }
    }
}
