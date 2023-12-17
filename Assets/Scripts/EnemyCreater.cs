using UnityEngine;

public interface IEnemySpawner
{
    void SpawnEnemy(Vector3 newPosition);
}

public class EnemyCreater : MonoBehaviour, IEnemySpawner
{
    [SerializeField] private EnemyMover _enemy;

    public void SpawnEnemy(Vector3 direction)
    {
        EnemyMover createdEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        createdEnemy.SetDirection(direction);
    }
}
