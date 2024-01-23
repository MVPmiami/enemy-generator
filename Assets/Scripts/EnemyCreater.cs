using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public interface IEnemySpawner
{
    void SpawnEnemy();
}

public class EnemyCreater : MonoBehaviour, IEnemySpawner
{
    [SerializeField] private EnemyMover _enemy;
    [SerializeField] private Target _target;

    public void SpawnEnemy()
    {
        EnemyMover createdEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        createdEnemy.SetDirection( _target);
    }
}
