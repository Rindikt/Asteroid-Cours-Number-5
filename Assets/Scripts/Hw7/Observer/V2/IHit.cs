using System;


namespace Asteroid
{
    internal interface IHit
    {
        event Action<float> OnHitChange;
        void Hit(float demage);
    }
}
