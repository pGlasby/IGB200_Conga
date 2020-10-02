using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InfoUnlocker : MonoBehaviour
{
    private AlltimeVariables alltimeVariables;
    public Text[] textInfo = new Text[5];
    public TMP_Text[] textInfoPro = new TMP_Text[5];
    // Start is called before the first frame update
    void Start()
    {
        alltimeVariables = Object.FindObjectOfType<AlltimeVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i<textInfo.Length; i++)
        {
            try
            {
                if (alltimeVariables.questCompletionChecker[i] == false)
                {
                    //textInfo[i].text = "UNAVAILABLE";
                    textInfoPro[i].text = "UNAVAILABLE";
                }
            }
            catch (System.NullReferenceException)
            {
                print("add text to text array");
            }

        }
    }
}
