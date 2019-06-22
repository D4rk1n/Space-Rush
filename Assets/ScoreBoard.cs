using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBoard : MonoBehaviour
{
    public Text Score;
    public Text FinalScore;
    // Start is called before the first frame update
    void Start()
    {
        FinalScore.text = "YOUR SCORE : " + Score.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
