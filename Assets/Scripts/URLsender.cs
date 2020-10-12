using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLsender : MonoBehaviour
{
    public void GoFirstURL()
    {
        Application.OpenURL("https://www.facebook.com/events/938012483331210/");
    }
    public void GoSecondURL()
    {
        Application.OpenURL("https://www.facebook.com/BurandaBCC/");
    }
}
