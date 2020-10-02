using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Image timerImage;
    private GameManager gameManager;
    private float timeShow;

    Vector3 rotation;
    private AlltimeVariables alltimeVariables;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        alltimeVariables = Object.FindObjectOfType<AlltimeVariables>();
        float temp;
        if (alltimeVariables.difficultyChecker[0] == true)
        {
            temp = alltimeVariables.timeSetting[0];
            timeShow = temp;

        }
        if (alltimeVariables.difficultyChecker[1] == true)
        {
            temp = alltimeVariables.timeSetting[1];
            timeShow = temp;

        }
        if (alltimeVariables.difficultyChecker[2] == true)
        {
            temp = alltimeVariables.timeSetting[2];
            timeShow = temp;

        }
        if (alltimeVariables.boostChecker[3] == true)
        {
            timeShow += 30;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeShow -= Time.deltaTime;
        gameManager.timeLimit = timeShow;
        timerText.text = timeShow.ToString("0");
        rotation -= Vector3.forward * (180 / gameManager.timeLimit) * Time.deltaTime;
        timerImage.transform.rotation = Quaternion.Euler(rotation);
    }
}
