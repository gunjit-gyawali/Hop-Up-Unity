using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameData
{
    public static int score = 0;
}
public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject cameraPrefab;
    public GameObject playerPrefab;

    public GameObject applePrefab; 

    public TMPro.TextMeshProUGUI tMP_Text;

    public int platformcount = 300;

    public AudioClip backgroundMusic;
    public AudioSource audioSource;

    
    void Start()
    {
        if (audioSource != null && backgroundMusic != null)
        {
            audioSource.clip = backgroundMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
        
        Vector3 spwanPosition = new Vector3();
        for (int i = 0; i < platformcount; i++)
        {
            spwanPosition.y += Random.Range(.5f, 2f);
            spwanPosition.x = Random.Range(-5f, 5f);
            Instantiate(platformPrefab, spwanPosition, Quaternion.identity);
        }

        // apple spwan randomly above platforms and when player collides with apple, it will be destroyed apple will not spwan in every platform, it will spwan in random platforms
        for (int i = 0; i < platformcount; i++)
        {
            if (Random.Range(0, 10) < 3)
            {
                Vector3 applePosition = new Vector3();
                applePosition.y = i * Random.Range(.5f, 2f);
                applePosition.x = Random.Range(-5f, 5f);
                Instantiate(applePrefab, applePosition, Quaternion.identity);
            }
        }
    }
    // if player is below chamera then scene sifts to end_menu (2)

    void Update()
    {
        PlayerDied();
    }
    
    void PlayerDied()
    {
        if (playerPrefab.transform.position.y < Camera.main.transform.position.y - 5f)
        {
            UpdateHighScore();
            SceneManager.LoadScene(2);
        }
    }

    public void UpdateHighScore()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            int highScore = PlayerPrefs.GetInt("HighScore");
            if (GameData.score > highScore)
            {
                PlayerPrefs.SetInt("HighScore", GameData.score);
            }
        }
        else
        {
            PlayerPrefs.SetInt("HighScore", GameData.score);
        }
    }

}
