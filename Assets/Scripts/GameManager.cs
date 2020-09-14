using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    //set of different animal types
    public GameObject[] animals = new GameObject[1];

    //genereal variables
    public float playerSpeed;
    public float gravity;
    public float timeLimit = 10;
    public int score;

    //border objects
    public GameObject leftWall;
    public GameObject rightWall;
    public GameObject topWall;
    public GameObject bottomWall;

    public bool phoneVersion = false;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

    }

}
