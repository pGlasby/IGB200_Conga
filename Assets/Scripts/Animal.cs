using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public Transform player;
    private bool isActive = false;
    const float distance = 3f;
    Vector3 DistancefromTarget;
    private float speed = PlayerController.speed;
    private string[] animalTypes = new string[5];


    // Update is called once per frame

    private void Start()
    {
        animalTypes[0] = "bird";
        animalTypes[1] = "reptile";
        animalTypes[2] = "fish";
        animalTypes[3] = "mammal";
        animalTypes[4] = "amphibian";
        this.name = animalTypes[Random.Range(0, animalTypes.Length)];


    }


    void LateUpdate()
    {
        
        if(isActive == true)
        {
            if(this.transform == CongaLineController.instance.followers[0])
            {
                Follow(player);
            }
            else if(this.transform == CongaLineController.instance.followers[1])
            {
                if(CongaLineController.instance.followers[0] == null)
                {
                    CongaLineController.instance.followers[0] = this.transform;
                    CongaLineController.instance.followers[1] = null;
                }
                else
                    Follow(CongaLineController.instance.followers[0]);
            }
            else if (this.transform == CongaLineController.instance.followers[2])
            {
                if (CongaLineController.instance.followers[1] == null)
                {
                    CongaLineController.instance.followers[1] = this.transform;
                    CongaLineController.instance.followers[2] = null;
                }
                else
                    Follow(CongaLineController.instance.followers[1]);
            }
            else if (this.transform == CongaLineController.instance.followers[3])
            {
                if (CongaLineController.instance.followers[2] == null)
                {
                    CongaLineController.instance.followers[2] = this.transform;
                    CongaLineController.instance.followers[3] = null;
                }
                else
                    Follow(CongaLineController.instance.followers[2]);
            }
            else if (this.transform == CongaLineController.instance.followers[4])
            {
                if (CongaLineController.instance.followers[3] == null)
                {
                    CongaLineController.instance.followers[3] = this.transform;
                    CongaLineController.instance.followers[4] = null;
                }
                else
                    Follow(CongaLineController.instance.followers[3]);
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform == player)
        {
            isActive = true;
            if (CongaLineController.instance.followers[4] == null)
            {
                CongaLineController.instance.followers[CongaLineController.instance.counter] = this.transform;
                this.GetComponent<Collider>().isTrigger = false;
                CongaLineController.instance.counter += 1;
                print(this.name);
            }
            else
                print("I can't take another animal with me now!");

        }
    }
    private void Follow(Transform target)
    {
        DistancefromTarget = transform.position - target.position;
        transform.LookAt(target);
        if(DistancefromTarget.magnitude > distance)
        {
            transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
        }
    }


}
