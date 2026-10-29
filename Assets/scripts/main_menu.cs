using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    const int World = 1;
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(World);
    }
}
