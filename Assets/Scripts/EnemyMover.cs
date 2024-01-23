using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private float _speed;
    private Target _target;

    private void Start()
    {
        _speed = 2f;
    }

    private void Update()
    {
        Move();
    }

    public void SetDirection( Target target)
    {
        _target  = target;
    }

    private void Move()
    {
        float step = _speed * Time.deltaTime;

        transform.position = Vector3.Lerp(transform.position, _target.transform.position, step);
    }
}