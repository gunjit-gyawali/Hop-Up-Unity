using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject cameraPrefab;
    public GameObject playerPrefab;

    public GameObject applePrefab; 

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
        if (playerPrefab.transform.position.y < cameraPrefab.transform.position.y - 5f)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }
    

}
