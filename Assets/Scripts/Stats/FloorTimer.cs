using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorTimer : MonoBehaviour
{
    public int secondCount = 0;
    public int minureCount = 0;
    public bool addingTime = false;
    public GameObject timeDisplay;

    // Update is called once per frame
    void Update()
    {
        if (addingTime == false)
        {
            StartCoroutine(AddSecond());
        }
    }

    IEnumerator AddSecond()
    {
        addingTime = true;
        yield return new WaitForSeconds(1);
        secondCount += 1;

        if (secondCount == 60)
        {
            secondCount = 0;
            minureCount += 1;
        }

        if (secondCount <= 9)
        {
            if (minureCount <= 9)
            {
                timeDisplay.GetComponent<Text>().text = "0" + minureCount + ":0" + secondCount;
            }
            else
            {
                timeDisplay.GetComponent<Text>().text = "" + minureCount + ":0" + secondCount;
            }
        }
        else
        {
            if (minureCount <= 9)
            {
                timeDisplay.GetComponent<Text>().text = "0" + minureCount + ":" + secondCount;
            } else
            {
                timeDisplay.GetComponent<Text>().text = "" + minureCount + ":" + secondCount;
            }
        }
        
        addingTime = false;
    }
}

