using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject[] animals = new GameObject[1];
    public float playerSpeed;
    public float gravity;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        Instantiate(animals[0], new Vector3(-13, 5, 20), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
