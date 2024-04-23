using UnityEngine;

public class PlayerThirdController : MonoBehaviour
{
    [SerializeField] private CharacterController _playerController = null;
    private Vector3 _playerDirection = Vector3.zero;
    private float _gravity = -9.81f;
    private float _impulseForce = 5.0f;

    private void Update()
    {
        ApplyGravity();
        Impulse();
        _playerController.Move(_playerDirection * Time.deltaTime);
    }

    private void ApplyGravity()
    {
        _playerDirection.y += _gravity * Time.deltaTime; 
    }

    private void Impulse()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerDirection.y = _impulseForce;
        }
    }
}
