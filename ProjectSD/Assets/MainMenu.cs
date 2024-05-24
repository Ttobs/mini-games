using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Game1() 
    {
        SceneManager.LoadScene(0);
        Debug.Log("game 1");
    }

    public void Game2()
    {
        SceneManager.LoadScene(1);
        Debug.Log("game 2");
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
