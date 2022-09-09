using UnityEngine;

namespace Asteroid
{
    public interface IWeaponHw
    { 
    
        IAmmuntion _bulet { get;}
        AudioClip _audioClip { get;}
        float VolumeFireOnMuffler { get;}

    }
}
