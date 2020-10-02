using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    //set of different animal types
    public GameObject[] animals = new GameObject[1];

    //genereal variables
    public float playerSpeed;
    public float gravity;
    public float timeLimit;
    public float score;
    public float scoreMultiplier;

    //border objects
    public GameObject leftWall;
    public GameObject rightWall;
    public GameObject topWall;
    public GameObject bottomWall;

    public bool phoneVersion = false;
    public GameObject joystick;

    private AlltimeVariables alltimeVariables;

    public GameObject questWindow;
    public int questValue;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        alltimeVariables = Object.FindObjectOfType<AlltimeVariables>();


        if (phoneVersion == true)
        {
            joystick.SetActive(true);

        }

        GameSetUp();
        QuestSetUp();
        BoostSetUp();

    }
    private void Update()
    {
        if (timeLimit < 0)
        {
            SceneManager.LoadScene("ResultScene");
            alltimeVariables.score = score;
            alltimeVariables.coins += (score / 100);
        }


    }
    private void GameSetUp()
    {
        for (int i = 0; i < alltimeVariables.difficultyChecker.Length; i++)
        {
            if (alltimeVariables.difficultyChecker[i] == true)
            {
                if (i == 0)
                {
                    timeLimit = alltimeVariables.timeSetting[0];
                    scoreMultiplier = alltimeVariables.multiplierSetting[0];
                    TrapSlow[] trapSlows = (TrapSlow[])GameObject.FindObjectsOfType(typeof(TrapSlow));
                    foreach (TrapSlow trapSlow in trapSlows)
                    {
                        trapSlow.gameObject.SetActive(false);
                    }
                    TrapScare[] trapScares = (TrapScare[])GameObject.FindObjectsOfType(typeof(TrapScare));
                    foreach (TrapScare trapScare in trapScares)
                    {
                        trapScare.gameObject.SetActive(false);
                    }
                }
                if (i == 1)
                {
                    timeLimit = alltimeVariables.timeSetting[1];
                    scoreMultiplier = alltimeVariables.multiplierSetting[1];
                    TrapScare[] trapScares = (TrapScare[])GameObject.FindObjectsOfType(typeof(TrapScare));
                    foreach (TrapScare trapScare in trapScares)
                    {
                        trapScare.gameObject.SetActive(false);
                    }
                }
                if (i == 2)
                {
                    timeLimit = alltimeVariables.timeSetting[2];
                    scoreMultiplier = alltimeVariables.multiplierSetting[2];
                }
            }
        }
    }
    private void QuestSetUp()
    {
        for (int i = 0; i < alltimeVariables.questChecker.Length; i++)
        {
            if (alltimeVariables.questChecker[i] == true)
            {
                questWindow.SetActive(true);

            }
        }
    }
    private void BoostSetUp()
    {
        for (int i = 0; i < alltimeVariables.boostChecker.Length; i++)
        {
            if (alltimeVariables.boostChecker[i] == true)
            {
                if (i == 0)
                {
                    playerSpeed *= 1.2f;
                }
                if (i == 1)
                {
                    TrapSlow[] trapSlows = (TrapSlow[])GameObject.FindObjectsOfType(typeof(TrapSlow));
                    foreach (TrapSlow trapSlow in trapSlows)
                    {
                        trapSlow.gameObject.SetActive(false);
                    }
                }
                if (i == 2)
                {
                    TrapScare[] trapScares = (TrapScare[])GameObject.FindObjectsOfType(typeof(TrapScare));
                    foreach (TrapScare trapScare in trapScares)
                    {
                        trapScare.gameObject.SetActive(false);
                    }
                }
                if (i == 3)
                {
                    //see Timer...
                }
                if (i == 4)
                {
                    //see AnimalSpawner...
                }

            }
        }

    }
}
