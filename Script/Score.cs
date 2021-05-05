using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int initialScore;
    public  int newScore;
    private int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        currentScore = initialScore;
        InvokeRepeating("UpdateScore", 1f, 1f);
    }

    
    public void UpdateScore()
    {
        currentScore -= newScore;
        GetComponent<Text> ().text = "Score:" + currentScore.ToString();
    }
}
