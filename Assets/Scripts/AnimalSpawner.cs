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

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < animalMax)
        {
            Instantiate(gameManager.animals[Random.Range(0,5)],
                new Vector3(Random.Range(gameManager.leftWall.transform.position.x, gameManager.rightWall.transform.position.x), 5,
                Random.Range(gameManager.bottomWall.transform.position.z, gameManager.topWall.transform.position.z)),
                Quaternion.identity);
            counter += 1;
        }
    }
}
