using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    int currScore;
    Text ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        currScore = 0;
        ScoreText = GetComponent<Text>();
        ScoreText.text = currScore.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        ScoreText.text = currScore.ToString();
    }
    public void UpdateScore(int ScorePerHit = 100)
    {
        currScore += ScorePerHit;
    }
    public void Stop()
    {
        gameObject.SetActive(false);
    }
}
