using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnimalLimit : MonoBehaviour
{
    private CongaLineController congaLine;
    public Text text;
    public TMP_Text textPro;
    // Start is called before the first frame update
    void Start()
    {
        congaLine = Object.FindObjectOfType<CongaLineController>();
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = congaLine.counter + "/5";
        textPro.text = congaLine.counter + "/5";
    }
}
