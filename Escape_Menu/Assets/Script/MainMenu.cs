using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MapSelect");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Day()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Night()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
