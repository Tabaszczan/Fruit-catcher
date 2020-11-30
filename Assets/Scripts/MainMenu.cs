using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public string level;
    public void StartGame()
    {
        SceneManager.LoadScene(level);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void OpenOptions()
    {

    }

    public void CloseOptions()
    {

    }

    public void OpenHelp()
    {
        SceneManager.LoadScene("Help");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
