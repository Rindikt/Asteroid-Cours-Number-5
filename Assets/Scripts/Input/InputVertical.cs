using System;
using UnityEngine;

namespace Asteroid
{
    public class InputVertical : IUserImputProxy
    {
        public event Action<float> AxisOnChange = delegate (float f) { };

        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis(AxisManager.VERTICAL));
        }
    }
}
