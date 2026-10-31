using UnityEngine;
using UnityEngine.SceneManagement;

public class end_menu : MonoBehaviour
{
   const int world = 1;

    public AudioClip backgroundMusic;
    public AudioSource audioSource;
    public TMPro.TextMeshProUGUI tMP_Text;

    public TMPro.TextMeshProUGUI highScoreText;

    void Start()
    {
        tMP_Text.text = "Score: " + GameData.score;
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0);
        if (audioSource != null && backgroundMusic != null)
        {
            audioSource.clip = backgroundMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void PlayAgain()
    {
        GameData.score = 0;
        SceneManager.LoadSceneAsync(world);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
