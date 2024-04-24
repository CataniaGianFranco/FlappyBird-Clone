using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text _scoreText = null;
       
    private static GameManager _instance;
    private bool _isGameOver = false;
    private int _score = 0;

    
    public static GameManager Instance { get { return _instance; } }
    public bool IsGameOver { get { return _isGameOver; } }

    private void Awake()
    {
        Singleton();
    }

    private void Singleton()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);
    }

    public void IncreaseScore()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }

    public void GameOver()
    {
        _isGameOver = true;
    }
}
