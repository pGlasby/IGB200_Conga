using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    private GameObject[] instances;

    private void Awake()
    {
        instances = GameObject.FindGameObjectsWithTag("BgSound");
        DontDestroyOnLoad(transform.gameObject);
    }
    private void Update()
    {
        if (instances.Length > 1)
        {
            Destroy(instances[1]);
        }
    }
}
