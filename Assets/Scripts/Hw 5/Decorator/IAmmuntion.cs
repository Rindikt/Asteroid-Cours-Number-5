using UnityEngine;

namespace Asteroid
{
    public interface IAmmuntion
    {
        Rigidbody2D BulletInstance { get; }
        float TimeToDestroy { get; }
    }
}
