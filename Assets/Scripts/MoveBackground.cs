using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    private Transform _backTransform;
    private float _backSize;
    private float _backPos;
    void Start()
    {
        _backTransform = GetComponent<Transform>();
        _backSize = GetComponent<SpriteRenderer>().bounds.size.x;
        
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }
    public void Move()
    {
        _backPos += speed * Time.deltaTime;
        _backPos = Mathf.Repeat(_backPos, _backSize);
        _backTransform.position = new Vector3(_backPos, 0.0f, 0.0f);
    }
}
