using UnityEngine;

public class Spawner : MonoBehaviour
{
    private EnemyCreater[] _spawns; 
    private int _spawnIndex;
    private float _repeatTime;
    private int _spawnCount;

    private void Start()
    {
        _spawnCount = 2;
        _repeatTime = 2.0f;
        _spawns = GetComponentsInChildren<EnemyCreater>();

        InvokeRepeating(nameof(Spawn), 0, _repeatTime);
    }

    private void Spawn()
    {
        _spawnIndex = UserUtility.GetNumber(_spawnCount);
        IEnemySpawner spawner = _spawns[_spawnIndex].GetComponent<IEnemySpawner>();

        spawner.SpawnEnemy();
    }
}

static class UserUtility
{
    private static System.Random _random = new System.Random();

    public static int GetNumber(int minValue, int maxValue)
    {
        return _random.Next(minValue, maxValue);
    }

    public static int GetNumber(int maxValue)
    {
        return _random.Next(maxValue);
    }
}
