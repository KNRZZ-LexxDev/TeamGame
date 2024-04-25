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

    public void OpenLevel_2()
    {
        SceneManager.LoadScene(4);
    }

    public void OpenLevel_3()
    {
        SceneManager.LoadScene(5);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
