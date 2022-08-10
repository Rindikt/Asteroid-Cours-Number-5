using System;

namespace Asteroid
{
    internal interface IUserImputProxy
    {
        event Action<float> AxisOnChange;

        void GetAxis();    
    }
}
