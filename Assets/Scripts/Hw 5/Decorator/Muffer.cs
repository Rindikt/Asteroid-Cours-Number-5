using UnityEngine;
namespace Asteroid
{
    internal sealed class Muffer : IMuffer
    {
        public AudioClip AudioClipMuffer { get;}

        public float VolumeFireOnMuffler { get;}

        public Transform BarrelPositionMuffer { get;}

        public GameObject MufflerInstance { get;}

        public Muffer(AudioClip audioClipMuffer, float volumeFireOnMuffler, Transform barrelPositionMuffer, GameObject mufflerInstance)
        {
            AudioClipMuffer = audioClipMuffer;
            VolumeFireOnMuffler = volumeFireOnMuffler;
            BarrelPositionMuffer = barrelPositionMuffer;
            MufflerInstance = mufflerInstance;
        }
    }
}
