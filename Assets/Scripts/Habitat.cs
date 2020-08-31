using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Habitat : MonoBehaviour
{

    public GameObject player;
    private GameObject animal;
    private CongaLineController congaLine;
    public AnimalSpawner animalSpawner;
    public string type;
    private Vector3 distanceFromPlayer;
    const float distance = 10f;



    //this function is developed for playtesting purposes (delete  before the reliese)
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject == player)
        {
            congaLine = player.GetComponent<CongaLineController>();
            for (int i = 0; i< congaLine.followers.Length; i++)
            {
                if (congaLine.followers[i].name.ToLower() == type.ToLower())
                {
                    animal = congaLine.followers[i].GetComponent<GameObject>();
                    animalSpawner.counter -= 1;
                    Destroy(congaLine.followers[i].gameObject);
                    congaLine.followers[i] = null;
                    CongaLineController.instance.counter -= 1;
                    print("working");
                }
                else
                    print("all good");
            }
        }
    }
    //this function is adapted for smartphone controlls
    /*private void OnMouseDown()
    {
        distanceFromPlayer = transform.position - player.transform.position;
        if(distanceFromPlayer.magnitude <= distance)
        {
            congaLine = player.GetComponent<CongaLineController>();
            for (int i = 0; i < congaLine.followers.Length; i++)
            {
                if (congaLine.followers[i].name.ToLower() == type.ToLower())
                {
                    animal = congaLine.followers[i].GetComponent<GameObject>();
                    animalSpawner.counter -= 1;
                    Destroy(congaLine.followers[i].gameObject);
                    congaLine.followers[i] = null;
                    CongaLineController.instance.counter -= 1;
                    print("working");
                }
                else
                    print("all good");
            }
        }

    }*/
}
