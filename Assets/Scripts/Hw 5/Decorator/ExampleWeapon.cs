using UnityEngine;

namespace Asteroid
{
    internal class ExampleWeapon : MonoBehaviour
    {
        private IFire _fire;
        [Header("Start Gun")]
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrelPosition;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private AudioClip _audioClip;

        [Header("Muffer")]
        [SerializeField] private AudioClip _audioClipMuffer;
        [SerializeField] private float _volumeFireOnMuffer;
        [SerializeField] private Transform _barrelPositionMuffler;
        [SerializeField] private GameObject _muffler;

        [Header("BadaBum")]
        [SerializeField] private AudioClip _audioClipBadaBum;
        [SerializeField] private float _volumeFireOnBadaBume;
        [SerializeField] private Rigidbody2D _bigBullet;

        private Muffer muffler;
        private BadaBum badaBum;
        private ModificationWeapon _modificationWeapon;
        private Weapon _weapon;
        private bool _hasMuffler;

        private void Start()
        {
            IAmmuntion ammuntion = new ExampleBullet(_bullet, 2.0f);
            IAmmuntion ammuntionTwo = new ExampleBullet(_bigBullet, 2.0f);
            _weapon = new Weapon(_barrelPosition, ammuntion, 20.0f, _audioClip, _audioSource);

            muffler = new Muffer(_audioClipMuffer, _volumeFireOnMuffer, _barrelPosition, _muffler);

            //_modificationWeapon = new ModificationMuffler(_audioSource, muffler, _barrelPositionMuffler.position);
            badaBum = new BadaBum(ammuntionTwo, _audioClipBadaBum, _volumeFireOnBadaBume);
            _modificationWeapon = new ModificatorBadaBum(_audioSource, badaBum);


        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _weapon.Fire();
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (!_hasMuffler)
                {
                    _modificationWeapon.ApplayModification(_weapon);
                    _hasMuffler = true;
                    Debug.Log(_hasMuffler);
                }
                else if (_hasMuffler)
                {
                    _modificationWeapon.RemoveModification(_weapon);
                    _hasMuffler = false;
                    Debug.Log(_hasMuffler);
                }
            }
        }

    }
}
