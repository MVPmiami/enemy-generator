using UnityEngine;

public interface IEnemySpawner
{
    void SpawnEnemy();
}

public class EnemyCreater : MonoBehaviour, IEnemySpawner
{
    [SerializeField] private GameObject _enemy;

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    public void SpawnEnemy()
    {
        GameObject enemy = Instantiate(_enemy, _startPosition, Quaternion.identity);
    }
}
