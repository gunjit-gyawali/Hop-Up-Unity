using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{

    public AudioClip backgroundMusic;
    public AudioSource audioSource;
    
    public TMPro.TextMeshProUGUI HighScoreText;
    const int World = 1;

    void Start()
    {
        HighScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0);
        if (audioSource != null && backgroundMusic != null)
        {
            audioSource.clip = backgroundMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }   
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(World);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
