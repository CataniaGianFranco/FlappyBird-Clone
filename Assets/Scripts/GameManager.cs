using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    private bool _isGameOver = false;
    public bool IsGameOver { get { return _isGameOver; } }

    private void Awake()
    {
        Singleton();
    }

    private void Update()
    {
        
    }

    private void Singleton()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }

    public void Gameover()
    {
        _isGameOver = true;
    }
}
