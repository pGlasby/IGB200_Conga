using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSlow : MonoBehaviour
{
    private GameManager gameManager;
    private float localSpeed;
    private bool isColliding;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        localSpeed = gameManager.playerSpeed;
        isColliding = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            isColliding = true;
            gameManager.playerSpeed = gameManager.playerSpeed / 2;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && isColliding == true)
        {
            isColliding = false;
            gameManager.playerSpeed = localSpeed;

        }
    }

}
