using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habitat : MonoBehaviour
{

    public GameObject player;
    private CongaLineController congaLine;
    private AnimalSpawner animalSpawner;
    public string type;
    private Vector3 distanceFromPlayer;
    const float distance = 10f;
    private GameManager gameManager;
    private AlltimeVariables alltimeVariables;
    private AudioSource audio;


    private void Start()
    {
        audio = GetComponent<AudioSource>();
        gameManager = Object.FindObjectOfType<GameManager>();
        congaLine = Object.FindObjectOfType<CongaLineController>();
        animalSpawner = Object.FindObjectOfType<AnimalSpawner>();
        alltimeVariables = Object.FindObjectOfType<AlltimeVariables>();
    }

    //this function is developed for playtesting purposes (delete  before the reliese)
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == player)
        {
            int counter = 0;


            for (int i = 0; i < congaLine.followers.Length; i++)
            {
                if (congaLine.followers[i].name.ToLower() == type.ToLower())
                {
                    counter += 1;
                    string name = congaLine.followers[i].name;
                    if (name.ToLower() == type.ToLower())
                    {
                        if ((name.ToLower() == "amphibian" && alltimeVariables.questChecker[1] == true) ||
                            (name.ToLower() == "reptile" && alltimeVariables.questChecker[2] == true) || (name.ToLower() == "fish" && alltimeVariables.questChecker[3] == true))
                        {
                            gameManager.questValue -= 1;
                        }
                        if (name.ToLower() == "mammal" && alltimeVariables.questChecker[0] == true && counter == 5)
                        {
                            gameManager.questValue -= 5;
                        }
                        if (name.ToLower() == "bird" && alltimeVariables.questChecker[4] == true && counter == 5)
                        {
                            gameManager.questValue -= 5;
                        }

                        animalSpawner.counter -= 1;
                        Destroy(congaLine.followers[i].gameObject);
                        congaLine.followers[i] = null;
                        congaLine.counter -= 1;
                        gameManager.score += 100 * gameManager.scoreMultiplier;
                        print("working");
                        print(counter);
                        if(counter> 0)
                        {
                            audio.Play();
                        }
                    }
                    else
                        print("all good");
                }
            }


        }

    }
}
