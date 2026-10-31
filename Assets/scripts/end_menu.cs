using UnityEngine;
using UnityEngine.SceneManagement;

public class end_menu : MonoBehaviour
{
   const int world = 1;

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
    }

    public void PlayAgain()
    {
        SceneManager.LoadSceneAsync(world);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
