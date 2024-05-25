using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AllScrips : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene(2);
        Debug.Log("test");
    }

    public Text Result;
    public Image AIChoise;
    public Text Score;
    private int scr;

    public string[] Choices;
    public Sprite Rock, Paper, Scissors;

    public void Game(string myChoice)
    {
        string randomChoise = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoise) 
        {
            case "Rock":
                switch (myChoice) 
                {
                    case "Rock":
                        Result.text = "Tie";
                        break;

                    case "Paper":
                        Result.text = "Win!";
                        scr++;
                        Score.text = scr.ToString();
                        break;

                    case "Scissors":
                        Result.text = "Lose";
                        scr = 0;
                        Score.text = "0";
                        break;
                }

                AIChoise.sprite = Rock;
                break;

            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "Lose";
                        scr = 0;
                        Score.text = "0";
                        break;

                    case "Paper":
                        Result.text = "Tie";
                        break;

                    case "Scissors":
                        Result.text = "Win!";
                        scr++;
                        Score.text = scr.ToString();
                        break;
                }

                AIChoise.sprite = Paper;
                break;

            case "Scissors":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "Win!";
                        scr++;
                        Score.text = scr.ToString();
                        break;

                    case "Paper":
                        Result.text = "Lose";
                        scr = 0;
                        Score.text = "0";
                        break;

                    case "Scissors":
                        Result.text = "Tie";
                        break;
                }

                AIChoise.sprite = Scissors;
                break;
        }
    }
}
