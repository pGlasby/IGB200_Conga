using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Image timerImage;
    private GameManager gameManager;
    private float timeShow;

    Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        timeShow = gameManager.timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        //timeShow = timeLimit;
        timeShow -= Time.deltaTime;
        timerText.text = timeShow.ToString("0");
        rotation -= Vector3.forward * (180/ gameManager.timeLimit) * Time.deltaTime;
        timerImage.transform.rotation = Quaternion.Euler(rotation);
    }
}
