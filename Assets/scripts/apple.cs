
using UnityEngine;

public class apple : MonoBehaviour
{
    public GameObject gameManager;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger detected!");

        if (collision.CompareTag("Player"))
        {
            GameData.score += 1;
            gameManager.GetComponent<GameManager>().tMP_Text.text = "Score: " + GameData.score;
            Destroy(gameObject);
        }
    }
}
