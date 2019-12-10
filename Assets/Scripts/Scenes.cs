using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{

    public void Highscorescene()
    {
        SceneManager.LoadScene("2HighScores");
    }
    public void Game()
    {

        SceneManager.LoadScene("3Game");

    }
    public void ExitGame()
    {

        SceneManager.LoadScene("4Exit");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("1Intro");
    }
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
