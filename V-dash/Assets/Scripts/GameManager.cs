using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int score = 0;
    public static GameManager inst;

    public Text scoreText;

 
  /*  public int IncrementScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "x " + score.ToString();
        return scoreToAdd;
    }*/

    private void Update()
    {
       
    }

    private void Awake()
    {
        inst = this;
        scoreText.text = "x " + score.ToString();
    }
}
