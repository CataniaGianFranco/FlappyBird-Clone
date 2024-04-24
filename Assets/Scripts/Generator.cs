using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private GameObject _pipePrefab = null;
    private GameObject[] _obstacles = null;
    private float xSpawnPosition = 12.0f;
    private float ySpawnTopPosition = 3.25f;
    private float ySpawnBottomPosition = -1.25f;
    private int _poolSize = 5;
    private int _obstacleCount = 0;
    private float _timeElapsed = 0.0f;
    private float _spawnTime = 2.5f;

    private void Start()
    {
        GenerateObstacles();
    }

    private void Update()
    {
        SpawnWithTimer();
    }

    private void GenerateObstacles()
    {
        _obstacles = new GameObject[_poolSize];

        for (int i = 0; i < _poolSize; i++)
        {
            _obstacles[i] = Instantiate<GameObject>(_pipePrefab);
            _obstacles[i].gameObject.transform.SetParent(this.transform);
            _obstacles[i].SetActive(false);
        }
    }

    private void SpawnWithTimer()
    {
        _timeElapsed += Time.deltaTime;

        if (_timeElapsed > _spawnTime && !GameManager.Instance.IsGameOver)
            SpawnObstacle();
    }

    private void SpawnObstacle()
    {
        _timeElapsed = 0.0f;

        float ySpawnPosition = Random.Range(ySpawnBottomPosition, ySpawnTopPosition);
        Vector3 spawnPosition = new Vector3(xSpawnPosition, ySpawnPosition, 0.0f);
        _obstacles[_obstacleCount].transform.position = spawnPosition;
        
        if (!_obstacles[_obstacleCount].activeSelf)
            _obstacles[_obstacleCount].SetActive(true);

        _obstacleCount++;

        if (_obstacleCount == _poolSize)
            _obstacleCount = 0;
    }
}
