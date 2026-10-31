
using UnityEngine;

public class apple : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger detected!");

        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
