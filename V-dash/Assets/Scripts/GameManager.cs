using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;

    public Text scoreText;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "x " + score.ToString();
    }

    private void Awake()
    {
        inst = this;
    }
}
