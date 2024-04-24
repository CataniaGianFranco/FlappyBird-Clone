using UnityEngine;

public class Score : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.IncreaseScore();
        }
    }
}
