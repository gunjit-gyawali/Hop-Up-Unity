using UnityEngine;
using UnityEngine.SceneManagement;

public class end_menu : MonoBehaviour
{
   const int world = 1;

    public void PlayAgain()
    {
        SceneManager.LoadSceneAsync(world);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
