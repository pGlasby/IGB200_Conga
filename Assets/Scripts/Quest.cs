using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Quest : MonoBehaviour
{

    public TMP_Text questText;
    private AlltimeVariables alltimeVariables;
    public int value = -1;
    private Quest instance;
    private GameManager gameManager;
    private string animalName;
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
        questText.text = "Collect " + gameManager.questValue + " " + animalName;


        if(gameManager.questValue <= 0)
        {
            questText.text = "DONE!";
            int temp;
            for (int i = 0; i < alltimeVariables.questChecker.Length; i++)
            {
                if(alltimeVariables.questChecker[i] == true)
                {
                    //temp = i;
                    alltimeVariables.questCompletionChecker[i] = true;
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
                    animalName = "POSSUMS";
                    gameManager.questValue = value;
                    questText.text = "Collect " + gameManager.questValue + " " + animalName;
                }
                if(i == 1)
                {
                    value = 3;
                    animalName = "GECKOS";
                    gameManager.questValue = value;
                    questText.text = "Collect " + gameManager.questValue + " " + animalName;

                }
                if(i == 2)
                {
                    value = 20;
                    animalName = "SNAKES";
                    gameManager.questValue = value;
                    questText.text = "Collect " + gameManager.questValue + " " + animalName;
                }
                if(i == 3)
                {
                    value = 30;
                    animalName = "FISH";
                    gameManager.questValue = value;
                    questText.text = "Collect " + gameManager.questValue + " " + animalName;
                }
                if(i == 4)
                {
                    value = 5;
                    animalName = "BIRDS";
                    gameManager.questValue = value;
                    questText.text = "Collect " + gameManager.questValue + " " + animalName;
                }



            }
        }
    }

}
