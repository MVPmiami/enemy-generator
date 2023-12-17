using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private float _speed;
    private Vector3 _direction;

    private void Start()
    {
        _speed = 8;
    }

    private void Update()
    {
        Move();
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Move()
    {
        float step = _speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, _direction, step);
    }
}