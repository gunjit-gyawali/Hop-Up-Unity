using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{

    public AudioClip backgroundMusic;
    public AudioSource audioSource;
    
    const int World = 1;

    void Start()
    {
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
