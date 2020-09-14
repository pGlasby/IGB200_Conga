using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapScare : MonoBehaviour
{

    private CongaLineController congaLine;
    private AnimalSpawner animalSpawner;

    // Start is called before the first frame update
    void Start()
    {

        animalSpawner = Object.FindObjectOfType<AnimalSpawner>();
        congaLine = Object.FindObjectOfType<CongaLineController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int index = Random.Range(0, congaLine.counter);
            animalSpawner.counter -= 1;
            Destroy(congaLine.followers[index].gameObject);
            congaLine.followers[index] = null;
            CongaLineController.instance.counter -= 1;
            
        }
    }

}
