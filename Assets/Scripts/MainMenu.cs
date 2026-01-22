using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void easyMode()
    {
        SceneManager.LoadSceneAsync(1); 
    }

    public void mediumMode()
    {
        SceneManager.LoadSceneAsync("MediumMode");
    }

    public void hardMode()
    {
        SceneManager.LoadSceneAsync("HardMode");
    }
}
