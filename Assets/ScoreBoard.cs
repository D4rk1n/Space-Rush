using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public int ScorePerHit = 100;
    int currScore;
    Text Score;
    // Start is called before the first frame update
    void Start()
    {
        currScore = 0;
        Score = GetComponent<Text>();
        Score.text = currScore.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Score.text = currScore.ToString();
    }
    public void UpdateScore()
    {
        currScore += ScorePerHit;
    }
}
