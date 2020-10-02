using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    //variable how many animals should spawn
    public int animalMax;

    public GameManager gameManager;

    //counts how many animals are spawned 
    public int counter;

    public static AnimalSpawner instance;
    private AlltimeVariables alltimeVariables;
    public bool isReady = false;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        counter = 0;
        alltimeVariables = Object.FindObjectOfType<AlltimeVariables>();
        animalMax = alltimeVariables.spawnRate;
        if(alltimeVariables.boostChecker[4] == true)
        {
            animalMax *= 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < animalMax)
        {
            Instantiate(gameManager.animals[Random.Range(0,5)],
                new Vector3(Random.Range(gameManager.leftWall.transform.position.x, gameManager.rightWall.transform.position.x), 5,
                Random.Range(gameManager.bottomWall.transform.position.z, gameManager.topWall.transform.position.z)),
                Quaternion.Euler(0, Random.Range(0, 360), 0));
            counter += 1;
        }
    }
}
