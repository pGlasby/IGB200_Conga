using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlltimeVariables : MonoBehaviour
{

    //public bool isRunning = false;
    private GameObject[] instances;

    //score variables
    public float score;
    public float highScore = 0;

    //shop variables
    public float coins;
    public float coinBackUp;
    public bool buyNotEnoughCoins = false;



    //difficulty settings
    
    public float[] timeSetting = new float[3];
    public float[] multiplierSetting = new float[3];
    public int spawnRate;
    public bool[] difficultyChecker = new bool[3];

    //quest settings
    public bool[] questChecker = new bool[5];
    public bool[] questCompletionChecker = new bool[5];

    //boost settings
    public bool[] boostChecker = new bool[5];



    // Start is called before the first frame update
    void Start()
    {
        instances = GameObject.FindGameObjectsWithTag("Instance");
        coinBackUp = coins;
        for (int i = 0; i < questChecker.Length; i++)
        { 
            questCompletionChecker[i] = false;
        }
        Reset();
        
    }

    // Update is called once per frame
    void Update()
    {
         if(instances.Length > 1)
        {
            Destroy(instances[1]);
        }

    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    public void Reset()
    {
        score = 0;
        for (int i = 0; i < questChecker.Length; i++)
        {
            questChecker[i] = false;
            boostChecker[i] = false;
        }
        for (int i = 0; i < difficultyChecker.Length; i++)
        {
            difficultyChecker[i] = false;
        }
    }


}
