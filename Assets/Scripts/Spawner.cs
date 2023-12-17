using UnityEngine;

public class Spawner : MonoBehaviour
{
    private EnemyCreater[] _spawns; 
    private int _spawnIndex;
    private float _repeatTime;
    private int _spawnCount;
    private int _minRange;
    private int  _maxRange;
    private Vector3 _startPosition;
    private Vector3 _newPosition;

    private void Start()
    {
        _spawnCount = 2;
        _repeatTime = 2.0f;
        _spawns = GetComponentsInChildren<EnemyCreater>();
        _minRange = -200;
        _maxRange = 200;

        InvokeRepeating(nameof(Spawn), 0, _repeatTime);
    }

    private void Spawn()
    {
        _spawnIndex = UserUtility.GetNumber(_spawnCount);
        _startPosition = _spawns[_spawnIndex].transform.position;
        _newPosition = new Vector3(UserUtility.GetNumber(_minRange, _maxRange), _startPosition.y, UserUtility.GetNumber(_minRange, _maxRange));
        IEnemySpawner spawner = _spawns[_spawnIndex].GetComponent<IEnemySpawner>();

        spawner.SpawnEnemy(_newPosition);
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
