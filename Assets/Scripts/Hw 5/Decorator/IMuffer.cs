using UnityEngine;

namespace Asteroid
{ 
    public interface IMuffer
    {
        AudioClip AudioClipMuffer { get; }
        float VolumeFireOnMuffler { get; }
        Transform BarrelPositionMuffer { get; }
        GameObject MufflerInstance { get; }
    }
}
