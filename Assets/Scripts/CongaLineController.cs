using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongaLineController : MonoBehaviour
{
    public Transform[] followers = new Transform[5];
    public int counter;
    public static CongaLineController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}
