using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb = null;
    private float _speed = 2.5f;

    private void Update()
    {
        Scrolling();
    }

    private void Scrolling()
    {
        if (!GameManager.Instance.IsGameOver)
            _rb.position += Vector3.left * _speed * Time.deltaTime;
        else
            _rb.position = Vector3.zero;
    }
}
