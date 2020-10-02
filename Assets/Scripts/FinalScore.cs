using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public TMP_Text scoreTextPro;
    public TMP_Text HighScoreTextPro;
    private AlltimeVariables alltimeVariables;
    // Start is called before the first frame update
    void Start()
    {
        alltimeVariables = Object.FindObjectOfType<AlltimeVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = "Your Score:\n" + alltimeVariables.score + " =\n"+ alltimeVariables.coins + " coins";
        scoreTextPro.text = "Your Score:\n" + alltimeVariables.score + " =\n" + alltimeVariables.coins + " coins"; ;
        if(alltimeVariables.score > alltimeVariables.highScore)
        {
            alltimeVariables.highScore = alltimeVariables.score;
        }
        HighScoreTextPro.text = "Highscore:\n" + alltimeVariables.highScore; ;
        //highScoreText.text = "Highscore:\n" + alltimeVariables.highScore;
    }
}
