using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private GameObject _pipePrefab = null;
    private int _poolSize = 5;
    private float _spawnTimer = 2.5f;

    private void Start()
    {
        GenerateObstacles();
    }

    private void Update()
    {
        
    }

    private void GenerateObstacles()
    {
        for (int i = 0; i < _poolSize; i++)
        {
            GameObject _pipe = Instantiate<GameObject>(_pipePrefab);
            _pipe.SetActive(false);
            _pipe.gameObject.transform.SetParent(this.transform);
            _pipe.transform.position = new Vector3(12.0f, 0.0f, 0.0f);
        }
    }
}
