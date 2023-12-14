using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed;
    private Vector3 _newPosition;
    private Vector3 _startPosition;
    private int _minRange;
    private int _maxRange;

    private void Start()
    {
        _speed = 8;
        _minRange = -200;
        _maxRange = 200;
        _startPosition = transform.position;
        _newPosition = new Vector3(UserUtility.GetNumber(_minRange, _maxRange), _startPosition.y, UserUtility.GetNumber(_minRange, _maxRange));
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float step = _speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, _newPosition, step);
    }
}