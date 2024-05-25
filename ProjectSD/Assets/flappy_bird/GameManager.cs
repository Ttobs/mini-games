using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instanse;

    [SerializeField] private GameObject _GameOverCanvas;


    private void Awake()
    {
        if (instanse == null) 
        {
            instanse = this;
            
        }
        Time.timeScale = 1;
    }

    public void GameOver() 
    {
        _GameOverCanvas.SetActive(true);

        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void exitMenu()
    {
        SceneManager.LoadScene(2);
    }
}
