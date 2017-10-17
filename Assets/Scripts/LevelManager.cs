using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public Text UIScore;
    private int score = 0;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }           
        else
        {
            Destroy(this.gameObject);
        }
            
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score = " + score);
        UIScore.text = "Score: " + score;
    }



        

}
