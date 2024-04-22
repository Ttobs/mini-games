using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void Game1() 
    {
        SceneManager.LoadScene(1);
    }

    public void Game2()
    {
        SceneManager.LoadScene(2);
    }

    public void Game3()
    {
        SceneManager.LoadScene(3);
    }

    public void Game4()
    {
        SceneManager.LoadScene(4);
    }

    public void Game5()
    {
        SceneManager.LoadScene(5);
    }

    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
