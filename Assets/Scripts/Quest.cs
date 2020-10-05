﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest : MonoBehaviour
{

    public Text questText;
    private AlltimeVariables alltimeVariables;
    public int value = -1;
    private Quest instance;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        alltimeVariables = Object.FindObjectOfType<AlltimeVariables>();
        gameManager = Object.FindObjectOfType<GameManager>();
        QuestSetUp();

    }

    // Update is called once per frame
    void Update()
    {
        questText.text = "Collect " + gameManager.questValue + " POSSUMS";


        if(gameManager.questValue <= 0)
        {
            questText.text = "DONE!";
            int temp;
            for (int i = 0; i < alltimeVariables.questChecker.Length; i++)
            {
                if(alltimeVariables.questChecker[i] == true)
                {
                    temp = i;
                    alltimeVariables.questCompletionChecker[temp] = true;
                }
            }

        }
    }
    private void QuestSetUp()
    {
        for (int i = 0; i < alltimeVariables.questChecker.Length; i++)
        {
            if (alltimeVariables.questChecker[i] == true )
            {
                print(i);
                if (i == 0)//possum quest
                {
                    value = 5;
                    gameManager.questValue = value;
                    questText.text = "Collect" + value + "POSSUMS";
                }
                if(i == 1)
                {

                }
                if(i == 2)
                {

                }
                if(i == 3)
                {

                }
                if(i == 4)
                {

                }



            }
        }
    }

}