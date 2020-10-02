using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Shop : MonoBehaviour
{
    private AlltimeVariables alltimeVariables;
    public TMP_Text cointext;
    public GameObject approveWindow;
    
    // Start is called before the first frame update
    void Start()
    {
        alltimeVariables = Object.FindObjectOfType<AlltimeVariables>();
    }

    // Update is called once per frame
    void Update()
    {
        cointext.text = "You have:" + alltimeVariables.coins + " coins";
        if(alltimeVariables.buyNotEnoughCoins == true)
        {
            StartCoroutine(StartCounter());
        }
    }
    public void OpenApproveWindow()
    {

        approveWindow.SetActive(true);
    }
    public IEnumerator StartCounter()
    {
        approveWindow.SetActive(true);
        yield return new WaitForSeconds(2f);
        approveWindow.SetActive(false);
        alltimeVariables.buyNotEnoughCoins = false;

    }
}
