using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OpenLevels()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenAreYouSureQuitGame()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenLevel_1()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
