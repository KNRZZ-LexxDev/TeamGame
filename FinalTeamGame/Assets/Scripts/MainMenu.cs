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

    public void OpenLevel_4()
    {
        SceneManager.LoadScene(6);
    }

    public void OpenLevel_5()
    {
        SceneManager.LoadScene(7);
    }

    public void OpenLevel_6()
    {
        SceneManager.LoadScene(8);
    }

    public void OpenLevel_7()
    {
        SceneManager.LoadScene(9);
    }

    public void OpenLevel_8()
    {
        SceneManager.LoadScene(10);
    }

    public void OpenLevel_9()
    {
        SceneManager.LoadScene(11);
    }

    public void OpenLevel_10()
    {
        SceneManager.LoadScene(12);
    }

    public void OpenLevel_11()
    {
        SceneManager.LoadScene(13);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
