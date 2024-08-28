using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{
    public int totalScore;
    public static Gamecontroller instance;
    public Text scoreText;
    public GameObject gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGamerOver()
    {
        gameOver.SetActive(true);
    }

   
}
