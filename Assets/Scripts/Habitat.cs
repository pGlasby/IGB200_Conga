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


    private void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        congaLine = Object.FindObjectOfType<CongaLineController>();
        animalSpawner = Object.FindObjectOfType<AnimalSpawner>();
    }

    //this function is developed for playtesting purposes (delete  before the reliese)
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject == player && gameManager.phoneVersion == false)
        {

            for (int i = 0; i< congaLine.followers.Length; i++)
            {
                if (congaLine.followers[i].name.ToLower() == type.ToLower())
                {
                    animalSpawner.counter -= 1;
                    Destroy(congaLine.followers[i].gameObject);
                    congaLine.followers[i] = null;
                    congaLine.counter -= 1;
                    gameManager.score += 100;
                    print("working");
                }
                else
                    print("all good");
            }
        }
        
    }
    //this function is adapted for smartphone controlls
    private void OnMouseDown()
    {
        distanceFromPlayer = transform.position - player.transform.position;
        if(distanceFromPlayer.magnitude <= distance && gameManager.phoneVersion == true)
        {
            for (int i = 0; i < congaLine.followers.Length; i++)
            {
                if (congaLine.followers[i].name.ToLower() == type.ToLower())
                {
                    animalSpawner.counter -= 1;
                    Destroy(congaLine.followers[i].gameObject);
                    congaLine.followers[i] = null;
                    congaLine.counter -= 1;
                    gameManager.score += 100;
                    print("working");
                }
                else
                    print("all good");
            }
        }

    }
}
