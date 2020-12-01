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

    public void ResetGame()
    {
        SceneManager.LoadScene(level);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
    public void OpenOptions()
    {
        SceneManager.LoadScene("Options");

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
