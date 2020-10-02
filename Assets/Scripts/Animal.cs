using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    //variables
    private bool isGrounded = false;
    public string animalName;
    private bool isActive = false;
    const float distance = 3f;


    Vector3 DistancefromTarget;

    private Transform player;
    private GameManager gameManager;

    // Update is called once per frame

    private void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        this.name = animalName;
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
    //this function is developed for playtesting purposes (delete before the release)
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform == player && gameManager.phoneVersion == false)
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

    //checks collision. if collider is ground - all good, otherwise - recreate object
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground" && isGrounded == false)
        {
            this.GetComponent<MeshRenderer>().enabled = true;
            this.GetComponent<Collider>().isTrigger = true;
            Destroy(this.GetComponent<Rigidbody>());
            isGrounded = true;
        }
        else if(collision != null)
        {
            Destroy(this.gameObject);
            AnimalSpawner.instance.counter -= 1;
        }
    }
    //function to follow previous gameobject
    private void Follow(Transform target)
    {
        DistancefromTarget = transform.position - target.position;
        transform.LookAt(target);
        if(DistancefromTarget.magnitude > distance)
        {
            transform.Translate(0.0f, 0.0f, gameManager.playerSpeed * Time.deltaTime);
        }
    }


}
